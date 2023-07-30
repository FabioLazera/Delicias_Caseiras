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

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            AddPanel(new employeesPanel());
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            AddPanel(new clientsPanel());
        }

        private void drinksBtn_Click(object sender, EventArgs e)
        {
            AddPanel(new drinksPanel());
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
