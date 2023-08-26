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
            ordersGrid.CellFormatting += ordersGrid_CellFormatting;

        }

        private void ordersPImg_Click(object sender, EventArgs e)
        {
            newOrdersPanel newOrdersPanel = new newOrdersPanel(this);
            newOrdersPanel.Show();
        }

        private void plusHour_Click(object sender, EventArgs e)
        {
            PlusHourClicked?.Invoke(this, EventArgs.Empty);
            Alert();
        }

        private void plusDay_Click(object sender, EventArgs e)
        {
            PlusDayClicked?.Invoke(this, EventArgs.Empty);
            Alert();
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
                else if (ordersGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn buttonColumn)
                {
                    Menu menuForm = Application.OpenForms.OfType<Menu>().FirstOrDefault();
                    DateTime nextStageValue = DateTime.Parse(menuForm.dateHour.Text);

                    int rowIndex = e.RowIndex;

                    if (buttonColumn.Name == "oStatus")
                    {
                        Order selectedOrder = OrderList.GetOrders()[rowIndex];
                        switch (selectedOrder.Status)
                        {
                            case "Pending":
                                selectedOrder.Status = "In Preparation";
                                selectedOrder.NextStage = nextStageValue.AddMinutes(30);
                                break;

                            case "In Preparation":
                                selectedOrder.Status = "Ready For Delivery";
                                selectedOrder.NextStage = nextStageValue.AddMinutes(20);
                                break;

                            case "Ready For Delivery":
                                selectedOrder.Status = "Delivered";
                                buttonColumn.ReadOnly = true;
                                ordersGrid.Rows[rowIndex].Cells["oForecast"].Value = "";
                                break;
                        }
                        ordersGrid.Rows[rowIndex].Cells["oStatus"].Value = selectedOrder.Status.ToString();
                        ordersGrid.Rows[rowIndex].Cells["oForecast"].Value = selectedOrder.NextStage;
                        OrderList.SaveToCSV("orders.csv");
                    }
                }
            }
        }

        private void ordersGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ordersGrid.Columns[e.ColumnIndex].Name == "oForecast")
                {
                    Order order = OrderList.GetOrders()[e.RowIndex];

                    if (order.Status == "Delivered")
                    {
                        e.Value = ""; 
                    }
                }
                else if (ordersGrid.Columns[e.ColumnIndex].Name == "oTime" || ordersGrid.Columns[e.ColumnIndex].Name == "oForecast")
                {
                    DataGridViewCell cell = ordersGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Order order = OrderList.GetOrders()[e.RowIndex];

                    if (order.Status == "Pending")
                    {
                        cell.Style.ForeColor = Color.Red;
                    }
                    else if (order.Status == "In Preparation")
                    {
                        cell.Style.ForeColor = Color.Orange;
                    }
                    else if (order.Status == "Ready For Delivery")
                    {
                        cell.Style.ForeColor = Color.Blue;
                    }
                    else if (order.Status == "Delivered")
                    {
                        cell.Style.ForeColor = Color.Green;
                    }
                    else
                    {
                        cell.Style.ForeColor = ordersGrid.DefaultCellStyle.ForeColor;
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

        private void timeAlertStatus_Tick(object sender, EventArgs e)
        {
            Alert();
        }

        private void Alert()
        {
            Menu menuForm = Application.OpenForms.OfType<Menu>().FirstOrDefault();

            foreach (Order order in OrderList.GetOrders())
            {
                if (order.Status == "In Preparation" || order.Status == "Ready For Delivery")
                {
                    if (DateTime.Parse(menuForm.dateHour.Text) >= order.NextStage)
                    {
                        MessageBox.Show($"Order {order.ID} with state {order.Status} is in arrears!");
                    }
                }
            }
        }

        private void FilterOrdersByStatus(string status)
        {
            ordersGrid.Rows.Clear();

            foreach (Order order in OrderList.GetOrders())
            {
                if (order.Status == status)
                {
                    ordersGrid.Rows.Add(order.ID, order.ClientName, order.Status.ToString(), order.OrderType, order.OrderTime, order.NextStage, order.Amount);
                }
            }
        }

        private void filterByState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = filterByState.SelectedItem.ToString();

            if (selectedStatus == "All")
            {
                RefreshDataGridView();
                ordersGrid.Columns["gridDelete"].Visible = true;
            }
            else
            {
                FilterOrdersByStatus(selectedStatus);
                ordersGrid.Columns["gridDelete"].Visible = false;
            }
            searchTB.Clear();
           
        }
    }
}
