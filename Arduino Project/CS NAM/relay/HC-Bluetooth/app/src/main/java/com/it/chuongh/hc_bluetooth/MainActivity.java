package com.it.chuongh.hc_bluetooth;

import android.bluetooth.BluetoothAdapter;
import android.bluetooth.BluetoothDevice;
import android.bluetooth.BluetoothSocket;
import android.content.Intent;
import android.content.pm.ActivityInfo;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.CompoundButton;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.ToggleButton;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.util.UUID;

public class MainActivity extends AppCompatActivity {


    private ToggleButton btnToggle01;
    private ToggleButton btnToggle02;
    private ToggleButton btnToggle03;
    private ToggleButton btnToggle04;
    private ToggleButton btnToggle05;
    private ToggleButton btnToggle06;
    private static final int ENABLE_BLUETOOTH_REQUEST_CODE = 0;
    private BluetoothAdapter bluetoothAdapter;
    private BluetoothDevice bluetoothDevice;
    private BluetoothSocket bluetoothSocket = null;
    private TextView textViewH;
    private TextView textViewD;
    private OutputStream outputStream;
    private InputStream inputStream;
    private Thread thread;
    private byte buffer[];

    // SPP UUID service - this should work for most devices
    private final UUID uuid = UUID.fromString("00001101-0000-1000-8000-00805F9B34FB");
    // String for MAC address
    private final String address = "20:16:06:22:80:07";
    private int readBufferPosition;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_USER_PORTRAIT);
        setContentView(R.layout.activity_main);

        bluetoothAdapter = BluetoothAdapter.getDefaultAdapter();

        if (bluetoothAdapter == null) {
            setEnableControls(false);
            Toast.makeText(getApplicationContext(), "Your device does not support Bluetooth.", Toast.LENGTH_LONG).show();
        } else {
            btnToggle01 = (ToggleButton) findViewById(R.id.toggleButton1);
            btnToggle01.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
                @Override
                public void onCheckedChanged(CompoundButton compoundButton, boolean isChecked) {
                    if (isChecked == true) {
                        try {
                            write((byte) 111);
                            //Toast.makeText(getBaseContext(), "Turned on device 1.", Toast.LENGTH_SHORT).show();
                        } catch (Exception e) {
                            //Toast.makeText(getBaseContext(), e.getMessage(), Toast.LENGTH_SHORT).show();
                        }
                    } else {
                        try {
                            write((byte) 101);
                            //Toast.makeText(getBaseContext(), "Turned off device 1.", Toast.LENGTH_SHORT).show();
                        } catch (Exception e) {
                            //Toast.makeText(getBaseContext(), e.getMessage(), Toast.LENGTH_SHORT).show();
                        }
                    }
                }
            });
            btnToggle02 = (ToggleButton) findViewById(R.id.toggleButton2);
            btnToggle02.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
                @Override
                public void onCheckedChanged(CompoundButton compoundButton, boolean isChecked) {
                    if (isChecked == true) {
                        try {
                            write((byte) 112);
                            //Toast.makeText(getBaseContext(), "Turned on device 2.", Toast.LENGTH_SHORT).show();
                        } catch (Exception e) {
                            //Toast.makeText(getBaseContext(), e.getMessage(), Toast.LENGTH_SHORT).show();
                        }
                    } else {
                        try {
                            write((byte) 102);
                            //Toast.makeText(getBaseContext(), "Turned off device 2.", Toast.LENGTH_SHORT).show();
                        } catch (Exception e) {
                            //Toast.makeText(getBaseContext(), e.getMessage(), Toast.LENGTH_SHORT).show();
                        }
                    }
                }
            });
            btnToggle03 = (ToggleButton) findViewById(R.id.toggleButton3);
            btnToggle03.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
                @Override
                public void onCheckedChanged(CompoundButton compoundButton, boolean isChecked) {
                    if (isChecked == true) {
                        try {
                            write((byte) 113);
                            //Toast.makeText(getBaseContext(), "Turned on device 3.", Toast.LENGTH_SHORT).show();
                        } catch (Exception e) {
                            //Toast.makeText(getBaseContext(), e.getMessage(), Toast.LENGTH_SHORT).show();
                        }
                    } else {
                        try {
                            write((byte) 103);
                            //Toast.makeText(getBaseContext(), "Turned off device 3.", Toast.LENGTH_SHORT).show();
                        } catch (Exception e) {
                            //Toast.makeText(getBaseContext(), e.getMessage(), Toast.LENGTH_SHORT).show();
                        }
                    }
                }
            });

            btnToggle04 = (ToggleButton) findViewById(R.id.toggleButton4);
            btnToggle04.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
                @Override
                public void onCheckedChanged(CompoundButton compoundButton, boolean isChecked) {
                    if (isChecked == true) {
                        try {
                            write((byte) 114);
                            //Toast.makeText(getBaseContext(), "Turned on device 4.", Toast.LENGTH_SHORT).show();
                        } catch (Exception e) {
                            //Toast.makeText(getBaseContext(), e.getMessage(), Toast.LENGTH_SHORT).show();
                        }
                    } else {
                        try {
                            write((byte) 104);
                            //Toast.makeText(getBaseContext(), "Turned off device 4.", Toast.LENGTH_SHORT).show();
                        } catch (Exception e) {
                            //Toast.makeText(getBaseContext(), e.getMessage(), Toast.LENGTH_SHORT).show();
                        }
                    }
                }
            });

            btnToggle05 = (ToggleButton) findViewById(R.id.toggleButton5);
            btnToggle05.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
                @Override
                public void onCheckedChanged(CompoundButton compoundButton, boolean isChecked) {
                    if (isChecked == true) {
                        try {
                            write((byte) 115);
                            //Toast.makeText(getBaseContext(), "Turned on device 5.", Toast.LENGTH_SHORT).show();
                        } catch (Exception e) {
                            //Toast.makeText(getBaseContext(), e.getMessage(), Toast.LENGTH_SHORT).show();
                        }
                    } else {
                        try {
                            write((byte) 105);
                            //Toast.makeText(getBaseContext(), "Turned off device 5.", Toast.LENGTH_SHORT).show();
                        } catch (Exception e) {
                            //Toast.makeText(getBaseContext(), e.getMessage(), Toast.LENGTH_SHORT).show();
                        }
                    }
                }
            });
            btnToggle06 = (ToggleButton) findViewById(R.id.toggleButton6);
            btnToggle06.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
                @Override
                public void onCheckedChanged(CompoundButton compoundButton, boolean isChecked) {
                    if (isChecked == true) {
                        try {
                            write((byte) 116);//16
                            //Toast.makeText(getBaseContext(), "Turned on device 6.", Toast.LENGTH_SHORT).show();
                        } catch (Exception e) {
                            //Toast.makeText(getBaseContext(), e.getMessage(), Toast.LENGTH_SHORT).show();
                        }
                    } else {
                        try {
                            write((byte) 106);
                            //Toast.makeText(getBaseContext(), "Turned off device 6.", Toast.LENGTH_SHORT).show();
                        } catch (Exception e) {
                            //Toast.makeText(getBaseContext(), e.getMessage(), Toast.LENGTH_SHORT).show();
                        }
                    }
                }
            });
        }
    }

    private void setEnableControls(boolean state) {
        btnToggle01.setEnabled(state);
        btnToggle02.setEnabled(state);
        btnToggle03.setEnabled(state);
        btnToggle04.setEnabled(state);
        btnToggle05.setEnabled(state);
        btnToggle06.setEnabled(state);
    }

    private void synch(String value) {
        if (value.indexOf("111~") != -1) {
            btnToggle01.setChecked(true);
        }
        if (value.indexOf("112~") != -1) {
            btnToggle02.setChecked(true);
        }
        if (value.indexOf("113~") != -1) {
            btnToggle03.setChecked(true);
        }
        if (value.indexOf("114~") != -1) {
            btnToggle04.setChecked(true);
        }
        if (value.indexOf("115~") != -1) {
            btnToggle05.setChecked(true);
        }
        if (value.indexOf("116~") != -1) {
            btnToggle06.setChecked(true);
        }
    }

    @Override
    public void onStart() {
        super.onStart();
        on(null);
    }

    private void on(View view) {
        if (bluetoothAdapter.isEnabled() == false) {
            Intent enableBluetoothIntent = new Intent(BluetoothAdapter.ACTION_REQUEST_ENABLE);
            startActivityForResult(enableBluetoothIntent, ENABLE_BLUETOOTH_REQUEST_CODE);

            // waiting turn on bluetooth
            //while (!bluetoothAdapter.isEnabled()) {
            //;
            //}
        } else {
            // If the resultCode is 1, the user selected “Yes” when prompt to
            while (pair(null)) {
                ;
            }
        }
    }

    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if (requestCode == ENABLE_BLUETOOTH_REQUEST_CODE) {
            if (resultCode == 0) {
                // If the resultCode is 0, the user selected “No” when prompt to
                finish();
                System.exit(1);
            } else {
                // If the resultCode is 1, the user selected “Yes” when prompt to
                while (pair(null)) {
                    ;
                }
                //Toast.makeText(this, "User allowed bluetooth access!", Toast.LENGTH_SHORT).show();
            }
        }
    }

    private BluetoothSocket createBluetoothSocket(BluetoothDevice bluetoothDevice)
            throws IOException {

        return bluetoothDevice.createRfcommSocketToServiceRecord(uuid);
    }

    private boolean pair(View view) {

        bluetoothDevice = bluetoothAdapter.getRemoteDevice(address);

        try {
            bluetoothSocket = createBluetoothSocket(bluetoothDevice);
        } catch (IOException e) {
            Toast.makeText(getBaseContext(), "Socket creation failed.", Toast.LENGTH_SHORT).show();
        }
        // Establish the Bluetooth socket connection.
        try {
            bluetoothSocket.connect();

            try {
                outputStream = bluetoothSocket.getOutputStream();
            } catch (IOException e) {
                //e.printStackTrace();
            }
            try {
                inputStream = bluetoothSocket.getInputStream();
            } catch (IOException e) {
                //e.printStackTrace();
            }
            beginListenForData();
            write((byte) 200);//
        } catch (IOException e) {
            try {
                bluetoothSocket.close();
            } catch (IOException closeBluetoothSocket) {
                Toast.makeText(getBaseContext(), " error in closeBluetoothSocket of pair.", Toast.LENGTH_SHORT).show();
            }
        }
        if (bluetoothSocket.isConnected() == false)
            return false;
        return true;
    }

    public void write(byte value) {
        try {
            outputStream.write(value);
        } catch (IOException e) {
            //e.printStackTrace();
        }
    }

    void beginListenForData() {
        final Handler handler = new Handler();
        readBufferPosition = 0;
        //stopThread = false;
        buffer = new byte[1024];
        Thread thread = new Thread(new Runnable() {
            public void run() {
                while (!Thread.currentThread().isInterrupted()) {
                    try {
                        int byteCount = inputStream.available();
                        if (byteCount > 0) {
                            final byte[] rawBytes = new byte[byteCount];
                            inputStream.read(rawBytes);
                            for (int i = 0; i < byteCount; i++) {
                                byte b = rawBytes[i];
                                if (b == 10) {
                                    byte[] encodedBytes = new byte[readBufferPosition];
                                    System.arraycopy(buffer, 0, encodedBytes, 0, encodedBytes.length);
                                    final String string = new String(encodedBytes);
                                    readBufferPosition = 0;
                                    handler.post(new Runnable() {
                                        public void run() {
                                            synch(string);
                                        }
                                    });
                                } else {
                                    buffer[readBufferPosition++] = b;
                                }
                            }
                        }
                    } catch (IOException ex) {
                        //stopThread = true;
                    }
                }
            }
        });

        thread.start();
    }
}
