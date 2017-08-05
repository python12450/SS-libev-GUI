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
using System.Threading;

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

        public string server {
            get;
            set;
        }
        public int server_port {
            get;
            set;
        }
        public int local_port {
            get;
            set;
        }
        public string password {
            get;
            set;
        }
        public string method {
            get;
            set;
        }
        public string plugin {
            get;
            set;
        }
        public string plugin_opts {
            get;
            set;
        }
    }

    static class JSONIO
    {
        public static IReadOnlyList<string> method = new string[6] { "aes-128-cfb", "rc4-md5", "chacha20", "aes-128-ctr", "aes-128-gcm", "chacha20-ietf-poly1305" };
        private static ThreadLocal<Regex> rx0 = new ThreadLocal<Regex>(() => new Regex("obfs=http;.*", RegexOptions.Compiled));
        private static ThreadLocal<Regex> rx1 = new ThreadLocal<Regex>(() => new Regex("obfs=tls;.*", RegexOptions.Compiled));

        public static ServerInfo LoadFromFile()
        {
            ServerInfo serverFromFile = null;
            try {
                var configtxt = File.ReadAllText("config.json");
                serverFromFile = JsonConvert.DeserializeObject<ServerInfo>(configtxt);
                return serverFromFile;
            } catch(Exception) { return null; }
        }

        public static void SaveToFile(ServerInfo s)
        {
            var configstr = JsonConvert.SerializeObject(s);
            File.WriteAllText("config.json", configstr, Encoding.UTF8);
        }

        public static void checkConfigExit()
        {
            if(!File.Exists(Application.StartupPath + "config.json")) {
                File.WriteAllText("config.json", "", Encoding.UTF8);
            }
        }

        public static int AEAD_MethodNum(ServerInfo s)
        {
            if(s.method == null) {
                return 0;
            } else {
                for(var i = 0; i < method.Count; i++) {
                    if(s.method == method[i]) {
                        return i;
                    }
                }
                return 0;
            }
        }

        public static int GetObfsNum(ServerInfo s)
        {
            if(rx0.Value.IsMatch(s.plugin_opts)) {
                return 0;
            } else if(rx1.Value.IsMatch(s.plugin_opts)) {
                return 1;
            } else {
                return -1;
            }
        }

        public static string GetPara(ServerInfo s)
        {
            switch(GetObfsNum(s)) {
                case 0:
                    return s.plugin_opts.Replace("obfs=http;obfs-host=", string.Empty);
                case 1:
                    return s.plugin_opts.Replace("obfs=tls;obfs-host=", string.Empty);
                default:
                    return "";
            }
        }
    }
}
