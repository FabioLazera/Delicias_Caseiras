using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        public string ProductNameLabel
        {
            get { return productName.Text; }
            set { productName.Text = value; }
        }

        public double ProductPriceLabel
        {
            get { return Convert.ToDouble(productPrice.Text); }
            set { productPrice.Text = $"{value:F2} €"; }
        }

        public string ProductDescriptionTB
        {
            get { return productDescription.Text; }
            set { productDescription.Text = value; }
        }
    }
}
