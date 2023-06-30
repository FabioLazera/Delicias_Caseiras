using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Drink : Order
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Drink(string status, string name, string description, double price) : base(status)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
