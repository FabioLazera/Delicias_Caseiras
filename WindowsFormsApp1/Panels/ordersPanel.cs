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
    public partial class ordersPanel : Form
    {
        public ordersPanel()
        {
            InitializeComponent();
        }

        private void ordersPImg_Click(object sender, EventArgs e)
        {
            newOrdersPanel newOrdersPanel = new newOrdersPanel();
            newOrdersPanel.Show();
        }
    }
}
