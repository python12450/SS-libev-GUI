using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowsockslibevGUI
{
    class ServiceCTL
    {
        System.Diagnostics.Process p = new System.Diagnostics.Process();
        System.Diagnostics.Process kill = new System.Diagnostics.Process();
        public void StartService()
        {
            p.StartInfo.FileName = "ss-local.exe";
            p.StartInfo.Arguments = "-c config.json -u";
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            p.Start();
        }
        public void StopService()
        {
            kill.StartInfo.FileName = "cmd.exe";
            kill.StartInfo.UseShellExecute = false;
            kill.StartInfo.RedirectStandardInput = true;
            kill.StartInfo.RedirectStandardOutput = true;
            kill.StartInfo.RedirectStandardError = true;
            kill.StartInfo.CreateNoWindow = true;
            kill.Start();
            kill.StandardInput.WriteLine("taskkill /F /IM obfs-local.exe" + "&exit");
        }
        public void ReloadService()
        {
            StopService();
            System.Threading.Thread.Sleep(200);
            StartService();
        }
    }
}
