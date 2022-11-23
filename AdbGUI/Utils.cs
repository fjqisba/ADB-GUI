using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdbGUI
{
    internal class Utils
    {
        static public string ExecuteCmd(string fileName,string argument)
        {
            Process cli = new Process();
            cli.StartInfo = new ProcessStartInfo()
            {
                FileName = fileName,
                Arguments = argument,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
            };
            cli.Start();
            string result = cli.StandardOutput.ReadToEnd();
            cli.WaitForExit();
            return result;
        }

        static public void CreateCmd(string fileName, string argument)
        {
            Process cli = new Process();
            cli.StartInfo = new ProcessStartInfo()
            {
                FileName = fileName,
                Arguments = argument,
                UseShellExecute = true,
                CreateNoWindow = false,
                RedirectStandardOutput = false,
                RedirectStandardError = false,
                RedirectStandardInput = false,
            };
            cli.Start();
            return;
        }
    }
}
