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
    public partial class checkoutsPanel : Form
    {
        private List<string> selectedProducts;
        private List<string> cAddress = new List<string>();

        private double totalCost;
        private string orderTimeValue;
        private ordersPanel ordersPanelParent1;

        public checkoutsPanel(double totalCost, string orderTimeValue, ordersPanel ordersPanelParent1, List<string> selectedProducts)
        {
            InitializeComponent();
            CenterFormOnScreen();
            LoadClientsToComboBox();
            this.totalCost =          totalCost;
            this.orderTimeValue =     orderTimeValue;
            checkoutWD.Text =         totalCost.ToString("F2") + "€";
            this.ordersPanelParent1 = ordersPanelParent1;
            this.selectedProducts =   selectedProducts;
            label12.Visible =         false;
            DeliveryAddress.Visible = false;
            checkoutOT.Enabled =      false;
            checkoutPM.Enabled =      false;
        }

        private void CenterFormOnScreen()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ceckoutCB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadClientsToComboBox()
        {
            List<Client> clients = ClientList.GetClients();

            foreach (Client client in clients)
            {
                checkoutClient.Items.Add(client.Name);
                cAddress.Add(client.Address);
            }
        }

        private void UpdateCheckoutValues()
        {
            if (double.TryParse(checkoutDiscount.Text, out double discount) && discount >= 0 && discount <= 100)
            {
                double discountAmount =   this.totalCost * discount / 100;
                double finalAmountToPay = this.totalCost - discountAmount;

                checkoutFAP.Text = finalAmountToPay.ToString("F2") + " €";

                if (checkoutPM.SelectedItem == "Cash")
                {
                    if (double.TryParse(checkoutCashR.Text, out double cashReceived) && cashReceived >= finalAmountToPay)
                    {
                        double changeAmount = cashReceived - finalAmountToPay;
                        checkoutMC.Text =     changeAmount.ToString("F2") + " €";
                    }
                    else
                    {
                        checkoutMC.Text = "Insufficient cash";
                    }
                }
                else if (checkoutPM.SelectedItem == "MbWay" || checkoutPM.SelectedItem == "Visa")
                {
                    checkoutCashR.Text = finalAmountToPay.ToString("F2");
                    checkoutMC.Text = "0 €";
                }
                else
                {
                    checkoutMC.Text = "";
                }
            }
            else
            {
                checkoutFAP.Text = "";
                checkoutMC.Text = "";
            }
            UpdateCheckoutButtonStatus();
        }

        private void UpdateCheckoutButtonStatus()
        {
            bool discountValid =              double.TryParse(checkoutDiscount.Text, out double discount) && discount >= 0 && discount <= 100;
            bool clientSelected =             checkoutClient.SelectedIndex != -1;
            bool paymentMethodSelected =      checkoutPM.SelectedIndex != -1;
            bool orderTypeSelected =          checkoutOT.SelectedIndex != -1;
            bool cashReceivedValid =          double.TryParse(checkoutCashR.Text, out double cashReceived);
            bool paymentMethodIsCash =        checkoutPM.SelectedItem == "Cash";
            bool paymentMethodIsMbWayOrVisa = checkoutPM.SelectedItem == "MbWay" || checkoutPM.SelectedItem == "Visa";
            bool validCashReceivedForCash =   paymentMethodIsCash && cashReceivedValid && cashReceived >= double.Parse(checkoutFAP.Text.Replace(" €", ""));
            bool validPaymentMethod =         paymentMethodIsCash || paymentMethodIsMbWayOrVisa;
            bool checkoutSBEnabled =          discountValid && clientSelected && paymentMethodSelected && orderTypeSelected && validPaymentMethod && (validCashReceivedForCash || paymentMethodIsMbWayOrVisa);
            checkoutSB.Enabled =              checkoutSBEnabled;
        }

        private void checkoutDiscount_TextChanged(object sender, EventArgs e)
        {
            UpdateCheckoutValues();
            UpdateCheckoutButtonStatus();
        }

        private void checkoutCashR_TextChanged(object sender, EventArgs e)
        {
            UpdateCheckoutValues();
            UpdateCheckoutButtonStatus();
        }

        private void checkoutClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkoutOT.Enabled = true;
            UpdateCheckoutButtonStatus();
            changeAddress();
        }

        private void checkoutPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCheckoutValues();
            UpdateCheckoutButtonStatus();
        }

        private void checkoutOT_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkoutPM.Enabled = true;

            if (checkoutOT.Text == "Delivery")
            {
                checkoutPM.Items.Remove("Cash");
                label12.Visible =         true;
                DeliveryAddress.Visible = true;

                changeAddress();
            }
            else
            {
                if (!checkoutPM.Items.Contains("Cash"))
                {
                    checkoutPM.Items.Add("Cash");
                }
                label12.Visible =         false;
                DeliveryAddress.Visible = false;
            }

            UpdateCheckoutButtonStatus();
        }

        private void checkoutSB_Click(object sender, EventArgs e)
        {
            if (double.TryParse(checkoutFAP.Text.Replace(" €", ""), out double amount))
            {
                string clientName =  checkoutClient.SelectedItem.ToString();
                string status =      "Pending";
                string orderType =   checkoutOT.SelectedItem.ToString();
                DateTime orderTime = DateTime.Parse(orderTimeValue);
                DateTime nextStage = orderTime.AddMinutes(15);

                foreach (string productName in selectedProducts)
                {
                    Drink selectedDrink = DrinkList.drinks.FirstOrDefault(drink => drink.Name == productName);
                    Dish selectedDish =   DishList.dishes.FirstOrDefault(dish => dish.Name == productName);

                    if (selectedDrink != null && selectedDrink.Stock >= 1)
                    {
                        selectedDrink.Stock--;
                    }
                    else if (selectedDish != null && selectedDish.Stock >= 1)
                    {
                        selectedDish.Stock--;
                    }
                    DrinkList.SaveToCSV("drinks.csv");
                    DishList.SaveToCSV("dishes.csv");
                }

                if (checkoutOT.Text == "Delivery")
                {
                    Delivery delivery = new Delivery(DeliveryAddress.Text, orderTime.AddHours(1));



                    Order newOrder = new Order(OrderList.GetNextOrderId(), clientName, status, orderType, orderTime, nextStage, amount, delivery);
                    OrderList.AddOrder(newOrder);
                }
                else
                {
                    Order newOrder = new Order(OrderList.GetNextOrderId(), clientName, status, orderType, orderTime, nextStage, amount);
                    OrderList.AddOrder(newOrder);
                }

                MessageBox.Show("Order created successfully!");
                this.ordersPanelParent1.RefreshDataGridView();
                OrderList.SaveToCSV("orders.csv");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error creating order. Check the entered values.");
            }
        }

        private void changeAddress()
        {
            int add =              checkoutClient.SelectedIndex;
            DeliveryAddress.Text = cAddress[add];
        }
    }
}