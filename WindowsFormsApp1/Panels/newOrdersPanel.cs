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
            DrinkList.LoadDrinksIfNeeded();
            checkoutGrid.RowsAdded += checkoutGrid_RowsAdded;
            checkoutGrid.RowsRemoved += checkoutGrid_RowsRemoved;
            checkoutGrid.CellClick += checkoutGrid_CellClick;
            checkoutBtn.Enabled = false;
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
                productControl.Click += ucProduct_Click;
                flowLayoutPanel.Controls.Add(productControl);
            }
        }

        private void drinksBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            foreach (Drink drink in DrinkList.drinks)
            {
                ucProduct productControl = new ucProduct();
                productControl.ProductNameLabel = drink.Name;
                productControl.ProductPriceLabel = drink.Price;
                productControl.ProductDescriptionTB = drink.Description;
                productControl.Click += ucProduct_Click;
                flowLayoutPanel.Controls.Add(productControl);
            }
        }

        private void UpdateAmountForRow(int rowIndex)
        {
            DataGridViewRow row = checkoutGrid.Rows[rowIndex];
            double price = Convert.ToDouble(row.Cells["noPrice"].Value);
            int quantity = Convert.ToInt32(row.Cells["noQty"].Value);

            double amount = price * quantity;
            row.Cells["noAmount"].Value = amount;
        }

        private void ucProduct_Click(object sender, EventArgs e)
        {
            if (sender is ucProduct productControl)
            {
                string productName = productControl.ProductNameLabel;
                double productPrice = productControl.ProductPriceLabel;

                Drink selectedDrink = DrinkList.drinks.FirstOrDefault(drink => drink.Name == productName);
                Dish selectedDish = DishList.dishes.FirstOrDefault(dish => dish.Name == productName);

                if (selectedDrink != null || selectedDish != null)
                {
                    DataGridViewRow existingRow = null;
                    foreach (DataGridViewRow row in checkoutGrid.Rows)
                    {
                        if (row.Cells["noProduct"].Value.ToString() == productName)
                        {
                            existingRow = row;
                            break;
                        }
                    }
                    if (existingRow != null)
                    {
                        int currentQty = Convert.ToInt32(existingRow.Cells["noQty"].Value);
                        int availableStock = selectedDrink != null ? selectedDrink.Stock : selectedDish.Stock;

                        if (availableStock > 0)
                        {
                            existingRow.Cells["noQty"].Value = currentQty + 1;
                            double totalPrice = productPrice * (currentQty + 1);
                            UpdateAmountForRow(existingRow.Index);
                        }
                        else
                        {
                            MessageBox.Show("Insufficient stock!");
                        }
                    }
                    else
                    {
                        int availableStock = selectedDrink != null ? selectedDrink.Stock : selectedDish.Stock;

                        if (availableStock >= 1)
                        {
                            int rowIndex = checkoutGrid.Rows.Add(productName, 1, productPrice, productPrice);
                            UpdateAmountForRow(rowIndex);
                        }
                        else
                        {
                            MessageBox.Show("Insufficient stock!");
                        }
                    }

                    if (selectedDrink != null && selectedDrink.Stock > 0)
                    {
                        selectedDrink.Stock--;
                    }
                    else if (selectedDish != null && selectedDish.Stock > 0)
                    {
                        selectedDish.Stock--;
                    }

                    UpdateTotalCost();
                }
            }
        }

        private double CalculateTotalCost()
        {
            double total = 0;

            foreach (DataGridViewRow row in checkoutGrid.Rows)
            {
                if (row.Cells["noAmount"].Value != null)
                {
                    total += Convert.ToDouble(row.Cells["noAmount"].Value);
                }
            }

            return total;
        }

        private void UpdateTotalCost()
        {
            double total = CalculateTotalCost();
            totalCost.Text = $"Total: {total:F2} €";
        }

        private void checkoutGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            checkoutBtn.Enabled = checkoutGrid.Rows.Count > 0;
        }

        private void checkoutGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            checkoutBtn.Enabled = checkoutGrid.Rows.Count > 0;
        }

        private void checkoutGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == checkoutGrid.Columns["gridDelete"].Index)
            {
                DataGridViewRow row = checkoutGrid.Rows[e.RowIndex];

                string productName = row.Cells["noProduct"].Value.ToString();
                double productPrice = Convert.ToDouble(row.Cells["noPrice"].Value);
                int quantity = Convert.ToInt32(row.Cells["noQty"].Value);

                Drink selectedDrink = DrinkList.drinks.FirstOrDefault(drink => drink.Name == productName);
                Dish selectedDish = DishList.dishes.FirstOrDefault(dish => dish.Name == productName);

                if (selectedDrink != null && selectedDrink.Stock >= 0)
                {
                    selectedDrink.Stock += quantity;
                }
                else if (selectedDish != null && selectedDish.Stock >= 0)
                {
                    selectedDish.Stock += quantity;
                }

                checkoutGrid.Rows.RemoveAt(e.RowIndex);
                UpdateTotalCost();
                checkoutBtn.Enabled = checkoutGrid.Rows.Count > 0;
            }
        }
    }
}
