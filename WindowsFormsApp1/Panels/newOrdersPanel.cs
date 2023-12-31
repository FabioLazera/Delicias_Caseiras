﻿using System;
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
        // List to keep track of selected products.
        private List<string> selectedProducts = new List<string>();
        private ordersPanel ordersPanelParent;

        public newOrdersPanel(ordersPanel ordersPanelParent)
        {
            InitializeComponent();
            CenterFormOnScreen();
            DishList.LoadDishesIfNeeded();
            DrinkList.LoadDrinksIfNeeded();
            ClientList.LoadClientsIfNeeded();
            // Attach event handlers and initialize UI components.
            checkoutGrid.RowsAdded +=   checkoutGrid_RowsAdded;
            checkoutGrid.RowsRemoved += checkoutGrid_RowsRemoved;
            checkoutGrid.CellClick +=   checkoutGrid_CellClick;
            checkoutBtn.Enabled =       false;
            // Reference to the parent ordersPanel.
            this.ordersPanelParent =    ordersPanelParent;
            // Set formatting for DataGridView columns.
            checkoutGrid.Columns[2].DefaultCellStyle.Format = "0.00";
            checkoutGrid.Columns[3].DefaultCellStyle.Format = "0.00";
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
            double totalCost1 = CalculateTotalCost();
            Menu menuForm =     Application.OpenForms.OfType<Menu>().FirstOrDefault();
            if (menuForm != null)
            {
                checkoutsPanel checkoutsPanel = new checkoutsPanel(totalCost1, menuForm.DateHour, this.ordersPanelParent, selectedProducts);
                checkoutsPanel.Show();
                checkoutGrid.Rows.Clear();
                totalCost.Text = "Total: 0€";
            }
            else
            {
                MessageBox.Show("The Menu form is not open!");
            }
        }

        private void dishesBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            foreach (Dish dish in DishList.dishes)
            {
                ucProduct productControl =             new ucProduct();
                productControl.imageUC.ImageLocation = dish.ImagePath;
                productControl.ProductNameLabel =      dish.Name;
                productControl.ProductPriceLabel =     dish.Price;
                productControl.ProductDescriptionTB =  dish.Description;
                productControl.Click += ucProduct_Click;
                flowLayoutPanel.Controls.Add(productControl);
            }
        }

        private void drinksBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            foreach (Drink drink in DrinkList.drinks)
            {
                ucProduct productControl =             new ucProduct();
                productControl.imageUC.ImageLocation = drink.ImagePath;
                productControl.ProductNameLabel =      drink.Name;
                productControl.ProductPriceLabel =     drink.Price;
                productControl.ProductDescriptionTB =  drink.Description;
                productControl.Click += ucProduct_Click;
                flowLayoutPanel.Controls.Add(productControl);
            }
        }

        private void UpdateAmountForRow(int rowIndex)
        {
            // Update the total amount for a specific row in the checkoutGrid.
            DataGridViewRow row = checkoutGrid.Rows[rowIndex];
            double price =        Convert.ToDouble(row.Cells["noPrice"].Value);
            int quantity =        Convert.ToInt32(row.Cells["noQty"].Value);
            double amount =       price * quantity;

            row.Cells["noAmount"].Value = amount;
        }

        private void ucProduct_Click(object sender, EventArgs e)
        {
            // Handle product selection when clicked.
            if (sender is ucProduct productControl)
            {
                string productName =  productControl.ProductNameLabel;
                double productPrice = productControl.ProductPriceLabel;

                Drink selectedDrink = DrinkList.drinks.FirstOrDefault(drink => drink.Name == productName);
                Dish selectedDish =   DishList.dishes.FirstOrDefault(dish => dish.Name == productName);

                if (selectedDrink != null || selectedDish != null)
                {
                    DataGridViewRow existingRow = null;
                    // Check if the product is already in the checkoutGrid.
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
                        int currentQty =     Convert.ToInt32(existingRow.Cells["noQty"].Value);
                        int availableStock = selectedDrink != null ? selectedDrink.Stock : selectedDish.Stock;

                        if (availableStock > currentQty)
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
                    selectedProducts.Add(productName);
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
            // Handle cell click event for removing items from the checkoutGrid.
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
