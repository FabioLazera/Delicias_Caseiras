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
    public partial class deliveriesPanel : Form
    {
        public deliveriesPanel()
        {
            InitializeComponent();
            OrderList.LoadOrderIfIsNeeded();
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            deliveriesGrid.Rows.Clear();
            foreach (Order order in OrderList.GetOrders())
            {
                if (order.OrderType == "Delivery")
                {
                    if (order.Status == "Ready For Delivery")
                    {
                        deliveriesGrid.Rows.Add(order.ID, order.ClientName, order.Status, order.OrderTime, order.NextStage, order.Delivery.DeliveryForecast, order.Delivery.DeliveryAddress);
                    }
                }
            }
        }

        private void deliveriesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (deliveriesGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn buttonColumn)
                {
                    int rowIndex = e.RowIndex;

                    if (buttonColumn.Name == "dStatus")
                    {
                        int orderID = Convert.ToInt32(deliveriesGrid.Rows[rowIndex].Cells["dID"].Value);
                        Order selectedOrder = OrderList.GetOrdersById(orderID);

                        if (selectedOrder.Status.ToString() == "Ready For Delivery")
                        {
                            selectedOrder.Status = "Delivered";
                            buttonColumn.ReadOnly = true;
                        }
                        OrderList.SaveToCSV("orders.csv");
                        RefreshDataGridView();
                    }
                }
            }
        }
    }
}
