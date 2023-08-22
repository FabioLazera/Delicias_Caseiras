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
        public checkoutsPanel()
        {
            InitializeComponent();
            CenterFormOnScreen();
            LoadClientsToComboBox();
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
                ceckoutClient.Items.Add(client.Name);
            }
        }

    }
}
