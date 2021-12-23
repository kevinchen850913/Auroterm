using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Auroterm
{
    public partial class Form_Properties : Form
    {
        
        public Form_Properties()
        {
            InitializeComponent();
        }

        private void Form_Properties_Load(object sender, EventArgs e)
        {
            foreach (string Name in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmb_PortName.Items.Add(Name);
            }
        }

        private void bt_textBoxFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Table_SerialPort.font = dlg.Font;
            }  
        }

        private void bt_textBoxForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Table_SerialPort.ForeColor = dlg.Color;
            }
        }

        private void bt_textBoxBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Table_SerialPort.BackColor = dlg.Color;
            }
        }

        private void cmb_PortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_SerialPort_Open.PerformClick();
        }

        private void bt_SerialPort_Open_Click(object sender, EventArgs e)
        {
            Table_SerialPort.PortName = cmb_PortName.SelectedItem.ToString();
            Table_SerialPort.Trigger_Open = true;
        }

        private void bt_SerialPort_Close_Click(object sender, EventArgs e)
        {
            Table_SerialPort.Trigger_Close = true;
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();
        }

        private void bt_FileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "(*.txt)|*.txt||*.*";
            sfd.DefaultExt = "txt";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    //sw.Write(textBox1.Text);
                }
            }
        }
    }
}