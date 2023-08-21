using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Panels;

namespace WindowsFormsApp1
{
    public partial class newOrdersPanel : Form
    {
        private List<Dish> selectedDishes = new List<Dish>();
        public newOrdersPanel()
        {
            InitializeComponent();
            CenterFormOnScreen();
            DishList.LoadDishesIfNeeded();
        }

        private void CenterFormOnScreen()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            checkoutsPanel checkoutsPanel = new checkoutsPanel();
            checkoutsPanel.Show();
        }

        private void dishesBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            foreach (Dish dish in DishList.dishes)
            {
                ucProduct productControl = new ucProduct();
                productControl.ProductNameLabel = dish.Name;
                productControl.ProductPriceLabel = dish.Price;
                productControl.ProductDescriptionTB = dish.Description;

                flowLayoutPanel.Controls.Add(productControl);
            }
        }
    }
}
