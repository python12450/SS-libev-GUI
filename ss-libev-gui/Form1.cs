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

        private void Form1_Load(object sender, EventArgs e)
        {
            JSONIO.checkConfigExit();
            var server = JSONIO.LoadFromFile() ?? new ServerInfo();
            StopClient.Enabled = false;
            for(int i = 0; i < DStoCombobox.method.Count; i++) {
                methodBox.Items.Insert(i, DStoCombobox.method[i]);
            }
            methodBox.SelectedIndex = JSONIO.AEAD_MethodNum(server);
            methodBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IP.Text = server.server;
            portpick.Value = server.server_port;
            obfs.SelectedIndex = JSONIO.GetObfsNum(server);
            obfs.DropDownStyle = ComboBoxStyle.DropDownList;
            pwd.Text = server.password;
            para.Text = JSONIO.GetPara(server);
        }

        private void StartClient_Click(object sender, EventArgs e)
        {
            ServiceCTL.StartService();
            StopClient.Enabled = true;
            StartClient.Enabled = false;
        }

        private void StopClient_Click(object sender, EventArgs e)
        {
            ServiceCTL.StopService();
            StopClient.Enabled = false;
            StartClient.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                this.Hide();
                notifyIcon1.BalloonTipTitle = "后台运行";
                notifyIcon1.BalloonTipText = "端口1080";
                notifyIcon1.ShowBalloonTip(2000);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            var obfs_par = para.Text;
            if(obfs_par.Equals("")) {
                obfs_par = "download.microsoft,com";
            }
            var obfs_opt = "obfs=" + obfs.Text + ";" + "obfs-host=" + obfs_par;

            JSONIO.SaveToFile(new ServerInfo {
                password = pwd.Text,
                local_port = 1080,
                server_port = (int)portpick.Value,
                server = IP.Text,
                method = methodBox.Text,
                plugin = "obfs-local",
                plugin_opts = obfs_opt
            });

            if(StopClient.Enabled) {
                ServiceCTL.ReloadService();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized) {
                this.Visible = false;
            }
        }

        private void 主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Visible = true;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceCTL.StopService();
            System.Threading.Thread.Sleep(500);
            System.Environment.Exit(1);
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            notifyIcon1.Visible = !this.Visible;
        }
    }
}
