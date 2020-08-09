using System;
using System.Windows.Forms;

namespace GTomato
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Config config = new Config
            {
                FocusTime = TimeSpan.FromMinutes(25),
                ShortBreakTime = TimeSpan.FromMinutes(5),
                LongBreakTime = TimeSpan.FromMinutes(15)
            };

            //Config config = new Config
            //{
            //    FocusTime = TimeSpan.FromSeconds(5),
            //    ShortBreakTime = TimeSpan.FromSeconds(5),
            //    LongBreakTime = TimeSpan.FromSeconds(15)
            //};

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain(config));
        }
    }
}
