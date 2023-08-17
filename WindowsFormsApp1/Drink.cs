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
        private string _imagePath;

        public Drink(string name, string description, double price, int stock, string imagePath) 
        {
            _name = name;
            _description = description;
            _price = price;
            _stock = stock;
            _imagePath = imagePath;
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

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }

        
        public Image GetImage()
        {
            if (!string.IsNullOrEmpty(_imagePath))
            {
                return Image.FromFile(_imagePath);
            }
            return null;
        }
    }
}
