using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class ProcessReadFromConsoleOutput
    {
        public static string Read()
        {
            string cmd = @"xcopy C:\abc\1\1.txt C:\abc\2\";

            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + cmd)
            {
                UseShellExecute = false,
                CreateNoWindow = false,
                WindowStyle = ProcessWindowStyle.Maximized
            };

            using (Process proc = new Process())
            {
                proc.StartInfo = procStartInfo;
                proc.Start();

                string output = proc.StandardOutput.ReadToEnd();

                if (string.IsNullOrEmpty(output))
                    output = proc.StandardError.ReadToEnd();

                return output;
            }
        }
    }
}