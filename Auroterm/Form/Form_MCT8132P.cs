using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Auroterm
{
    public partial class Form_MCT8132P : Form
    {
        mySystem mySys;
        public Form_MCT8132P(mySystem m_mySys)
        {
            InitializeComponent();
            mySys = m_mySys;
        }

        private void Form_Table_MCT8132P_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_EtherCATMaster.Text = Table_MCT8132P.EtherCATMaster;
            tb_Isstop.Text = Table_MCT8132P.Isstop.ToString();
            tb_JOB_ProcessAllRxFrames.Text = Table_MCT8132P.JOB_ProcessAllRxFrames.ToString();
            tb_JOB_SendAllCycFrames.Text = Table_MCT8132P.JOB_SendAllCycFrames.ToString();
            tb_JOB_MasterTimer.Text = Table_MCT8132P.JOB_MasterTimer.ToString();
            tb_JOB_SendAcycFrames.Text = Table_MCT8132P.JOB_SendAcycFrames.ToString();
            tb_JOB_CycleTime.Text = Table_MCT8132P.JOB_CycleTime.ToString();
            tb_myAppWorkPd.Text = Table_MCT8132P.myAppWorkPd.ToString();
            tb_WriteDCMlogfile.Text = Table_MCT8132P.WriteDCMlogfile.ToString();
            tb_PerfMsmt_MCU.Text = Table_MCT8132P.MCU.ToString();
            tb_PerfMsmt_APP.Text = Table_MCT8132P.APP.ToString();
            tb_PerfMsmt_EtherCAT.Text = Table_MCT8132P.EtherCAT.ToString();
        }
    }
}