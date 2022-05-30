using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Auroterm
{
    public class mySystem
    {
        public Timer myTimer;
        public System.IO.Ports.SerialPort mySerialPort;
        public string mySerialPortBuffer;
        public string mySerialPortText;

        public mySystem()
        {
            InitializeTimer();
            InitializeSerialPort();
        }

        private void InitializeTimer()
        {
            myTimer = new Timer();
            myTimer.Interval = 100;
            myTimer.Tick += new EventHandler(myTimer_Tick);
            // Enable timer.  
            myTimer.Enabled = true; 
        }

        private void InitializeSerialPort()
        {
            mySerialPort = new System.IO.Ports.SerialPort();
            mySerialPort.BaudRate = 115200;
            mySerialPort.ReceivedBytesThreshold = 1;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.NewLine = "\n";
            mySerialPortBuffer = "";
            mySerialPortText = "";
            mySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SerialPort_Receive);
        }

        private void SerialPort_Receive(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (true)
            {
                try
                {
                    String Line;
                    mySerialPortBuffer = mySerialPort.ReadLine();
                    if (mySerialPortBuffer.Length > 1)
                    {
                        Line = mySerialPortBuffer.Trim('\r');
                        mySerialPortText = mySerialPortText + Line + "\r\n";
                        Table_MCT8132P.update(Line);
                    }
                }
                catch (Exception Error_SerialPortRead)
                {
                    break;
                }
            }
        }

        public bool SerialPort_Open(string portName)
        {
            try
            {
                mySerialPort.PortName = portName;
                if (mySerialPort.IsOpen)
                {
                    mySerialPort.Close();
                }
                mySerialPort.Open();
            }
            catch (Exception Error_SerialPortOpen)
            {
                return false;
            }
            return true;
        }

        private void myTimer_Tick(object Sender, EventArgs e)
        {

        }  
    }
}
