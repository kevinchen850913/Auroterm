using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Auroterm
{
    public partial class Form_SerialPort : Form
    {
        mySystem mySys;
        public Form_SerialPort(mySystem m_mySys)
        {
            InitializeComponent();
            mySys = m_mySys;
        }

        private void Form_SerialPort_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mySys.mySerialPort.IsOpen && !IsStop)
            {
                textBox1.Text = mySys.mySerialPortText;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }
            //if (SerialPort.Trigger_Clear)
            //{
            //    textBox1.Text = SerialPort.Text;
            //    SerialPort.Trigger_Clear = false;
            //}
            //if (SerialPort.Trigger_Font)
            //{
            //    textBox1.Font = SerialPort.font;
            //    SerialPort.Trigger_Font = false;
            //}
            //if (SerialPort.Trigger_ForeColor)
            //{
            //    textBox1.ForeColor = SerialPort.ForeColor;
            //    SerialPort.Trigger_ForeColor = false;
            //}
            //if (SerialPort.Trigger_BackColor)
            //{
            //    textBox1.BackColor = SerialPort.BackColor;
            //    SerialPort.Trigger_BackColor = false;
            //}
        }

        bool IsStop = false;
        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IsStop = !IsStop;
        }
    }
}