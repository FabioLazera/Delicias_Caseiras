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
        }

        private void clientsPImg_Click(object sender, EventArgs e)
        {
            addClientsPanel addClientsPanel = new addClientsPanel();
            addClientsPanel.Show();
        }

        private void calculatorImg_Click(object sender, EventArgs e)
        {
            betweenDatesPanel betweenDatesPanel = new betweenDatesPanel();
            betweenDatesPanel.Show();
        }
    }
}
