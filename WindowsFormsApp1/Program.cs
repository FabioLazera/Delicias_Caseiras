using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Panels;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        public static string ProjectDirectory => AppDomain.CurrentDomain.BaseDirectory;

        private const string CsvFolderPath =  "csvFiles";
        public const string ImageFolderPath = "imageFiles";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CheckCsvFolder();
            CheckImagesFolder();
            Application.Run(new loginPanel());
            EmployeeList.LoadEmployeeIfNeeded();
            ClientList.LoadClientsIfNeeded();
            DishList.LoadDishesIfNeeded();
            DrinkList.LoadDrinksIfNeeded();
            Restaurant.LoadOrderIfIsNeeded();
        }

        private static void CheckCsvFolder()
        {
            string csvFolderPath = Path.Combine(ProjectDirectory, CsvFolderPath);

            if (!Directory.Exists(csvFolderPath))
            {
                Directory.CreateDirectory(csvFolderPath);
            }
        }

        private static void CheckImagesFolder()
        {
            string imageFolderPath = Path.Combine(ProjectDirectory, ImageFolderPath);

            if (!Directory.Exists(imageFolderPath))
            {
                Directory.CreateDirectory(imageFolderPath);
            }
        }

    }
}
