using System;
using System.Collections.Generic;
using System.Text;

namespace Auroterm
{
    static class MCT8132PTable
    {
        public static string EtherCATMaster = "unknown";
        public static string boardname;
        public static string version;
        public static string MAC;
        public static bool linkcable;

        public static bool Isstop = true;

        public static double JOB_ProcessAllRxFrames;
        public static double JOB_SendAllCycFrames;
        public static double JOB_MasterTimer;
        public static double JOB_SendAcycFrames;
        public static double JOB_CycleTime;
        public static double myAppWorkPd;
        public static double WriteDCMlogfile;

        public static double MCU;
        public static double APP;
        public static double EtherCAT;

        private static string[] LineBuffer ;
        public static void update(string Line)
        {
            LineBuffer = Line.Trim('\r').Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Check();
        }

        private static void Check()
        {
            if (LineBuffer.Length < 1)
            {
                return;
            }
            int n = 0;
            if (LineBuffer[0].Length > 10 && int.TryParse(LineBuffer[0].Substring(0, 10), out n))
            {
                //0000000000:
                Isstop = false;
                if (LineBuffer[1] == "EcMasterDemoMotion")
                {
                    //0000000000: EcMasterDemoMotion stop.
                    Isstop = true;
                }
                else if (LineBuffer[1] == "PerfMsmt")
                {
                    //0000000532: PerfMsmt 'JOB_ProcessAllRxFrames' (min/avg/max) [usec]:    0.3/   6.9/  12.2
                    switch (LineBuffer[2])
                    {
                        case "\'JOB_ProcessAllRxFrames\'":

                            JOB_ProcessAllRxFrames = double.Parse(LineBuffer[6].Substring(0, LineBuffer[6].Length - 1));
                            break;
                        case "\'JOB_SendAllCycFrames":
                            JOB_SendAllCycFrames = double.Parse(LineBuffer[7].Substring(0, LineBuffer[7].Length-1));
                            break;
                        case "\'JOB_MasterTimer":
                            JOB_MasterTimer = double.Parse(LineBuffer[7].Substring(0, LineBuffer[7].Length-1));
                            break;
                        case "\'JOB_SendAcycFrames":
                            JOB_SendAcycFrames = double.Parse(LineBuffer[7].Substring(0, LineBuffer[7].Length-1));
                            break;
                        case "\'Cycle":
                            JOB_CycleTime = double.Parse(LineBuffer[8].Substring(0, LineBuffer[8].Length - 1).Split('/')[0]);
                            break;
                        case "\'myAppWorkPd":
                            myAppWorkPd = double.Parse(LineBuffer[7].Substring(0, LineBuffer[7].Length-1));
                            break;
                        case "\'Write":
                            WriteDCMlogfile = double.Parse(LineBuffer[9].Substring(0, LineBuffer[9].Length-1));

                            APP = Math.Round((myAppWorkPd + WriteDCMlogfile) / JOB_CycleTime * 100, 2);
                            EtherCAT = Math.Round((JOB_ProcessAllRxFrames + JOB_SendAllCycFrames + JOB_MasterTimer + JOB_SendAcycFrames) / JOB_CycleTime * 100, 2);
                            MCU = APP + EtherCAT;
                            break;
                    }    
                }
                else if (LineBuffer[1] == "EtherCAT")
                {
                    //0000006494: EtherCAT network adapter MAC: 30-45-11-D8-1C-E7
                    MAC = LineBuffer[5];
                }
                else if (LineBuffer[1] == "Cannot")
                {
                    //0000006582: Cannot scan bus: ERROR: Ethernet link cable disconnected (0x9811002d)
                    linkcable = false;
                }
                else if (LineBuffer[2] == "EtherCAT")
                {
                    //0000006582: Shutdown EtherCAT Master
                    EtherCATMaster = LineBuffer[1];
                }
            }
            else
            {
                Isstop = true;
                if (LineBuffer[0] == "Aurotek")
                {
                    //Aurotek Corp. MCN8532P Boot Loader
                    EtherCATMaster = "Boot";
                    return;
                }
                else if (LineBuffer[0] == "boardname:")
                {
                    //boardname: ?????? version: ???
                    boardname = LineBuffer[1];
                    version = LineBuffer[3];
                    return;
                }
            }
            
            return;
        }
    }
}
