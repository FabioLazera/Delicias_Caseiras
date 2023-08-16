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
    public partial class clientsPanel : Form
    {

        public clientsPanel()
        {
            InitializeComponent();
            searchTB.TextChanged += searchTB_TextChanged;
            RefreshDataGridView();
        }

        private void clientsPImg_Click(object sender, EventArgs e)
        {
            addClientsPanel addClientsPanel = new addClientsPanel(this);
            addClientsPanel.ShowDialog();
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            clientsGrid.Rows.Clear();
            foreach (Client client in ClientList.GetClients())
            {
                clientsGrid.Rows.Add(client.Name, client.Phone_Number, client.Address, client.NIF);
            }
        }

        private void calculatorImg_Click(object sender, EventArgs e)
        {
            betweenDatesPanel betweenDatesPanel = new betweenDatesPanel();
            betweenDatesPanel.Show();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text.Trim().ToLower();

            clientsGrid.Rows.Clear();

            foreach (Client client in ClientList.GetClients())
            {
                if (client.Name.ToLower().StartsWith(searchValue))
                {
                    clientsGrid.Rows.Add(client.Name, client.Phone_Number, client.Address, client.NIF);
                }
            }
        }

    }
}
