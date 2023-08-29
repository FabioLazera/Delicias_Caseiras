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
    public partial class addDrinksPanel : Form
    {
        private drinksPanel parentForm;
        private int rowIndex;

        public addDrinksPanel(drinksPanel parent, int index = -1)
        {
            InitializeComponent();
            CenterFormOnScreen();
            this.parentForm = parent;
            this.rowIndex =   index;

            if (index >= 0)
            {
                Drink drink = DrinkList.GetDrinks()[index];
                drinkNameTB.Text =        drink.Name;
                drinkDescriptionTB.Text = drink.Description;
                drinkPriceTB.Text =       drink.Price.ToString();
                drinkStockTB.Text =       drink.Stock.ToString();
                LoadDrinkImage(drink.ImagePath);
            }
        }

        private void CenterFormOnScreen()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void drinkCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drinkSaveBtn_Click(object sender, EventArgs e)
        {
            if (TextBoxesFilledAndValid())
            {
                string name =        drinkNameTB.Text;
                string description = drinkDescriptionTB.Text;
                double price =       double.Parse(drinkPriceTB.Text);
                int stock =          int.Parse(drinkStockTB.Text);

                Drink editedDrink;
                if (rowIndex >= 0)
                {
                    editedDrink = DrinkList.GetDrinks()[rowIndex];
                    editedDrink.Name = name;
                    editedDrink.Description = description;
                    editedDrink.Price = price;
                    editedDrink.Stock = stock;
                }
                else
                {
                    editedDrink = new Drink(name, description, price, stock);
                }

                if (drinkImage.Tag != null)
                {
                    editedDrink.ImagePath = drinkImage.Tag.ToString();
         
                }

                if (rowIndex >= 0)
                {
                    DrinkList.EditDrink(rowIndex, editedDrink);
                    MessageBox.Show("Drink edited successfully!");
                }
                else
                {
                    DrinkList.AddDrink(editedDrink);
                    MessageBox.Show("Drink created successfully!");
                }

                DrinkList.SaveToCSV("drinks.csv");
                parentForm.RefreshDataGridView();
                LoadDrinkImage(editedDrink.ImagePath);
                this.Close();
            }
        }

        private bool TextBoxesFilledAndValid()
        {
            bool nameValid = !string.IsNullOrWhiteSpace(drinkNameTB.Text);
            bool descriptionValid = !string.IsNullOrWhiteSpace(drinkDescriptionTB.Text);
            bool priceValid = !string.IsNullOrWhiteSpace(drinkPriceTB.Text);
            bool stockValid = !string.IsNullOrWhiteSpace(drinkStockTB.Text);
            

            if (!nameValid || !descriptionValid || !priceValid || !stockValid)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidDouble(drinkPriceTB.Text))
            {
                MessageBox.Show("Invalid price. Please enter a valid positive numerica value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidInt(drinkStockTB.Text))
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

        private void imageSearchBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imageName = Guid.NewGuid().ToString() + Path.GetExtension(openFileDialog.FileName);
                    string imageDestinationPath = Path.Combine(Program.ProjectDirectory, "imageFiles", imageName);

                    File.Copy(openFileDialog.FileName, imageDestinationPath, true);

                    drinkImage.Image = Image.FromFile(imageDestinationPath);

                    drinkImage.Tag = imageDestinationPath;
                    LoadDrinkImage(imageDestinationPath);
                }
            }
        }

        private void LoadDrinkImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    drinkImage.Image = Image.FromFile(imagePath);
                }
            }
            else
            {
                drinkImage.Image = null;
            }
        }
    }
}
