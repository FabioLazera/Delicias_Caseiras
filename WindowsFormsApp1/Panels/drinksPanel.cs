using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp1.Panels
{
    public partial class drinksPanel : Form
    {
        public drinksPanel()
        {
            InitializeComponent();
            searchTB.TextChanged += searchTB_TextChanged;
            RefreshDataGridView();
        }

        private void drinksPImg_Click(object sender, EventArgs e)
        {
            addDrinksPanel addDrinksPanel = new addDrinksPanel(this);
            addDrinksPanel.Show();
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            drinksGrid.Rows.Clear();
            foreach (Drink drink in DrinkList.GetDrinks())
            {
                drinksGrid.Rows.Add(drink.Name, drink.Description, drink.Price, drink.Stock);
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text.Trim().ToLower();

            drinksGrid.Rows.Clear();

            foreach (Drink drink in DrinkList.GetDrinks())
            {
                if (drink.Name.ToLower().StartsWith(searchValue))
                {
                    drinksGrid.Rows.Add(drink.Name, drink.Description, drink.Price, drink.Stock);
                }
            }
        }

        private void drinksGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (drinksGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn imageColumn)
                {
                    int rowIndex = e.RowIndex;

                    if (imageColumn.Name == "gridEdit")
                    {
                        addDrinksPanel addDrinksPanel = new addDrinksPanel(this, rowIndex);
                        addDrinksPanel.ShowDialog();
                        RefreshDataGridView();
                    }
                    else if (imageColumn.Name == "gridDelete")
                    {
                        DialogResult result = MessageBox.Show("Do you want to remove the Drink?", "Delete Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            DrinkList.DeleteDrink(rowIndex);
                            RefreshDataGridView();
                        }
                    }
                }
            }
        }
    }
}
