using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Restaurant Delicias_Caseiras_Porto = new Restaurant();

        public Form1()
        {
            InitializeComponent();
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            //Delicias_Caseiras_Porto.AddOrder();
        }
    }
}
