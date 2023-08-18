using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class Drink
    {
        private string _name;
        private string _description;
        private double _price;
        private int _stock;
        private Image _image;

        public Drink(string name, string description, double price, int stock, Image image)
        {
            _name = name;
            _description = description;
            _price = price;
            _stock = stock;
            _image = image;
        }

        public Drink(string name, string description, double price, int stock)
        {
            _name = name;
            _description = description;
            _price = price;
            _stock = stock;
            _image = null;
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

        public Image Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
