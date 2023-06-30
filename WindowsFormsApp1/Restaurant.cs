using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Restaurant
    {
        public List<Order> Orders { get; set; }

        public Restaurant() {
            Orders = new List<Order>(); //Sempre que se cria um restaurante ,ele adiciona uma order
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        //Sempre que se cria um restaurante ele adiciona uma order a lista de orders

        public void RemoveOrder(Order order)
        {
            Orders.Remove(order);
        }
    }
}
