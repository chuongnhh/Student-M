//======================================================authorship
//CC-BY Michael Osthege (2013)
//======================================================
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TCD.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using TCD.Arduino.Bluetooth;
using Windows.UI.Popups;

namespace BluetoothCommunicationSampleController
{
    /// <summary>
    /// IMPORTANT:
    /// in Package.appxmanifest make sure that you declare the following capabilities:
    /*
  ...
  <Capabilities>
    <m2:DeviceCapability Name="bluetooth.rfcomm">
      <m2:Device Id="any">
        <m2:Function Type="name:serialPort" />
      </m2:Device>
    </m2:DeviceCapability>
  </Capabilities>
  ...
</Package>
     */
    /// </summary>

    /* Before you can connect a Bluetooth device to Windows (Phone) 8, you have to go to the Bluetooth settings
     * (Win+I\PC Settings\Devices\Bluetooth) and pair the device. Probably you have to enter a PIN, which is often 1234
     * 
     * After you've paired the device, you can launch the BluetoothCommunicationSampleController app and tap "Connect"
     */


    public sealed partial class MainPage : Page
    {
        private Dictionary<string, bool> leds = new Dictionary<string, bool>();                 //keep track of LED states
        
        public MainPage()
        {
            this.InitializeComponent();
            App.BluetoothManager.messageReceived += bluetoothManager_MessageReceived;
            App.BluetoothManager.exceptionOccured += BluetoothManager_ExceptionOccured;
        }
        protected override void OnNavigatedFrom(Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            App.BluetoothManager.Disconnect();//clean up the mess
        }
        private void WriteLine(string line)//write a new line to the "Console"
        {
            console.Text += line + "\n";
            scrollViewer.ChangeView(0, scrollViewer.ScrollableHeight, 1, false);
        }

        #region Bluetooth Connection Lifecycle
        //control
        private  void BluetoothConnect_Click(object sender, RoutedEventArgs e)
        {
            leds.Clear();//reset LED state cache 
            leds.Add("RED", false);
            leds.Add("GREEN", false);
            //ask the user to connect 
            //await App.BluetoothManager.EnumerateDevicesAsync((sender as Button).GetElementRect());//displays a PopupMenu above the ConnectButton - uses GetElementRect() from TCD.Controls to determine the area
            App.BluetoothManager.connect("HC-06");
        }
        private async void BluetoothManager_ExceptionOccured(object sender, Exception ex)
        {
            var md = new MessageDialog(ex.Message, "We've got a problem with bluetooth...");
            md.Commands.Add(new UICommand("Ah.. thanks.."));
            md.DefaultCommandIndex = 0;
            var result = await md.ShowAsync();
        }        
        #endregion

        #region Send & Receive
        private async void LEDButton_Click(object sender, RoutedEventArgs e)
        {
            byte ledcol = 13;
            if ((sender as Button).Tag.ToString() == "2")
            {
                ledcol = 14;
            }
            await App.BluetoothManager.SendMessageAsync(ledcol);
        }
        private async void bluetoothManager_MessageReceived(object sender, string message)
        {
            MessageDialog ms = new MessageDialog(message);
            await ms.ShowAsync();
            //int equIndex = message.IndexOf('=');
            //if (equIndex > 0)//is this a report? (eg: "A0=245" alternative: confirmation like "RED_ON")
            //{
            //    switch (message.Substring(0, equIndex))//we can receive more than one report...
            //    {
            //        case "A0": A0bar.Value = Convert.ToInt32(message.Substring(equIndex + 1)); break;
            //    }
            //    if (A0bar.Value > 512)
            //        await App.BluetoothManager.SendMessageAsync("TURN_ON_RED");
            //    else
            //        await App.BluetoothManager.SendMessageAsync("TURN_OFF_RED");
            //}
            //else
            //{
            //    switch (message)//interpret other messages
            //    {
            //        case "RED_OFF": leds["RED"] = false; break;//remember the LED state
            //        case "RED_ON": leds["RED"] = true; break;
            //        case "GREEN_OFF": leds["GREEN"] = false; break;
            //        case "GREEN_ON": leds["GREEN"] = true; break;
            //    }
            //}
            ////log incoming transmission
            //WriteLine("< " + message);
        }
        #endregion

    }
}