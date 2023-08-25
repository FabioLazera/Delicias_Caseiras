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
    public partial class betweenDatesPanel : Form
    {
        public betweenDatesPanel()
        {
            InitializeComponent();
            ClientList.LoadClientsIfNeeded();
            LoadClientsToComboBox();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadClientsToComboBox()
        {
            clientList.Items.Clear();
            foreach (Client client in ClientList.GetClients())
            {
                clientList.Items.Add(client.Name);
            }
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            string selectedClient = clientList.SelectedItem?.ToString();
            if (selectedClient == null)
            {
                return;
            }

            DateTime startDate1 = startDate.Value;
            DateTime endDate1 = endDate.Value;

            double totalAmount = 0;

            foreach (Order order in OrderList.GetOrders())
            {
                if (order.ClientName == selectedClient && order.OrderTime >= startDate1 && order.OrderTime <= endDate1)
                {
                    totalAmount += order.Amount;
                }
            }

            total.Text = totalAmount.ToString("C");
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
