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
        mySystem mySys;
        public Form_Properties(mySystem m_mySys)
        {
            InitializeComponent();
            mySys = m_mySys;
        }

        private void Form_Properties_Load(object sender, EventArgs e)
        {
            foreach (string Name in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmb_PortName.Items.Add(Name);
            }
            cmb_PortName.SelectedItem = mySys.mySerialPort.PortName;
        }

        private void bt_textBoxFont_Click(object sender, EventArgs e)
        {
            //FontDialog dlg = new FontDialog();
            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    SerialPort.font = dlg.Font;
            //    SerialPort.Trigger_Font = true;
            //}  
        }

        private void bt_textBoxForeColor_Click(object sender, EventArgs e)
        {
            //ColorDialog dlg = new ColorDialog();
            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    SerialPort.ForeColor = dlg.Color;
            //    SerialPort.Trigger_ForeColor = true;
            //}
        }

        private void bt_textBoxBackColor_Click(object sender, EventArgs e)
        {
            //ColorDialog dlg = new ColorDialog();
            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    SerialPort.BackColor = dlg.Color;
            //    SerialPort.Trigger_BackColor = true;
            //}
        }

        private void cmb_PortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_SerialPort_Open.PerformClick();
        }

        private void bt_SerialPort_Open_Click(object sender, EventArgs e)
        {
            mySys.SerialPort_Open(cmb_PortName.SelectedItem.ToString());
        }

        private void bt_SerialPort_Close_Click(object sender, EventArgs e)
        {
            mySys.mySerialPort.Close();
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            mySys.mySerialPortText = "";
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
                    sw.Write(mySys.mySerialPortText);
                }
            }
        }
    }
}