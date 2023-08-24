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
            EmployeeList.LoadEmployeeIfNeeded();
            ClientList.LoadClientsIfNeeded();
            DishList.LoadDishesIfNeeded();
            DrinkList.LoadDrinksIfNeeded();
            OrderList.LoadOrderIfIsNeeded();
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
}
