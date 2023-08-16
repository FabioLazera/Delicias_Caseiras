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
            if (TextBoxesFilledAndValid())
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
        }

        private bool TextBoxesFilledAndValid()
        {
            bool nameValid = !string.IsNullOrWhiteSpace(aCName.Text);
            bool phoneValid = !string.IsNullOrWhiteSpace(aCPN.Text);
            bool addressValid = !string.IsNullOrWhiteSpace(aCA.Text);
            bool nifValid = !string.IsNullOrWhiteSpace(aCNIF.Text);

            if (!nameValid || !phoneValid || !addressValid || !nifValid)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidInt(aCA.Text))
            {
                MessageBox.Show("Invalid age format. Please enter a valid numerical value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsValidInt(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return true;
            }
            return false;
        }

    }
}
