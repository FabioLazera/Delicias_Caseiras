﻿using System;
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
        public static List<Drink> drinks = new List<Drink>();

        public static void AddDrink(Drink drink)
        {

            drinks.Add(drink);
        }

        public static List<Drink> GetDrinks()
        {
            return drinks;
        }

        // Method to edit drink data at a specific index.
        public static void EditDrink(int index, Drink newDrinkData)
        {
            if (index >= 0 && index < drinks.Count)
            {
                drinks[index] = newDrinkData;
            }
        }

        // Method to delete a drink at a specific index.
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
                    // Format the price with the invariant culture to ensure consistent decimal representation.
                    string formattedPrice = string.Format(CultureInfo.InvariantCulture, "{0:0.00}", drink.Price);
                    // Write drink data to the CSV file in a specific format.
                    writer.WriteLine($"{drink.Name};{drink.Description};{formattedPrice};{drink.Stock};{drink.ImagePath}");
                }
            }
        }

        public static void LoadFromCSV(string fileName)
        {
            string fullPath = Path.Combine(Program.ProjectDirectory, "csvFiles", fileName);

            if (File.Exists(fullPath))
            {
                using (StreamReader reader = new StreamReader(fullPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length == 5)
                        {
                            // Parse drink data from the CSV line.
                            string name = parts[0];
                            string description = parts[1];
                            string priceStr = parts[2].Replace(',', '.');// Replace comma with dot for consistent decimal parsing.
                            double price = Convert.ToDouble(priceStr, CultureInfo.InvariantCulture);
                            int stock = Convert.ToInt32(parts[3]);
                            string imagePath = parts[4];
                            // Create a new Drink object and add it to the list.
                            Drink newDrink = new Drink(name, description, price, stock, imagePath);
                            drinks.Add(newDrink);
                        }
                    }
                }
            }
        }

        public static void LoadDrinksIfNeeded()
        {
            if (drinks.Count == 0)
            {
                LoadFromCSV("drinks.csv");
            }
        }
    }
}
