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
        mySerialPort SerialPort1 = new mySerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private bool FindForm(string formName)
        {
            bool isFind = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == formName)
                {
                    isFind = true;
                    form.MdiParent = this;
                    form.Focus();
                }
            }
            return isFind;
        }

        private void bt_Properties_Click(object sender, EventArgs e)
        {
            if (!FindForm("Form_Properties"))
            {
                Form_Properties FormProperties1 = new Form_Properties();
                FormProperties1.MdiParent = this;
                FormProperties1.Show();
            }
        }

        private void bt_SerialPort_Click(object sender, EventArgs e)
        {
            if (!FindForm("Form_SerialPort"))
            {
                Form_SerialPort FormSerialPort1 = new Form_SerialPort();
                FormSerialPort1.MdiParent = this;
                FormSerialPort1.Show();
            }
        }

        private void bt_Table_MCT8132P_Click(object sender, EventArgs e)
        {
            if (!FindForm("Form_MCT8132P"))
            {
                Form_MCT8132P FormTable_MCT8132P1 = new Form_MCT8132P();
                FormTable_MCT8132P1.MdiParent = this;
                FormTable_MCT8132P1.Show();
            }
        }

        private void bt_ToolBox_Click(object sender, EventArgs e)
        {
            if (!FindForm("Form_ToolBox"))
            {
                Form_ToolBox FormToolBox1 = new Form_ToolBox();
                FormToolBox1.MdiParent = this;
                FormToolBox1.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Table_SerialPort.Trigger_Open)
            {
                SerialPort1.Auroterm_Open(Table_SerialPort.PortName);
                Table_SerialPort.Trigger_Open = false;
                Table_SerialPort.IsOpen = SerialPort1.IsOpen;
            }
            if (Table_SerialPort.Trigger_Close)
            {
                SerialPort1.Close();
                Table_SerialPort.Trigger_Close = false;
                Table_SerialPort.IsOpen = SerialPort1.IsOpen;
            }
        }
    }
}