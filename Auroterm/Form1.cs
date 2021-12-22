using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Threading;

namespace Auroterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_Properties_Click(object sender, EventArgs e)
        {
            Form_Properties FormProperties1 = new Form_Properties();
            FormProperties1.MdiParent = this;
            FormProperties1.Show();
        }

        private void bt_SerialPort_Click(object sender, EventArgs e)
        {
            Form_SerialPort FormSerialPort1 = new Form_SerialPort();
            FormSerialPort1.MdiParent = this;
            FormSerialPort1.Show();
        }

        private void bt_MCT8132PTable_Click(object sender, EventArgs e)
        {
            Form_MCT8132PTable FormMCT8132PTable1 = new Form_MCT8132PTable();
            FormMCT8132PTable1.MdiParent = this;
            FormMCT8132PTable1.Show();
        }

        private void bt_ToolBox_Click(object sender, EventArgs e)
        {
            Form_ToolBox FormToolBox1 = new Form_ToolBox();
            FormToolBox1.MdiParent = this;
            FormToolBox1.Show();
        }
    }
}