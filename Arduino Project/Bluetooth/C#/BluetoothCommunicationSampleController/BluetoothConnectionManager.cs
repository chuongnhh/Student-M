using System;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;
using Windows.UI.Popups;

namespace TCD.Arduino.Bluetooth
{
    public class BluetoothConnectionManager : PropertyChangedBase
    {
        #region Events
        //OnExceptionOccured
        public delegate void addOnExceptionOccuredDelegate(object sender, Exception ex);
        public event addOnExceptionOccuredDelegate exceptionOccured;
        private void onExceptionOccuredEvent(object sender, Exception ex)
        {
            if (exceptionOccured != null)
                exceptionOccured(sender, ex);
        }
        //OnMessageReceived
        public delegate void addOnMessageReceivedDelegate(object sender, string message);
        public event addOnMessageReceivedDelegate messageReceived;
        private void onMessageReceivedEvent(object sender, string message)
        {
            if (messageReceived != null)
                messageReceived(sender, message);
        }
        #endregion

        #region Commands
        public RelayCommand BluetoothCancelCommand { get; private set; }
        public RelayCommand BluetoothDisconnectCommand { get; private set; }
        #endregion

        #region Variables
        private IAsyncOperation<RfcommDeviceService> connectService;
        private IAsyncAction connectAction;
        private RfcommDeviceService rfcommService;
        private StreamSocket socket;
        private DataReader reader;
        private DataWriter writer;

        private BluetoothConnectionState _State;
        public BluetoothConnectionState State { get { return _State; } set { _State = value; OnPropertyChanged(); } }
        #endregion

        #region Lifecycle
        public BluetoothConnectionManager()
        {
            BluetoothCancelCommand = new RelayCommand(AbortConnection);
            BluetoothDisconnectCommand = new RelayCommand(Disconnect);
        }

        /// <summary>
        /// Displays a PopupMenu for selection of the other Bluetooth device.
        /// Continues by establishing a connection to the selected device.
        /// </summary>
        /// <param name="invokerRect">for example: connectButton.GetElementRect();</param>
        //public  void EnumerateDevicesAsync(Rect invokerRect)
        //{
        //    //this.State = BluetoothConnectionState.Enumerating;
        //    //string tmp = RfcommDeviceService.GetDeviceSelector(RfcommServiceId.SerialPort);
        //    //var serviceInfoCollection = await DeviceInformation.FindAllAsync(tmp);

        //    ////MessageDialog ms = new MessageDialog(tmp);
        //    ////await ms.ShowAsync();

        //    //PopupMenu menu = new PopupMenu();
        //    //foreach (var serviceInfo in serviceInfoCollection)
        //    //{
        //    //    //ms = new MessageDialog(serviceInfo.Name);
        //    //    //await ms.ShowAsync();
        //    //    menu.Commands.Add(
        //    //            new UICommand("HC-06",
        //    //            new UICommandInvokedHandler(delegate (IUICommand command)
        //    //            {
        //    //                Task connect = ConnectToServiceAsync(command);
        //    //            }),
        //    //            serviceInfo));
        //    //}
        //    //var result = await menu.ShowForSelectionAsync(invokerRect);
        //    //if (result == null)
        //    //    this.State = BluetoothConnectionState.Disconnected;
        //}
        private async Task ConnectToServiceAsync(DeviceInformation deviceInformation)
        {
            //DeviceInformation serviceInfo = (DeviceInformation)command.Id;
            this.State = BluetoothConnectionState.Connecting;
            try
            {
                // Initialize the target Bluetooth RFCOMM device service
                connectService = RfcommDeviceService.FromIdAsync(deviceInformation.Id);
                rfcommService = await connectService;
                if (rfcommService != null)
                {
                    // Create a socket and connect to the target 
                    socket = new StreamSocket();
                    connectAction = socket.ConnectAsync(rfcommService.ConnectionHostName, rfcommService.ConnectionServiceName, SocketProtectionLevel.BluetoothEncryptionAllowNullAuthentication);
                    await connectAction;//to make it cancellable
                    writer = new DataWriter(socket.OutputStream);
                    reader = new DataReader(socket.InputStream);
                    Task listen = ListenForMessagesAsync();
                    this.State = BluetoothConnectionState.Connected;
                }
                else
                    onExceptionOccuredEvent(this, new Exception("Unable to create service.\nMake sure that the 'bluetooth.rfcomm' capability is declared with a function of type 'name:serialPort' in Package.appxmanifest."));
            }
            catch (TaskCanceledException)
            {
                this.State = BluetoothConnectionState.Disconnected;
            }
            catch (Exception ex)
            {
                this.State = BluetoothConnectionState.Disconnected;
                onExceptionOccuredEvent(this, ex);
            }
        }
        public async void connect(string bluetoothName)
        {
            // Find all paired instances of the Rfcomm chat service
            DeviceInformationCollection deviceCollection = await DeviceInformation.FindAllAsync(
                    RfcommDeviceService.GetDeviceSelector(RfcommServiceId.SerialPort));

            DeviceInformation deviceInformation = null;

            foreach (DeviceInformation search in deviceCollection)
            {
                if (search.Name.ToUpper() == bluetoothName.ToUpper())
                {
                    deviceInformation = search;
                    break;
                }
            }

            if (socket != null)
            {
                // Disposing the socket with close it and release all resources associated with the socket
                socket.Dispose();
            }

            await ConnectToServiceAsync(deviceInformation);
        }

