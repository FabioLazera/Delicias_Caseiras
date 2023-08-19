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
    public partial class dishesPanel : Form
    {
        public dishesPanel()
        {
            InitializeComponent();
            searchTB.TextChanged += searchTB_TextChanged;
            if (DishList.GetDish().Count == 0)
            {
                DishList.LoadFromCSV("dishes.csv");
            }
            RefreshDataGridView();
        }

        private void dishesPImg_Click(object sender, EventArgs e)
        {
            addDishesPanel addDishesPanel = new addDishesPanel(this);
            addDishesPanel.Show();
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            dishesGrid.Rows.Clear();
            foreach (Dish dish in DishList.GetDish())
            {
                dishesGrid.Rows.Add(dish.Name, dish.Description, dish.Price, dish.Stock);
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text.Trim().ToLower();

            dishesGrid.Rows.Clear();

            foreach (Dish dish in DishList.GetDish())
            {
                if (dish.Name.ToLower().StartsWith(searchValue))
                {
                    dishesGrid.Rows.Add(dish.Name, dish.Description, dish.Price, dish.Stock);
                }
            }
        }

        private void dishesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dishesGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn imageColumn)
                {
                    int rowIndex = e.RowIndex;

                    if (imageColumn.Name == "gridEdit")
                    {
                        addDishesPanel addDishesPanel = new addDishesPanel(this, rowIndex);
                        if (addDishesPanel.ShowDialog() == DialogResult.OK) 
                        {
                            DishList.SaveToCSV("dishes.csv");
                            RefreshDataGridView();
                        }
                    }
                    else if (imageColumn.Name == "gridDelete")
                    {
                        DialogResult result = MessageBox.Show("Do you want to remove the Dish?", "Delete Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            DishList.DeleteDish(rowIndex);
                            DishList.SaveToCSV("dishes.csv");
                            RefreshDataGridView();
                        }
                    }
                }
            }
        }
    }
}
