﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DishList
    {
        public static List<Dish> dishes = new List<Dish>();

        public static void AddDish(Dish dish)
        {

            dishes.Add(dish);
        }

        public static List<Dish> GetDish()
        {
            return dishes;
        }

        public static void EditDish(int index, Dish newDishData)
        {
            if (index >= 0 && index < dishes.Count)
            {
                dishes[index] = newDishData;
            }
        }

        public static void DeleteDish(int index)
        {
            if (index >= 0 && index < dishes.Count)
            {
                dishes.RemoveAt(index);
            }
        }

        public static void SaveToCSV(string fileName)
        {
            string folderPath = Path.Combine(Program.ProjectDirectory, "csvFiles");
            string fullPath = Path.Combine(folderPath, fileName);
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (Dish dish in dishes)
                {
                    writer.WriteLine($"{dish.Name},{dish.Description},{dish.Price},{dish.Stock}");
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
                        string[] parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            string name = parts[0];
                            string description = parts[1];
                            double price = Convert.ToDouble(parts[2], CultureInfo.InvariantCulture);
                            int stock = Convert.ToInt32(parts[3]);
                            Dish newDish = new Dish(name, description, price, stock);
                            dishes.Add(newDish);
                        }
                    }
                }
            }
        }
    }
}