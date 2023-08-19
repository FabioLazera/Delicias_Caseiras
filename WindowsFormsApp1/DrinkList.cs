using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WindowsFormsApp1
{
    public class DrinkList
    {
        private static List<Drink> drinks = new List<Drink>();

        public static void AddDrink(Drink drink)
        {

            drinks.Add(drink);
        }

        public static List<Drink> GetDrinks()
        {
            return drinks;
        }

        public static void EditDrink(int index, Drink newDrinkData)
        {
            if (index >= 0 && index < drinks.Count)
            {
                drinks[index] = newDrinkData;
            }
        }

        public static void DeleteDrink(int index)
        {
            if (index >= 0 && index < drinks.Count)
            {
                drinks.RemoveAt(index);
            }
        }

        public static void SaveToCSV(string fileName)
        {
            string folderPath = Path.Combine(Program.ProjectDirectory, "csvFiles");
            string fullPath = Path.Combine(folderPath, fileName);
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (Drink drink in drinks)
                {
                    writer.WriteLine($"{drink.Name},{drink.Description},{drink.Price},{drink.Stock}");
                }
            }
        }

        public static void LoadFromCSV(string fileName)
        {
            string folderPath = Path.Combine(Program.ProjectDirectory, "csvFiles");
            string fullPath = Path.Combine(folderPath, fileName);

            if (File.Exists(fullPath))
            {
                using (StreamReader reader = new StreamReader(fullPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            string name = parts[0];
                            string description = parts[1];
                            double price = Convert.ToDouble(parts[2], CultureInfo.InvariantCulture);
                            int stock = Convert.ToInt32(parts[3]);
                            Drink newDrink = new Drink(name, description, price, stock);
                            drinks.Add(newDrink);
                        }
                    }
                }
            }
        }
    }
}
