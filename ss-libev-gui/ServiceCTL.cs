using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowsockslibevGUI
{
    static class ServiceCTL
    {
        public static void StartService()
        {
            using(var p = new Process()) {
                p.StartInfo.FileName = "ss-local.exe";
                p.StartInfo.Arguments = "-c config.json -u";
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.Start();
            }
        }

        public static void StopService()
        {
            using(var kill = new Process()) {
                kill.StartInfo.FileName = "taskkill.exe";
                kill.StartInfo.UseShellExecute = false;
                kill.StartInfo.RedirectStandardInput = true;
                kill.StartInfo.RedirectStandardOutput = true;
                kill.StartInfo.RedirectStandardError = true;
                kill.StartInfo.CreateNoWindow = true;
                kill.StartInfo.Arguments = "/F /IM obfs-local.exe";
                kill.Start();
            }
        }

        public static void ReloadService()
        {
            StopService();
            System.Threading.Thread.Sleep(200);
            StartService();
        }
    }
}