        /// <summary>
        /// Abort the connection attempt.
        /// </summary>
        public void AbortConnection()
        {
            if (connectService != null && connectService.Status == AsyncStatus.Started)
                connectService.Cancel();
            if (connectAction != null && connectAction.Status == AsyncStatus.Started)
                connectAction.Cancel();
        }
        /// <summary>
        /// Terminate an connection.
        /// </summary>
        public void Disconnect()
        {
            if (reader != null)
                reader = null;
            if (writer != null)
            {
                writer.DetachStream();
                writer = null;
            }
            if (socket != null)
            {
                socket.Dispose();
                socket = null;
            }
            if (rfcommService != null)
                rfcommService = null;
            this.State = BluetoothConnectionState.Disconnected;
        }
        #endregion

        #region Send & Receive
        /// <summary>
        /// Send a string message.
        /// </summary>
        /// <param name="message">The string to send.</param>
        /// <returns></returns>
        public async Task<uint> SendMessageAsync(byte message)
        {
            uint sentMessageSize = 0;
            if (writer != null)
            {
                //uint messageSize = writer.MeasureString(message);
                writer.WriteByte(message);
                //sentMessageSize = writer.WriteString(message);
                await writer.StoreAsync();
            }
            return sentMessageSize;
        }
        /// <summary>
        /// Helper method to convert strings into bytes 
        /// </summary>
        /// <param name="text">input string</param>
        /// <returns>UTF8 encoded array of bytes</returns>
        private static byte[] TextToBytes(string text)
        {
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            Byte[] messageBytes = UTF8.GetBytes((string)text);
            return messageBytes;
        }

        /// <summary>
        /// Helper method to convert bytes into strings. 
        /// Does a quick and dirty UTF8 conversion
        /// </summary>
        /// <param name="text">array of bytes</param>
        /// <returns>string of text</returns>
        private static string BytesToText(byte[] text)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                s.Append((char)text[i]);
            }
            return s.ToString();
        }
        private async Task ListenForMessagesAsync()
        {
            while (reader != null)
            {
                try
                {
                    //// Read first byte (length of the subsequent message, 255 or less). 
                    uint sizeFieldCount = await reader.LoadAsync(1);
                    if (sizeFieldCount != 1)
                    {
                        // The underlying socket was closed before we were able to read the whole data. 
                        return;
                    }

                    // Read the message. 
                    uint messageLength = reader.ReadByte();

                    // Read the message and process it.
                    string message = messageLength.ToString();
                    onMessageReceivedEvent(this, message);
                }
                catch (Exception ex)
                {
                    if (reader != null)
                        onExceptionOccuredEvent(this, ex);
                }
            }
        }
        #endregion
    }
    public enum BluetoothConnectionState
    {
        Disconnected,
        Connected,
        Enumerating,
        Connecting
    }
}