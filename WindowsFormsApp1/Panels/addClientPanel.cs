using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.Panels
{
    public partial class addClientsPanel : Form
    {
        private clientsPanel parentForm;

        public addClientsPanel(clientsPanel parent)
        {
            InitializeComponent();
            CenterFormOnScreen();
            this.parentForm = parent;
        }

        private void addClientsPanel_Load(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;

            if (aCName.Text == "" || aCPN.Text == "" || aCA.Text == "" || aCNIF.Text == "")
            {
                saveBtn.Enabled = false;
            }
        }


        private void CenterFormOnScreen()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (TextBoxesFilled() && IsValid(aCNIF.Text))
            {
                string name = aCName.Text;
                string phoneNumber = aCPN.Text;
                string address = aCA.Text;
                long nif = long.Parse(aCNIF.Text);

                Client newClient = new Client(name, phoneNumber, address, nif);
                ClientList.AddClient(newClient);
                MessageBox.Show("Customer created successfully!");
                parentForm.RefreshDataGridView();

                aCName.Clear();
                aCPN.Clear();
                aCA.Clear();
                aCNIF.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in all fields and check that the NIF field is filled in correctly.");
            }
        }

        private bool TextBoxesFilled()
        {
            return !string.IsNullOrWhiteSpace(aCName.Text) &&
                   !string.IsNullOrWhiteSpace(aCPN.Text) &&
                   !string.IsNullOrWhiteSpace(aCA.Text) &&
                   !string.IsNullOrWhiteSpace(aCNIF.Text);
        }

        private bool IsValid(string input)
        {
            if (long.TryParse(input, out long result))
            {
                const int NifValue = 999999999;

                if (result <= NifValue)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
