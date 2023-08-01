using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Panels;

namespace WindowsFormsApp1
{
    public partial class newOrdersPanel : Form
    {
        public newOrdersPanel()
        {
            InitializeComponent();
            CenterFormOnScreen();
        }

        private void CenterFormOnScreen()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            checkoutsPanel checkoutsPanel = new checkoutsPanel();
            checkoutsPanel.Show();
        }
    }
}
