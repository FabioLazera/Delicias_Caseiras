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
    public partial class employeesPanel : Form
    {
        public employeesPanel()
        {
            InitializeComponent();
        }

        private void employeesPanel_Load(object sender, EventArgs e)
        {
            searchTB.Height = 100;
        }
    }
}
