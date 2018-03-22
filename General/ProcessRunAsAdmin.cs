using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class ProcessRunAsAdmin
    {
        public static void Run()
        {
            //System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\cmd.exe");
            System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo(@"C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe");
            proc.UseShellExecute = true;
            proc.Verb = "runas";
            Process.Start(proc);
        }
    }
}
