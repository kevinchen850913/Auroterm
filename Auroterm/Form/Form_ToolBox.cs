using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Auroterm
{
    public partial class Form_ToolBox : Form
    {
        DateTime dt;
        public Form_ToolBox()
        {
            InitializeComponent();
        }

        private void Form_ToolBox_Load(object sender, EventArgs e)
        {
            tb_Upgrade_Path.Text = Directory.GetCurrentDirectory();
        }

        private void btn_Upgrade_SetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_Upgrade_Path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_UpgradeDLL_Start_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(tb_Upgrade_Path.Text + @"\Upgrade_DLL.dll"))
            {
                MessageBox.Show("Not found Upgrade_DLL");
                return;
            }
            if (!System.IO.File.Exists(tb_Upgrade_Path.Text + @"\app"))
            {
                MessageBox.Show("Not found app");
                return;
            }
            Thread trd = new Thread(new ThreadStart(ThreadTaskStartUpgradeDLL));
            trd.Start();
            timer1.Tick += new EventHandler(m_UpgradeDLL_Check2);
        }

        private void btn_UpgradeDLL_AutoStart_Click(object sender, EventArgs e)
        {
            if (!Table_SerialPort.IsOpen)
            {
                MessageBox.Show("SerialPort is close!");
                return;
            }
            if (!System.IO.File.Exists(tb_Upgrade_Path.Text + @"\Upgrade_DLL.dll"))
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

        private void btn_Upgrade_Start_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(tb_Upgrade_Path.Text + @"\Upgrade.exe"))
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

        private void btn_Upgrade_AutoStart_Click(object sender, EventArgs e)
        {
            if (!Table_SerialPort.IsOpen)
            {
                MessageBox.Show("SerialPort is close!");
                return;
            }
            if (!System.IO.File.Exists(tb_Upgrade_Path.Text + @"\Upgrade.exe"))
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
            timer1.Enabled = false;
            if (!Table_MCT8132P.Isstop)
            {
                timer1.Tick -= new EventHandler(m_Upgrade_Check);
                Upgrade.Start(tb_Upgrade_Path.Text, tb_Upgrade_boardNo.Text);
            }
            else if ((DateTime.Now - dt).TotalSeconds > 20)
            {
                timer1.Tick -= new EventHandler(m_Upgrade_Check);
                MessageBox.Show("AutoStart is Timeout!");
            }
            timer1.Enabled = true;
        }

        private void m_UpgradeDLL_Check(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (!Table_MCT8132P.Isstop)
            {
                timer1.Tick -= new EventHandler(m_UpgradeDLL_Check);
                timer1.Tick += new EventHandler(m_UpgradeDLL_Check2);
                Thread trd = new Thread(new ThreadStart(ThreadTaskStartUpgradeDLL));
                trd.Start();
            }
            else if ((DateTime.Now - dt).TotalSeconds > 20)
            {
                timer1.Tick -= new EventHandler(m_UpgradeDLL_Check);
                MessageBox.Show("AutoStart(DLL) is Timeout!");
            }
            timer1.Enabled = true;
        }

        private void m_UpgradeDLL_Check2(object sender, EventArgs e)
        {
            if (Upgrade_DLL.CheckStart() < 1)
            {
                timer1.Tick -= new EventHandler(m_UpgradeDLL_Check2);
                if (Upgrade_DLL.CheckStart() == 0)
                {
                    MessageBox.Show("Upgrade is success!");
                }
                else
                {
                    MessageBox.Show("Upgrade is fail! " + Upgrade_DLL.CheckStart().ToString());
                }
            }
        }

        private void ThreadTaskStartUpgradeDLL()
        {
            Upgrade_DLL.Start_DLL(Convert.ToInt32(tb_Upgrade_boardNo.Text));
        }
    }
}