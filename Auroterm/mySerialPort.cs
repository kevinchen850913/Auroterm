using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace Auroterm
{
    class mySerialPort : System.IO.Ports.SerialPort
    {
        string[] MCT8132P = new string[7];
        public string LineBuffer = "";

        public mySerialPort()
        {
            BaudRate = 115200;
            ReceivedBytesThreshold = 1;
            Parity = Parity.None;
            StopBits = StopBits.One;
            DataBits = 8;
            Handshake = Handshake.None;
            NewLine = "\n";
            DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(m_Receive);
        }

        public bool Auroterm_Open(string portName)
        {
            try
            {
                PortName = portName;
                if (IsOpen)
                {
                    Close();
                }
                Open();
            }
            catch (Exception eOpen)
            {
                return false;
            }
            return true;
        }

        private void m_Receive(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (true)
            {
                try
                {
                    m_Read();
                }
                catch (Exception eRead)
                {
                    break;
                }
            }
        }
        private void m_Read()
        {
            LineBuffer = ReadLine();
            if (LineBuffer.Length > 1)
            {
                Table_SerialPort.update(LineBuffer);
            }
        }
    }
}
