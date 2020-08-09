namespace GTomato
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTomatos = new System.Windows.Forms.FlowLayoutPanel();
            this.panTop = new System.Windows.Forms.Panel();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnShowTomato = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTomatoCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "番茄工作法";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShow,
            this.tsmiExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiShow
            // 
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Size = new System.Drawing.Size(100, 22);
            this.tsmiShow.Text = "显示";
            this.tsmiShow.Click += new System.EventHandler(this.tsmiShow_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(100, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // lblTomatos
            // 
            this.lblTomatos.AutoScroll = true;
            this.lblTomatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTomatos.Location = new System.Drawing.Point(43, 74);
            this.lblTomatos.Name = "lblTomatos";
            this.lblTomatos.Size = new System.Drawing.Size(435, 166);
            this.lblTomatos.TabIndex = 4;
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.btnRest);
            this.panTop.Controls.Add(this.btnPause);
            this.panTop.Controls.Add(this.btnStart);
            this.panTop.Controls.Add(this.btnShowTomato);
            this.panTop.Controls.Add(this.lblTimer);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(519, 192);
            this.panTop.TabIndex = 5;
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRest.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRest.Location = new System.Drawing.Point(398, 146);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(80, 40);
            this.btnRest.TabIndex = 6;
            this.btnRest.Text = "休息";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Tan;
            this.btnPause.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPause.Location = new System.Drawing.Point(312, 146);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(80, 40);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Tomato;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(312, 47);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(166, 63);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnShowTomato
            // 
            this.btnShowTomato.Location = new System.Drawing.Point(43, 12);
            this.btnShowTomato.Name = "btnShowTomato";
            this.btnShowTomato.Size = new System.Drawing.Size(100, 23);
            this.btnShowTomato.TabIndex = 7;
            this.btnShowTomato.Text = "吃掉一个番茄";
            this.btnShowTomato.UseVisualStyleBackColor = true;
            this.btnShowTomato.Visible = false;
            this.btnShowTomato.Click += new System.EventHandler(this.btnShowTomato_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("微软雅黑", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(22, 47);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(295, 121);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "00:00";
            // 
            // lblTomatoCount
            // 
            this.lblTomatoCount.AutoSize = true;
            this.lblTomatoCount.Font = new System.Drawing.Font("方正舒体", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTomatoCount.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTomatoCount.Location = new System.Drawing.Point(132, 18);
            this.lblTomatoCount.Name = "lblTomatoCount";
            this.lblTomatoCount.Size = new System.Drawing.Size(239, 39);
            this.lblTomatoCount.TabIndex = 6;
            this.lblTomatoCount.Text = "今日番茄数量";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTomatoCount);
            this.panel1.Controls.Add(this.lblTomatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 267);
            this.panel1.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "番茄土豆";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnShowTomato;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel lblTomatos;
        private System.Windows.Forms.Label lblTomatoCount;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPause;
    }
}