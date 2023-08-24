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
    public partial class ordersPanel : Form
    {
        public event EventHandler PlusHourClicked;
        public event EventHandler PlusDayClicked;

        public ordersPanel()
        {
            InitializeComponent();
            this.Load += ordersPanel_Load;
        }

        private void ordersPImg_Click(object sender, EventArgs e)
        {
            newOrdersPanel newOrdersPanel = new newOrdersPanel();
            newOrdersPanel.Show();
        }

        private void plusHour_Click(object sender, EventArgs e)
        {
            PlusHourClicked?.Invoke(this, EventArgs.Empty);
        }

        private void plusDay_Click(object sender, EventArgs e)
        {
            PlusDayClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ordersPanel_Load(object sender, EventArgs e)
        {
            // Obtém a lista de pedidos
            List<Order> orders = OrderList.GetOrders();

            // Limpa a grade antes de preencher
            ordersGrid.Rows.Clear();

            // Preenche a grade com os detalhes dos pedidos
            foreach (Order order in orders)
            {
                ordersGrid.Rows.Add(
                    order.ID,
                    order.ClientName,
                    order.Status,
                    order.OrderType,
                    order.OrderTime,
                    order.NextStage,
                    order.Amount
                );
            }
        }



        //private void searchTB_TextChanged(object sender, EventArgs e)
        //{
        //    string searchValue = searchTB.Text.Trim().ToLower();
        //
        //    ordersGrid.Rows.Clear();
        //
        //    foreach (Order order in OrderList.GetOrders())
        //    {
        //        if (order.clientList.Name.ToLower().StartsWith(searchValue))
        //        {
        //            ordersGrid.Rows.Add(Address, client.NIF);
        //        }
        //    }
        //}
    }
}
