using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Auroterm
{
    static class Upgrade
    {
        public static void Start(string Path, string BoardNo)
        {
            ProcessStartInfo cmd = new System.Diagnostics.ProcessStartInfo("cmd.exe");

            cmd.RedirectStandardInput = true;
            cmd.RedirectStandardOutput = true;
            cmd.RedirectStandardError = true;
            cmd.UseShellExecute = false;

            /* �N�R�O���ܦr��cmd.exe�{���Ұʨð��� */
            Process console = Process.Start(cmd);

            /* �b�R�O���ܦۤ�cmd.exe��J�Ұ�XmlUpload�R�O */
            console.StandardInput.WriteLine(@"cd /d " + Path);
            console.StandardInput.WriteLine(@"Upgrade " + BoardNo);

            /* �����R�O���ܦr�� */
            console.StandardInput.WriteLine("exit");
            console.Close();
        }
    }

    static class Upgrade_DLL
    {
        private static int StartErr = 1;
    [DllImport("Upgrade_DLL.dll")]
        private static extern int Start(int BoardNo);

        public static void Start_DLL(int BoardNo)
        {
            StartErr = 1;
            StartErr = Start(BoardNo);
        }

        public static int CheckStart()
        {
            return StartErr;
        }
    }
}
