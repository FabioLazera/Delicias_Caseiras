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
    public partial class invoicePanel : Form
    {
        private List<string> selectedProducts;
        private Order myorder;
        private long myNif;
        private string subtotal;
        private string discount;
        private string finalAP;
        private string moneyChange;
        private string paymentMethod;
        private double total;
        private string moneyReceived;

        public invoicePanel(Order neworder, List<string> selectedProducts, long myNif, string subtotal, string discount, string finalAP, string moneyChange, string paymentMethod, string moneyReceived)
        {
            InitializeComponent();
            CenterFormOnScreen();
            myorder =               neworder;
            this.selectedProducts = selectedProducts;
            this.myNif =            myNif;
            this.subtotal =         subtotal;
            this.discount =         discount;
            this.finalAP =          finalAP;
            this.moneyChange =      moneyChange;
            this.paymentMethod =    paymentMethod;

            double.TryParse(finalAP.Replace(" €", ""), out total);
            this.moneyReceived =    moneyReceived;

            RefreshDataGridView();
        }

        private void CenterFormOnScreen()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void RefreshDataGridView()
        {
            invoiceGrid.Rows.Clear();

            foreach (string productName in selectedProducts)
            {
                bool productExists = false;
                int rowIndex = -1;

                for (int i = 0; i < invoiceGrid.Rows.Count; i++)
                {
                    if (invoiceGrid.Rows[i].Cells["fProduct"].Value != null && invoiceGrid.Rows[i].Cells["fProduct"].Value.ToString() == productName)
                    {
                        productExists = true;
                        rowIndex = i;
                        break;
                    }
                }

                if (productExists)
                {
                    int currentQty = Convert.ToInt32(invoiceGrid.Rows[rowIndex].Cells["fQty"].Value);
                    invoiceGrid.Rows[rowIndex].Cells["fQty"].Value = (currentQty + 1).ToString();
                }
                else
                {
                    int newRowIdx = invoiceGrid.Rows.Add();
                    invoiceGrid.Rows[newRowIdx].Cells["fProduct"].Value = productName;
                    invoiceGrid.Rows[newRowIdx].Cells["fQty"].Value = "1"; 
                }
            }

            for (int i = 0; i < invoiceGrid.Rows.Count; i++)
            {
                if (invoiceGrid.Rows[i] != null)
                {
                    Drink selectedDrink = DrinkList.drinks.FirstOrDefault(drink => drink.Name == invoiceGrid.Rows[i].Cells["fProduct"].Value.ToString());
                    Dish selectedDish = DishList.dishes.FirstOrDefault(dish => dish.Name == invoiceGrid.Rows[i].Cells["fProduct"].Value.ToString());

                    if (selectedDrink != null)
                    {
                        int currentQty = Convert.ToInt32(invoiceGrid.Rows[i].Cells["fQty"].Value);
                        invoiceGrid.Rows[i].Cells["fTotal"].Value = (currentQty * selectedDrink.Price).ToString();
                    }
                    else if (selectedDish != null)
                    {
                        int currentQty = Convert.ToInt32(invoiceGrid.Rows[i].Cells["fQty"].Value);
                        invoiceGrid.Rows[i].Cells["fTotal"].Value = (currentQty * selectedDish.Price).ToString();
                    }
                }
            }

            label8.Text =  myorder.OrderTime.ToString();
            label10.Text = this.myNif.ToString();
            label18.Text = this.subtotal;
            label19.Text = this.discount + "%";
            label20.Text = this.finalAP;
            label16.Text = this.paymentMethod;
            label21.Text = this.moneyReceived + " €";
            label22.Text = this.moneyChange;
            label28.Text = (total * 0.77).ToString("F2");
            label29.Text = (total * 0.23).ToString("F2");
            label30.Text = this.finalAP;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
