using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Panels
{
    public partial class addDishesPanel : Form
    {
        private dishesPanel parentForm;
        private int rowIndex;

        public addDishesPanel(dishesPanel parent, int index = -1)
        {
            InitializeComponent();
            CenterFormOnScreen();
            this.parentForm = parent;
            this.rowIndex =   index;

            if (index >= 0)
            {
                Dish dish = DishList.GetDish()[index];
                dishNameTB.Text =        dish.Name;
                dishDescriptionTB.Text = dish.Description;
                dishPriceTB.Text =       dish.Price.ToString();
                dishStockTB.Text =       dish.Stock.ToString();
                LoadDishImage(dish.ImagePath);
            }
        }

        private void CenterFormOnScreen()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void dishCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dishSaveBtn_Click(object sender, EventArgs e)
        {
            if (TextBoxesFilledAndValid())
            {
                string name =        dishNameTB.Text;
                string description = dishDescriptionTB.Text;
                double price =       double.Parse(dishPriceTB.Text);
                int stock =          int.Parse(dishStockTB.Text);

                Dish editedDish;
                if (rowIndex >= 0)
                {
                    editedDish = DishList.GetDish()[rowIndex];
                    editedDish.Name =        name;
                    editedDish.Description = description;
                    editedDish.Price =       price;
                    editedDish.Stock =       stock;
                }
                else
                {
                    editedDish = new Dish(name, description, price, stock);
                }
                if (pictureBox2.Tag != null)
                {
                    editedDish.ImagePath = pictureBox2.Tag.ToString();
                }

                if (rowIndex >= 0)
                {
                    DishList.EditDish(rowIndex, editedDish);
                    MessageBox.Show("Dish edited successfully!");
                }
                else
                {
                    DishList.AddDish(editedDish);
                    MessageBox.Show("Dish created successfully!");
                }

                DishList.SaveToCSV("dishes.csv");
                parentForm.RefreshDataGridView();
                LoadDishImage(editedDish.ImagePath);
                this.Close();
            }
        }

        private bool TextBoxesFilledAndValid()
        {
            bool nameValid =        !string.IsNullOrWhiteSpace(dishNameTB.Text);
            bool descriptionValid = !string.IsNullOrWhiteSpace(dishDescriptionTB.Text);
            bool priceValid =       !string.IsNullOrWhiteSpace(dishPriceTB.Text);
            bool stockValid =       !string.IsNullOrWhiteSpace(dishStockTB.Text);


            if (!nameValid || !descriptionValid || !priceValid || !stockValid)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidDouble(dishPriceTB.Text))
            {
                MessageBox.Show("Invalid price. Please enter a valid positive numerica value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidInt(dishStockTB.Text))
            {
                MessageBox.Show("Invalid stock. Please enter a valid positive numeric value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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

        private bool IsValidDouble(string input)
        {
            if (double.TryParse(input, out double result) && result >= 0)
            {
                return true;
            }
            return false;
        }

        private void dishIS_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imageName = Guid.NewGuid().ToString() + Path.GetExtension(openFileDialog.FileName);
                    string imageDestinationPath = Path.Combine(Program.ProjectDirectory, "imageFiles", imageName);

                    File.Copy(openFileDialog.FileName, imageDestinationPath, true);

                    pictureBox2.Image = Image.FromFile(imageDestinationPath);

                    pictureBox2.Tag = imageDestinationPath;
                    LoadDishImage(imageDestinationPath);

                }
            }
        }

        private void LoadDishImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox2.Image = Image.FromFile(imagePath);
                }
            }
            else
            {
                pictureBox2.Image = null;
            }
        }
    }
}
