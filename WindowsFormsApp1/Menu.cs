using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Panels;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        private Button lastPressedButton;
        public Menu()
        {
            InitializeComponent();
            CenterFormOnScreen();
        }

        private void CenterFormOnScreen()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddPanel(Form f)
        {
            mainPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            mainPanel.Controls.Add(f);
            f.Show();
        }

        private void HighlightButton(Button button)
        {
            if (lastPressedButton != null)
            {
                lastPressedButton.BackColor = Color.FromArgb(50, 55, 89);
            }
            button.BackColor = Color.FromArgb(90, 95, 129);
            lastPressedButton = button;
        }


        private void ordersBtn_Click(object sender, EventArgs e)
        {
            AddPanel(new ordersPanel());
            HighlightButton(ordersBtn);
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            AddPanel(new employeesPanel());
            HighlightButton(employeesBtn);
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            AddPanel(new clientsPanel());
            HighlightButton(clientsBtn);
        }

        private void drinksBtn_Click(object sender, EventArgs e)
        {
            AddPanel(new drinksPanel());
            HighlightButton(drinksBtn);
        }

        private void dishesBtn_Click(object sender, EventArgs e)
        {
            AddPanel(new dishesPanel());
            HighlightButton(dishesBtn);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DrinkList.SaveToCSV("drinks.csv");
            DishList.SaveToCSV("dishes.csv");
            ClientList.SaveToCSV("clients.csv");
            Application.Exit();
        }
    }
}
