using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loginPanel : Form
    {
        public loginPanel()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            int enteredNif;
            if (int.TryParse(nifTB.Text, out enteredNif))
            {
                string enteredPassword = EmployeeList.EncryptPassword(passwordTB.Text);
                EmployeeList.LoadFromCSV("employees.csv");
                Employee matchingEmployee = EmployeeList.GetEmployees().FirstOrDefault(employee => employee.Nif == enteredNif && employee.Password == enteredPassword);

                if (matchingEmployee != null)
                {
                    Menu menuForm = new Menu();

                    if (matchingEmployee.Job == "Manager")
                    {
                        menuForm.EnableAllButtons();
                    }
                    else
                    {
                        menuForm.EnableSomeButtons();
                    }

                    menuForm.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Wrong NIF or password! Try again", "Incorrect access credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void view_Click(object sender, EventArgs e)
        {
            passwordTB.UseSystemPasswordChar = true;
        }

        private void hidden_Click(object sender, EventArgs e)
        {
            passwordTB.UseSystemPasswordChar = false;
        }
    }
}
