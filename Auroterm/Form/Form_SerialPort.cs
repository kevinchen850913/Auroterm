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
        public Form_SerialPort()
        {
            InitializeComponent();
        }

        private void Form_SerialPort_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Table_SerialPort.IsOpen && !IsStop)
            {
                textBox1.Text = Table_SerialPort.Text;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }
            if (Table_SerialPort.Trigger_Clear)
            {
                textBox1.Text = Table_SerialPort.Text;
                Table_SerialPort.Trigger_Clear = false;
            }
            if (Table_SerialPort.Trigger_Font)
            {
                textBox1.Font = Table_SerialPort.font;
                Table_SerialPort.Trigger_Font = false;
            }
            if (Table_SerialPort.Trigger_ForeColor)
            {
                textBox1.ForeColor = Table_SerialPort.ForeColor;
                Table_SerialPort.Trigger_ForeColor = false;
            }
            if (Table_SerialPort.Trigger_BackColor)
            {
                textBox1.BackColor = Table_SerialPort.BackColor;
                Table_SerialPort.Trigger_BackColor = false;
            }
        }

        bool IsStop = false;
        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IsStop = !IsStop;
        }
    }
}