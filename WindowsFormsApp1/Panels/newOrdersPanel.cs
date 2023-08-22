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
            // Verificar se o objeto sender é um ucProduct (controlo de produto)
            if (sender is ucProduct productControl)
            {
                // Obter o nome e o preço do produto a partir do ucProduct
                string productName = productControl.ProductNameLabel;
                double productPrice = productControl.ProductPriceLabel;

                // Encontrar o produto correspondente na lista de Bebidas (Drinks) ou Pratos (Dishes)
                Drink selectedDrink = DrinkList.drinks.FirstOrDefault(drink => drink.Name == productName);
                Dish selectedDish = DishList.dishes.FirstOrDefault(dish => dish.Name == productName);

                // Verificar se foi selecionada uma bebida ou um prato
                if (selectedDrink != null || selectedDish != null)
                {
                    // Procurar por uma linha existente na checkoutGrid com o mesmo produto
                    DataGridViewRow existingRow = null;
                    foreach (DataGridViewRow row in checkoutGrid.Rows)
                    {
                        if (row.Cells["noProduct"].Value.ToString() == productName)
                        {
                            existingRow = row;
                            break;
                        }
                    }

                    // Verificar se já existe uma linha para este produto na checkoutGrid
                    if (existingRow != null)
                    {
                        // Obter a quantidade atual e o stock disponível
                        int currentQty = Convert.ToInt32(existingRow.Cells["noQty"].Value);
                        int availableStock = selectedDrink != null ? selectedDrink.Stock : selectedDish.Stock;

                        // Verificar se é possível aumentar a quantidade sem exceder o stock disponível
                        if (currentQty + 1 <= availableStock)
                        {
                            // Atualizar a quantidade na linha existente
                            existingRow.Cells["noQty"].Value = currentQty + 1;
                            double totalPrice = productPrice * (currentQty + 1);
                            UpdateAmountForRow(existingRow.Index);
                        }
                        else
                        {
                            // Exibir mensagem se o stock for insuficiente para adicionar mais unidades
                            MessageBox.Show("Stock insuficiente!");
                        }
                    }
                    else
                    {
                        // Obter o stock disponível
                        int availableStock = selectedDrink != null ? selectedDrink.Stock : selectedDish.Stock;

                        // Verificar se há stock disponível para adicionar pelo menos 1 unidade
                        if (availableStock >= 1)
                        {
                            // Adicionar uma nova linha para o produto na checkoutGrid
                            int rowIndex = checkoutGrid.Rows.Add(productName, 1, productPrice, productPrice);
                            UpdateAmountForRow(rowIndex);
                        }
                        else
                        {
                            // Exibir mensagem se não houver stock para adicionar unidades
                            MessageBox.Show("Stock insuficiente!");
                        }
                    }

                    // Atualizar o stock restante apenas se houver stock disponível e não for 0
                    if (selectedDrink != null && selectedDrink.Stock > 0)
                    {
                        selectedDrink.Stock--;
                    }
                    else if (selectedDish != null && selectedDish.Stock > 0)
                    {
                        selectedDish.Stock--;
                    }

                    // Atualizar o custo total da encomenda
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
    }
}
