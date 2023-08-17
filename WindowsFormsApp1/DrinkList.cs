using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
