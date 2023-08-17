using System;
using System.Collections.Generic;
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

        public static List<Dish> GetDishes()
        {
            return dishes;
        }

        public static void EditDishes(int index, Dish newDishData)
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
    }
}
