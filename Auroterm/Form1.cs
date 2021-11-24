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
        
        mySerialPort SerialPort1 = new mySerialPort();
        private bool MouseInTextBox = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string Name in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmb_PortName.Items.Add(Name);
            }
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            foreach (FontFamily fontFamilie in installedFontCollection.Families)
            {
                cmb_familyName.Items.Add(fontFamilie.Name);
            }
            tb_Upgrade_Path.Text = Directory.GetCurrentDirectory();
            timer1.Enabled = true;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            tb_SerialPortIsOpen.Text = SerialPort1.IsOpen.ToString();
            if (SerialPort1.IsOpen)
            {
                UIupdate();            
            }     
            timer1.Enabled = true;
        }
        
        private void UIupdate()
        {
            if (MouseInTextBox)
            {
                return;
            }
            textBox1.AppendText(SerialPort1.ReadBuffer);
            SerialPort1.ReadBuffer = "";

            tb_EtherCATMaster.Text = MCT8132PTable.EtherCATMaster;
            tb_Isstop.Text = MCT8132PTable.Isstop.ToString();

            tb_JOB_ProcessAllRxFrames.Text = MCT8132PTable.JOB_ProcessAllRxFrames.ToString();
            tb_JOB_SendAllCycFrames.Text = MCT8132PTable.JOB_SendAllCycFrames.ToString();
            tb_JOB_MasterTimer.Text = MCT8132PTable.JOB_MasterTimer.ToString();
            tb_JOB_SendAcycFrames.Text = MCT8132PTable.JOB_SendAcycFrames.ToString();
            tb_JOB_CycleTime.Text = MCT8132PTable.JOB_CycleTime.ToString();
            tb_myAppWorkPd.Text = MCT8132PTable.myAppWorkPd.ToString();
            tb_WriteDCMlogfile.Text = MCT8132PTable.WriteDCMlogfile.ToString();

            tb_PerfMsmt_MCU.Text = MCT8132PTable.MCU.ToString();
            tb_PerfMsmt_APP.Text = MCT8132PTable.APP.ToString();
            tb_PerfMsmt_EtherCAT.Text = MCT8132PTable.EtherCAT.ToString();
        }

        private void bt_SerialPort_Open_Click(object sender, EventArgs e)
        {
            SerialPort1.Auroterm_Open(cmb_PortName.SelectedItem.ToString());
            CheckSerialPortIsOpen();
        }

        private void bt_SerialPort_Close_Click(object sender, EventArgs e)
        {
            SerialPort1.Close();
            CheckSerialPortIsOpen();
        }

        private void cmb_PortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_SerialPort_Open.PerformClick();
        }

        private void CheckSerialPortIsOpen()
        {
            if (SerialPort1.IsOpen)
            {
                textBox1.ReadOnly = false;
                timer1.Enabled = true;
            }
            else
            {
                textBox1.ReadOnly = true;
                timer1.Enabled = false;
            }
        }

        private void bt_TextBox_update_Click(object sender, EventArgs e)
        {
            try
            {
                float f = 9;
                if (float.TryParse(tb_textBoxEmSize.Text, out f))
                {
                    Font font = new Font(cmb_familyName.SelectedItem.ToString(), f, FontStyle.Regular, GraphicsUnit.Point);
                    textBox1.Font = font;
                }
                else
                {
                    MessageBox.Show("TextBox update fail!");
                }
            }
            catch (Exception eUpdatefont)
            {
                MessageBox.Show("TextBox update fail!");
            }
        }

        private void btn_Upgrade_SetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_Upgrade_Path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_Upgrade_Start_Click(object sender, EventArgs e)
        {
            if (!SerialPort1.IsOpen)
            {
                MessageBox.Show("SerialPort is close!");
                return;
            }
            if (!System.IO.File.Exists(tb_Upgrade_Path.Text + @"\Upgrade"))
            {
                MessageBox.Show("Not found Upgrade");
                return;
            }
            if (!System.IO.File.Exists(tb_Upgrade_Path.Text + @"\app"))
            {
                MessageBox.Show("Not found app");
                return;
            }
            Upgrade.Start(tb_Upgrade_Path.Text, tb_Upgrade_boardNo.Text); 
        }

        DateTime dt;
        private void btn_Upgrade_AutoStart_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(tb_Upgrade_Path.Text + @"\Upgrade"))
            {
                MessageBox.Show("Not found Upgrade");
                return;
            }
            if (!System.IO.File.Exists(tb_Upgrade_Path.Text + @"\app"))
            {
                MessageBox.Show("Not found app");
                return;
            }
            dt = DateTime.Now;
            timer1.Tick += new EventHandler(m_Upgrade_Check);
        }

        private void m_Upgrade_Check(object sender, EventArgs e)
        {
            if (!MCT8132PTable.Isstop)
            {
                timer1.Tick -= new EventHandler(m_Upgrade_Check);
                Upgrade.Start(tb_Upgrade_Path.Text, tb_Upgrade_boardNo.Text);
            }
            else if ((DateTime.Now - dt).TotalSeconds > 20)
            {
                timer1.Tick -= new EventHandler(m_Upgrade_Check);
                MessageBox.Show("AutoStart is Timeout!");
            }
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
                    sw.Write(SerialPort1.ReadBuffer);
                }
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            MouseInTextBox = true;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            MouseInTextBox = false;           
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btn_UpgradeDLL_Start_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(Directory.GetCurrentDirectory() + @"\Upgrade_DLL.dll"))
            {
                MessageBox.Show("Not found Upgrade_DLL");
                return;
            }
            if (!System.IO.File.Exists(Directory.GetCurrentDirectory() + @"\app"))
            {
                MessageBox.Show("Not found app");
                return;
            }
            Thread trd = new Thread(new ThreadStart(ThreadTaskStartUpgradeDLL));
            trd.Start();
        }

        private void btn_UpgradeDLL_AutoStart_Click(object sender, EventArgs e)
        {
            if (!SerialPort1.IsOpen)
            {
                MessageBox.Show("SerialPort is close!");
                return;
            }
            if (!System.IO.File.Exists(Directory.GetCurrentDirectory() + @"\Upgrade_DLL.dll"))
            {
                MessageBox.Show("Not found Upgrade_DLL");
                return;
            }
            if (!System.IO.File.Exists(Directory.GetCurrentDirectory() + @"\app"))
            {
                MessageBox.Show("Not found app");
                return;
            }
            dt = DateTime.Now;
            timer1.Tick += new EventHandler(m_UpgradeDLL_Check);
        }

        private void m_UpgradeDLL_Check(object sender, EventArgs e)
        {
            if (!MCT8132PTable.Isstop)
            {
                timer1.Tick -= new EventHandler(m_UpgradeDLL_Check);
                Thread trd = new Thread(new ThreadStart(ThreadTaskStartUpgradeDLL));
                trd.Start();
            }
            else if ((DateTime.Now - dt).TotalSeconds > 20)
            {
                timer1.Tick -= new EventHandler(m_UpgradeDLL_Check);
                MessageBox.Show("AutoStart(DLL) is Timeout!");
            }
        }

        private void ThreadTaskStartUpgradeDLL()
        {
            Upgrade_DLL.Start_DLL(Convert.ToInt32(tb_Upgrade_boardNo.Text));
        }
    }
}