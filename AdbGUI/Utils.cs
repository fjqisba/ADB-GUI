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
        private static readonly int defaultCodePage = CultureInfo.CurrentCulture.TextInfo.OEMCodePage;

        static public string RunCmd(string command)
        {
            Process cli = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "cmd",
                Arguments = "/K prompt $g ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                StandardOutputEncoding = Encoding.GetEncoding(defaultCodePage),
                StandardErrorEncoding = Encoding.GetEncoding(defaultCodePage)
            };

            cli.EnableRaisingEvents = true;
            cli.StartInfo = startInfo;
            cli.Start();

            

            return cli.StandardOutput.ReadToEnd();
        }
    }
}
