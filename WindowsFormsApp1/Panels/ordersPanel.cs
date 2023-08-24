using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            OrderList.LoadOrderIfIsNeeded();
            RefreshDataGridView();
        }

        private void ordersPImg_Click(object sender, EventArgs e)
        {
            newOrdersPanel newOrdersPanel = new newOrdersPanel(this);
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

        public void RefreshDataGridView()
        {
            ordersGrid.Rows.Clear();
            foreach (Order order in OrderList.GetOrders())
            {
                ordersGrid.Rows.Add(order.ID, order.ClientName, order.Status.ToString(), order.OrderType, order.OrderTime, order.NextStage, order.Amount);
            }
        }

        private void ordersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ordersGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn imageColumn)
                {
                    int rowIndex = e.RowIndex;

                    if (imageColumn.Name == "gridDelete")
                    {
                        DialogResult result = MessageBox.Show("Do you want to remove the Order?", "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            OrderList.DeleteOrder(rowIndex);
                            OrderList.SaveToCSV("orders.csv");
                            RefreshDataGridView();
                        }
                    }
                }
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text.Trim().ToLower();

            ordersGrid.Rows.Clear();

            foreach (Order order in OrderList.GetOrders())
            {
                if (order.ClientName.ToLower().StartsWith(searchValue))
                {
                    ordersGrid.Rows.Add(order.ID, order.ClientName, order.Status, order.OrderType, order.OrderTime, order.NextStage, order.Amount);
                }
            }
        }

        private void printer_Click(object sender, EventArgs e)
        {
            OrderList.SaveOrdersToCSV("ordersPlaced.csv");
            MessageBox.Show("Orders saved to CSV successfully!");
        }
    }
}
