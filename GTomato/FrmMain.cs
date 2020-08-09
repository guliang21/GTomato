using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTomato
{
    public partial class FrmMain : Form
    {
        readonly Config config;

        public FrmMain(Config config)
        {
            InitializeComponent();

            this.config = config;
        }

        TimeSpan countdown;
        TimeSpan second = TimeSpan.FromSeconds(1);

        // 获得的总番茄数
        int tomatoCount = 0;
        // 长时间休息所需的番茄数，每次长休息后归零
        int longBreakNeedTomato = 0;

        bool pause = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            countdown = config.FocusTime;
            showCountdown();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pause = false;
            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            pause = true;
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            longBreakNeedTomato = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pause) return;

            countdown -= second;
            showCountdown();

            if (countdown == TimeSpan.Zero)
            {
                timer1.Stop();

                tomatoCount++;
                showTomatoPicture();
                lblTomatoCount.Text = $"今日番茄数量 {tomatoCount}";

                FrmBreakTime frmBreakTime = new FrmBreakTime(GetBreakTime());
                frmBreakTime.TopMost = true;
                frmBreakTime.Focus();

                if (frmBreakTime.ShowDialog() == DialogResult.OK)
                {
                    WindowState = FormWindowState.Normal;
                    TopMost = true;
                }

                notifyIcon1.Text = "番茄工作法";
                countdown = config.FocusTime;
                showCountdown();
            }
        }

        private TimeSpan GetBreakTime()
        {
            longBreakNeedTomato++;

            if (tomatoCount <= 8)
            {
                // 8 个番茄以内，每 4 个番茄一次长时间休息
                return GetBreakTime(4);
            }
            else
            {
                // 超过 8 个番茄，每 3 个番茄一次长时间休息
                return GetBreakTime(3);
            }
        }

        private TimeSpan GetBreakTime(int criticalValue)
        {
            if (longBreakNeedTomato == criticalValue)
            {
                longBreakNeedTomato = 0;
                return config.LongBreakTime;
            }
            else
            {
                return config.ShortBreakTime;
            }
        }

        private void showCountdown()
        {
            lblTimer.Text = countdown.ToString(@"mm\:ss");
            notifyIcon1.Text = countdown.ToString(@"mm\:ss");

            //notifyIcon1.ShowBalloonTip(1000, "专注时间", countdown.ToString(@"mm\:ss"), ToolTipIcon.Info);
        }

        private void showTomatoPicture()
        {
            PictureBox pb = new PictureBox();
            pb.Size = new Size(48, 48);
            pb.Image = Properties.Resources.tomato;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTomatos.Controls.Add(pb);
        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                TopMost = false;

                ShowInTaskbar = false;

                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowForm();
        }

        private void tsmiShow_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ShowForm()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = true;

                notifyIcon1.Visible = false;

                WindowState = FormWindowState.Normal;

                this.Activate();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            WindowState = FormWindowState.Minimized;

            e.Cancel = true;
        }

        private void btnShowTomato_Click(object sender, EventArgs e)
        {
            showTomatoPicture();
        }

        
    }
}
