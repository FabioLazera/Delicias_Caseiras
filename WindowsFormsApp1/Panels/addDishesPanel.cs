using System;
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
    public partial class addDishesPanel : Form
    {
        private dishesPanel parentForm;
        private int rowIndex;

        public addDishesPanel(dishesPanel parent, int index = -1)
        {
            InitializeComponent();
            CenterFormOnScreen();
            this.parentForm = parent;
            this.rowIndex = index;

            if (index >= 0)
            {
                Dish dish = DishList.GetDish()[index];


                dishNameTB.Text = dish.Name;
                dishDescriptionTB.Text = dish.Description;
                dishPriceTB.Text = dish.Price.ToString();
                dishStockTB.Text = dish.Stock.ToString();
            }
        }

        private void CenterFormOnScreen()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void dishCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dishSaveBtn_Click(object sender, EventArgs e)
        {
            if (TextBoxesFilledAndValid())
            {
                string name = dishNameTB.Text;
                string description = dishDescriptionTB.Text;
                double price = double.Parse(dishPriceTB.Text);
                int stock = int.Parse(dishStockTB.Text);

                if (rowIndex >= 0)
                {
                    Dish editedDish = new Dish(name, description, price, stock);
                    DishList.EditDish(rowIndex, editedDish);
                    MessageBox.Show("Dish edited successfully!");
                }
                else
                {
                    Dish newDish = new Dish(name, description, price, stock);
                    DishList.AddDish(newDish);
                    MessageBox.Show("Dish created successfully!");
                }

                parentForm.RefreshDataGridView();
                this.Close();
            }
        }

        private bool TextBoxesFilledAndValid()
        {
            bool nameValid = !string.IsNullOrWhiteSpace(dishNameTB.Text);
            bool descriptionValid = !string.IsNullOrWhiteSpace(dishDescriptionTB.Text);
            bool priceValid = !string.IsNullOrWhiteSpace(dishPriceTB.Text);
            bool stockValid = !string.IsNullOrWhiteSpace(dishStockTB.Text);


            if (!nameValid || !descriptionValid || !priceValid || !stockValid)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidDouble(dishPriceTB.Text))
            {
                MessageBox.Show("Invalid price format. Please enter a valid numerical value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidInt(dishStockTB.Text))
            {
                MessageBox.Show("Invalid stock format. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidInt(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return true;
            }
            return false;
        }

        private bool IsValidDouble(string input)
        {
            if (double.TryParse(input, out double result))
            {
                return true;
            }
            return false;
        }
    }
}
