﻿using System;
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
            productName.Click +=        Component_Click;
            price.Click +=              Component_Click;
            productPrice.Click +=       Component_Click;
            productDescription.Click += Component_Click;
            imageUC.Click +=            Component_Click;

        }

        public string ProductNameLabel
        {
            get { return productName.Text; }
            set { productName.Text = value; }
        }

        public double ProductPriceLabel
        {
            get
            {
                if (double.TryParse(productPrice.Text.Replace(" €", ""), out double price))
                {
                    return price;
                }
                else
                {
                    return 0.0;
                }
            }
            set
            {
                productPrice.Text = $"{value:F2} €";
            }
        }

        public string ProductDescriptionTB
        {
            get { return productDescription.Text; }
            set { productDescription.Text = value; }
        }

        private void Component_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
