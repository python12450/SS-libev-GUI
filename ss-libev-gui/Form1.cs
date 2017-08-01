using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowsockslibevGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Diagnostics.Process p = new System.Diagnostics.Process();
        ServiceCTL serviceController = new ServiceCTL();
        DStoCombobox ds = new DStoCombobox();
        private void Form1_Load(object sender, EventArgs e)
        {
            JSONIO jsontool = new JSONIO();
            ServerInfo server = null;
            jsontool.checkConfigExit();
            server=jsontool.LoadFromFile();
            if (server == null)
            {
                server = new ServerInfo();
            }
            StopClient.Enabled = false;
            for (int i = 0; i < ds.method.Length; i++)
            {
                methodBox.Items.Insert(i, ds.method[i]);
            }
            methodBox.SelectedIndex = jsontool.AEAD_MethodNum(server,ds);
            methodBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IP.Text = server.server;
            portpick.Value = server.server_port;
            obfs.SelectedIndex = jsontool.GetObfsNum(server);
            obfs.DropDownStyle = ComboBoxStyle.DropDownList;
            pwd.Text = server.password;
            para.Text = jsontool.GetPara(server);
        }

        private void StartClient_Click(object sender, EventArgs e)
        {
            serviceController.StartService();
            StopClient.Enabled = true;
            StartClient.Enabled = false;
        }

        private void StopClient_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process kill = new System.Diagnostics.Process();
            serviceController.StopService();
            StopClient.Enabled = false;
            StartClient.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                notifyIcon1.BalloonTipTitle = "后台运行";
                notifyIcon1.BalloonTipText = "端口1080";
                notifyIcon1.ShowBalloonTip(2000);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            ServerInfo dist_s = new ServerInfo();
            dist_s.password = pwd.Text;
            dist_s.local_port = 1080;
            dist_s.server_port = (int)portpick.Value;
            dist_s.server = IP.Text;
            dist_s.method = methodBox.Text;
            dist_s.plugin = "obfs-local";
            string obfs_par = para.Text;
            if (para.Text.Equals("")){
                obfs_par= "download.microsoft,com";
            }
            string obfs_opt = "obfs=" + obfs.Text + ";" + "obfs-host="+obfs_par;
            dist_s.plugin_opts = obfs_opt;
            JSONIO jsio = new JSONIO();
            jsio.SaveToFile(dist_s);
            if (StopClient.Enabled)
            {
                serviceController.ReloadService();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.notifyIcon1.Visible = true;
            }
        }

        private void 主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Visible = true;
            notifyIcon1.Visible = false;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serviceController.StopService();
            System.Threading.Thread.Sleep(500);
            System.Environment.Exit(1);
        }
    }
}
