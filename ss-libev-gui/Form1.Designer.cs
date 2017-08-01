namespace ShadowsockslibevGUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartClient = new System.Windows.Forms.Button();
            this.StopClient = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.加密方式 = new System.Windows.Forms.Label();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.portpick = new System.Windows.Forms.NumericUpDown();
            this.IP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.obfs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.para = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portpick)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartClient
            // 
            this.StartClient.Location = new System.Drawing.Point(374, 260);
            this.StartClient.Name = "StartClient";
            this.StartClient.Size = new System.Drawing.Size(75, 23);
            this.StartClient.TabIndex = 1;
            this.StartClient.Text = "启动客户端";
            this.StartClient.UseVisualStyleBackColor = true;
            this.StartClient.Click += new System.EventHandler(this.StartClient_Click);
            // 
            // StopClient
            // 
            this.StopClient.Location = new System.Drawing.Point(486, 259);
            this.StopClient.Name = "StopClient";
            this.StopClient.Size = new System.Drawing.Size(75, 23);
            this.StopClient.TabIndex = 2;
            this.StopClient.Text = "关闭客户端";
            this.StopClient.UseVisualStyleBackColor = true;
            this.StopClient.Click += new System.EventHandler(this.StopClient_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.34471F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.65529F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.加密方式, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.methodBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.portpick, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.IP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.obfs, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pwd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.para, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 240);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器地址";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口";
            // 
            // 加密方式
            // 
            this.加密方式.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.加密方式.AutoSize = true;
            this.加密方式.Location = new System.Drawing.Point(37, 88);
            this.加密方式.Name = "加密方式";
            this.加密方式.Size = new System.Drawing.Size(53, 12);
            this.加密方式.TabIndex = 3;
            this.加密方式.Text = "加密方式";
            // 
            // methodBox
            // 
            this.methodBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Location = new System.Drawing.Point(130, 84);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(160, 20);
            this.methodBox.TabIndex = 4;
            // 
            // portpick
            // 
            this.portpick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.portpick.Location = new System.Drawing.Point(130, 30);
            this.portpick.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portpick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portpick.Name = "portpick";
            this.portpick.Size = new System.Drawing.Size(160, 21);
            this.portpick.TabIndex = 5;
            this.portpick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IP
            // 
            this.IP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IP.Location = new System.Drawing.Point(130, 3);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(160, 21);
            this.IP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "混淆方式";
            // 
            // obfs
            // 
            this.obfs.FormattingEnabled = true;
            this.obfs.Items.AddRange(new object[] {
            "http",
            "tls"});
            this.obfs.Location = new System.Drawing.Point(130, 110);
            this.obfs.Name = "obfs";
            this.obfs.Size = new System.Drawing.Size(160, 20);
            this.obfs.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "密码";
            // 
            // pwd
            // 
            this.pwd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pwd.Location = new System.Drawing.Point(130, 57);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(160, 21);
            this.pwd.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "混淆参数";
            // 
            // para
            // 
            this.para.Location = new System.Drawing.Point(130, 136);
            this.para.Name = "para";
            this.para.Size = new System.Drawing.Size(160, 21);
            this.para.TabIndex = 12;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(374, 220);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 4;
            this.save.Text = "保存设置";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主界面ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // 主界面ToolStripMenuItem
            // 
            this.主界面ToolStripMenuItem.Name = "主界面ToolStripMenuItem";
            this.主界面ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.主界面ToolStripMenuItem.Text = "主界面 ";
            this.主界面ToolStripMenuItem.Click += new System.EventHandler(this.主界面ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "SS-libev正在运行";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 306);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.StopClient);
            this.Controls.Add(this.StartClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "影梭libev-GUI（obfs）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portpick)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartClient;
        private System.Windows.Forms.Button StopClient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 加密方式;
        private System.Windows.Forms.ComboBox methodBox;
        private System.Windows.Forms.NumericUpDown portpick;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox obfs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox para;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

