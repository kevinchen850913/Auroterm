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
            textBox1.Text = Table_SerialPort.Text;
        }
    }
}