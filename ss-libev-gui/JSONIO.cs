using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace ShadowsockslibevGUI
{
    [Serializable]
    class ServerInfo
    {
        public ServerInfo()
        {
            server_port = 1088;
            server = "example.com";
            password = "0";
            method = "aes-128-gcm";
            plugin_opts = "obfs=http;obfs-host=img.alicdn.com";

        }
        public string server
        {
            get;
            set;
        }
        public int server_port
        {
            get;
            set;
        }
        public int local_port
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }
        public string method
        {
            get;
            set;
        }
        public string plugin {
            get;
            set;
        }
        public string plugin_opts
        {
            get;
            set;
        }
    }
    class DStoCombobox
    {
        public string[] method=new string[6];
        public DStoCombobox()
        {
            method[0] = "aes-128-cfb";
            method[1] = "rc4-md5";
            method[2] = "chacha20";
            method[3] = "aes-128-ctr";
            method[4] = "aes-128-gcm";
            method[5] = "chacha20-ietf-poly1305";
        }
    }
    class JSONIO
    {
        public ServerInfo LoadFromFile()
        {
            ServerInfo serverFromFile = null;
            try
            {
                string configtxt = File.ReadAllText("config.json");
                serverFromFile= JsonConvert.DeserializeObject<ServerInfo>(configtxt);
                return serverFromFile;
            }catch (Exception e) { return null; }
        }
        public void SaveToFile(ServerInfo s)
        {
            string configstr = JsonConvert.SerializeObject(s);
            FileStream fs = null;
            try
            {
                fs = new FileStream("config.json", FileMode.Truncate, FileAccess.ReadWrite);
            }catch (Exception ex)
            {

            }
            finally { fs.Close(); };
            File.WriteAllText("config.json", configstr,Encoding.UTF8);
        }
        public void checkConfigExit()
        {
            FileStream fs = null;
            if (!File.Exists(Application.StartupPath + "config.json"))
            {
                try
                {
                    fs = new FileStream("config.json", FileMode.CreateNew, FileAccess.ReadWrite);
                }
                catch (Exception ex)
                {

                }
                finally { /*fs.Close(); */};
            }
        }
        public int AEAD_MethodNum(ServerInfo s,DStoCombobox ds)
        {
            if (s.method == null)
            {
                return 0;
            }
            else
            {
                int i = 0;
                for (i = 0; i < ds.method.Length; i++)
                {
                    if (s.method.Equals(ds.method[i]))
                    {
                        break;
                    }
                }
                return i;
            }
            
        }
        public int GetObfsNum(ServerInfo s)
        {
            string obfs_p = "";
            Regex rx0 = new Regex("obfs=http;*");
            Regex rx1 = new Regex("obfs=tls;*");
            if (rx0.IsMatch(s.plugin_opts)){
                return 0;
            }
            else if (rx1.IsMatch(s.plugin_opts))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public string GetPara(ServerInfo s)
        {
            int i = GetObfsNum(s);
            switch (i)
            {
                case 0:
                    return s.plugin_opts.Replace("obfs=http;obfs-host=", string.Empty);
                    break;
                case 1:
                    return s.plugin_opts.Replace("obfs=tls;obfs-host=", string.Empty);
                    break;
                default:
                    return "";
            }
        }
    }
}
