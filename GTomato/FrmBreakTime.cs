using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTomato
{
    public partial class FrmBreakTime : Form
    {
        public FrmBreakTime(TimeSpan breakTime)
        {
            InitializeComponent();

            this.breakTime = breakTime;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Size differenceSize = lblTimer.Parent.Size - lblTimer.Size;

            lblTimer.Location = new Point(differenceSize.Width / 2, differenceSize.Height / 2);
        }

        TimeSpan breakTime;
        TimeSpan countdown;
        TimeSpan second = TimeSpan.FromSeconds(1);

        private void Form1_Load(object sender, EventArgs e)
        {
            countdown = breakTime;
            showCountdown();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown -= second;
            showCountdown();

            if (countdown == TimeSpan.Zero)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void showCountdown()
        {
            lblTimer.Text = countdown.ToString(@"mm\:ss");
        }
    }
}
