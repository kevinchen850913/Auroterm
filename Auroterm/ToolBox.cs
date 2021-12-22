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

            /* 將命令提示字元cmd.exe程式啟動並執行 */
            Process console = Process.Start(cmd);

            /* 在命令提示自元cmd.exe輸入啟動XmlUpload命令 */
            console.StandardInput.WriteLine(@"cd /d " + Path);
            console.StandardInput.WriteLine(@"Upgrade " + BoardNo);

            /* 關閉命令提示字元 */
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
