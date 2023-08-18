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
    public partial class addDrinksPanel : Form
    {
        private drinksPanel parentForm;
        private int rowIndex;

        public addDrinksPanel(drinksPanel parent, int index = -1)
        {
            InitializeComponent();
            CenterFormOnScreen();
            this.parentForm = parent;
            this.rowIndex = index;

            if (index >= 0)
            {
                Drink drink = DrinkList.GetDrinks()[index];
                drinkNameTB.Text = drink.Name;
                drinkDescriptionTB.Text = drink.Description;
                drinkPriceTB.Text = drink.Price.ToString();
                drinkStockTB.Text = drink.Stock.ToString();
            }
        }

        private void CenterFormOnScreen()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void drinkCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drinkSaveBtn_Click(object sender, EventArgs e)
        {
            if (TextBoxesFilledAndValid())
            {
                string name = drinkNameTB.Text;
                string description = drinkDescriptionTB.Text;
                double price = double.Parse(drinkPriceTB.Text);
                int stock = int.Parse(drinkStockTB.Text);
       
                if (rowIndex >= 0)
                {
                    Drink editedDrink = new Drink(name, description, price, stock);
                    DrinkList.EditDrink(rowIndex, editedDrink);
                    MessageBox.Show("Drink edited successfully!");
                }
                else
                {
                    Drink newDrink = new Drink(name, description, price, stock);
                    DrinkList.AddDrink(newDrink);
                    MessageBox.Show("Drink created successfully!");
                }

                parentForm.RefreshDataGridView();
                this.Close();
            }
        }

        private bool TextBoxesFilledAndValid()
        {
            bool nameValid = !string.IsNullOrWhiteSpace(drinkNameTB.Text);
            bool descriptionValid = !string.IsNullOrWhiteSpace(drinkDescriptionTB.Text);
            bool priceValid = !string.IsNullOrWhiteSpace(drinkPriceTB.Text);
            bool stockValid = !string.IsNullOrWhiteSpace(drinkStockTB.Text);
            

            if (!nameValid || !descriptionValid || !priceValid || !stockValid)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidDouble(drinkPriceTB.Text))
            {
                MessageBox.Show("Invalid price format. Please enter a valid numerical value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidInt(drinkStockTB.Text))
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
