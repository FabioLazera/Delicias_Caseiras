﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Panels
{
    public partial class dishesPanel : Form
    {
        public dishesPanel()
        {
            InitializeComponent();
        }

        private void dishesPImg_Click(object sender, EventArgs e)
        {
            addDishesPanel addDishesPanel = new addDishesPanel();
            addDishesPanel.Show();
        }
    }
}
