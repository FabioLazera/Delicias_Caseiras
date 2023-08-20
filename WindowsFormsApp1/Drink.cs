using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class Drink : Order
    {
        private string _name;
        private string _description;
        private double _price;
        private int _stock;

        public Drink(string name, string description, double price, int stock, int id, string orderType, DateTime orderTime, DateTime readyForDelivery, string status)
        : base(id, orderType, orderTime, readyForDelivery, status)
        {
            _name = name;
            _description = description;
            _price = price;
            _stock = stock;

        }

        public Drink(string name, string description, double price, int stock)
        : base(0, null, DateTime.MinValue, DateTime.MinValue, null) 
        {
            _name = name;
            _description = description;
            _price = price;
            _stock = stock;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

    }
}
