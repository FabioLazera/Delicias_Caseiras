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
        private double totalCost;
        private string orderTimeValue;
        public event EventHandler OrderCreated;
        public checkoutsPanel(double totalCost, string orderTimeValue)
        {
            InitializeComponent();
            CenterFormOnScreen();
            LoadClientsToComboBox();
            this.totalCost = totalCost;
            this.orderTimeValue = orderTimeValue;
            checkoutWD.Text = totalCost.ToString("F2") + "€";
            
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
            }
        }

        private void UpdateCheckoutValues()
        {
            if (checkoutPM.SelectedItem != "Cash")
            {
                checkoutCashR.Text = "";
                checkoutMC.Text = "";
            }
            else
            {
                if (double.TryParse(checkoutDiscount.Text, out double discount) && discount >= 0 && discount <= 100)
                {
                    double discountAmount = this.totalCost * discount / 100;
                    double finalAmountToPay = this.totalCost - discountAmount;

                    checkoutFAP.Text = finalAmountToPay.ToString("F2") + " €";

                    if (double.TryParse(checkoutCashR.Text, out double cashReceived) && cashReceived >= finalAmountToPay)
                    {
                        double changeAmount = cashReceived - finalAmountToPay;
                        checkoutMC.Text = changeAmount.ToString("F2") + " €";
                    }
                    else
                    {
                        checkoutMC.Text = "Insufficient cash";
                    }
                }
                else
                {
                    checkoutFAP.Text = "";
                    checkoutMC.Text = "";
                }
            }
            UpdateCheckoutButtonStatus();
        }

        private void UpdateCheckoutButtonStatus()
        {
            bool discountValid = double.TryParse(checkoutDiscount.Text, out double discount) && discount >= 0 && discount <= 100;
            bool cashReceivedValid = double.TryParse(checkoutCashR.Text, out double cashReceived);
            bool sufficientCash = checkoutMC.Text != "Insufficient cash";
            bool clientSelected = checkoutClient.SelectedIndex != -1;
            bool paymentMethodSelected = checkoutPM.SelectedIndex != -1;
            bool orderTypeSelected = checkoutOT.SelectedIndex != -1;

            checkoutSB.Enabled = discountValid && cashReceivedValid && sufficientCash && clientSelected && paymentMethodSelected && orderTypeSelected;
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
            UpdateCheckoutButtonStatus();
        }

        private void checkoutPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCheckoutValues();
            UpdateCheckoutButtonStatus();
        }

        private void checkoutOT_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCheckoutButtonStatus();
        }

        private void checkoutSB_Click(object sender, EventArgs e)
        {
            if (double.TryParse(checkoutFAP.Text.Replace(" €", ""), out double amount))
            {
                string clientName = checkoutClient.SelectedItem.ToString();
                string status = "Pending";
                string orderType = checkoutOT.SelectedItem.ToString();
                DateTime orderTime = DateTime.Parse(orderTimeValue);
                DateTime nextStage = orderTime.AddMinutes(15);

                Order newOrder = new Order(OrderList.GetNextOrderId(), clientName, status, orderType, orderTime, nextStage, amount);
                OrderList.AddOrder(newOrder);

                MessageBox.Show("Order created successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error creating order. Check the entered values.");
            }
        }
    }
}