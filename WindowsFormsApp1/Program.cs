using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Panels;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        public static string ProjectDirectory => AppDomain.CurrentDomain.BaseDirectory;

        private const string CsvFolderPath = "csvFiles";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CheckCsvFolder();
            Application.Run(new Menu());
        }

        private static void CheckCsvFolder()
        {
            string csvFolderPath = Path.Combine(ProjectDirectory, CsvFolderPath);

            if (!Directory.Exists(csvFolderPath))
            {
                Directory.CreateDirectory(csvFolderPath);
            }
        }

    }
    public static class TimeUtility
    {
        private static DateTime _currentTime = DateTime.Now;
        private static Timer _timer;



        public static DateTime CurrentTime
        {
            get { return _currentTime; }
            set { _currentTime = value; }
        }

        public static string StrCurrentTime
        {
            get { return _currentTime.ToString("dd/MM/yyyy HH:mm:ss"); }
        }

        public static void AddSeconds(int seconds)
        {
            _currentTime = _currentTime.AddSeconds(seconds);
        }

        static TimeUtility()
        {
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            _currentTime = _currentTime.AddSeconds(1);
        }
    }
}
