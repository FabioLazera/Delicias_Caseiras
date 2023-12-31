﻿using System;
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
        private int rowIndex;

        public addClientsPanel(clientsPanel parent, int index = -1)
        {
            InitializeComponent();
            CenterFormOnScreen();
            this.parentForm = parent;
            this.rowIndex =   index;

            if (index >= 0)
            {
                Client client = ClientList.GetClients()[index];
                aCName.Text =   client.Name;
                aCPN.Text =     client.Phone_Number;
                aCA.Text =      client.Address;
                aCNIF.Text =    client.NIF.ToString();
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
                string name =        aCName.Text;
                string phoneNumber = aCPN.Text;
                string address =     aCA.Text;
                long nif =           long.Parse(aCNIF.Text);

                if (rowIndex >= 0)
                {
                    Client editedClient = new Client(name, phoneNumber, address, nif);
                    ClientList.EditClient(rowIndex, editedClient);
                    ClientList.SaveToCSV("clients.csv");
                    MessageBox.Show("Client edited successfully!");
                }
                else
                {
                    Client newClient = new Client(name, phoneNumber, address, nif);
                    ClientList.AddClient(newClient);
                    ClientList.SaveToCSV("clients.csv");
                    MessageBox.Show("Client created successfully!");
                }

                parentForm.RefreshDataGridView();
                this.Close();
            }
        }

        private bool TextBoxesFilledAndValid()
        {
            bool nameValid =    !string.IsNullOrWhiteSpace(aCName.Text) && !aCName.Text.Contains(";");
            bool phoneValid =   !string.IsNullOrWhiteSpace(aCPN.Text) && !aCPN.Text.Contains(";");
            bool addressValid = !string.IsNullOrWhiteSpace(aCA.Text) && !aCA.Text.Contains(";");
            bool nifValid =     !string.IsNullOrWhiteSpace(aCNIF.Text) && !aCNIF.Text.Contains(";");

            if (!nameValid || !phoneValid || !addressValid || !nifValid)
            {
                MessageBox.Show("Please fill in all fields and do not use semicolons.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidInt(aCNIF.Text))
            {
                MessageBox.Show("Invalid NIF format. Please enter a valid numerical value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (rowIndex >= 0)
            {
                if (EmployeeList.IfNifExistsIndex(aCNIF.Text, rowIndex) == true || ClientList.IfNifExistsIndex(aCNIF.Text, rowIndex) == true)
                {
                    MessageBox.Show("Nif alredy exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (ClientList.IfContactExistsIndex(aCPN.Text, rowIndex) == true)
                {
                    MessageBox.Show("This phone alredy exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                if (EmployeeList.IfNifExists(aCNIF.Text) == true || ClientList.IfNifExists(aCNIF.Text) == true)
                {
                    MessageBox.Show("Nif alredy exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (ClientList.IfContactExists(aCPN.Text) == true)
                {
                    MessageBox.Show("This phone alredy exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool IsValidInt(string input)
        {
            if (int.TryParse(input, out int result) && result >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
