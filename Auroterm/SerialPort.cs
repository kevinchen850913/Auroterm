using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
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
                SerialPort.update(LineBuffer);
            }
        }
    }

    static class SerialPort
    {
        public static bool Trigger_Open;
        public static bool Trigger_Close;
        public static bool Trigger_Font;
        public static bool Trigger_ForeColor;
        public static bool Trigger_BackColor;
        public static bool Trigger_Clear;

        public static String PortName;
        public static int BaudRate = 115200;
        public static int ReceivedBytesThreshold = 1;
        public static Parity Parity = Parity.None;
        public static StopBits StopBits = StopBits.One;
        public static int DataBits = 8;
        public static Handshake Handshake = Handshake.None;
        public static String NewLine = "\n";

        public static bool IsOpen;
        public static Font font;
        public static Color ForeColor;
        public static Color BackColor;

        public static string Text = "";

        public static void update(string Line)
        {
            Line = Line.Trim('\r') ;
            Text = Text + Line + "\r\n";
            Table_MCT8132P.update(Line);
        }

        public static void Clear()
        {
            Text = "";
            Trigger_Clear = true;
        }
    }
}
