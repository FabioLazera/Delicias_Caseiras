using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1.Panels
{
    public partial class addEmployeePanel : Form
    {
        private employeesPanel parentForm;
        private int rowIndex;

        public addEmployeePanel(employeesPanel parent, int index = -1)
        {
            InitializeComponent();
            CenterFormOnScreen();
            this.parentForm = parent;
            this.rowIndex =   index;
            // If editing an existing employee, populate the form fields with their data.
            if (index >= 0)
            {
                Employee employee = EmployeeList.GetEmployees()[index];
                eNameTB.Text =      employee.Name;
                eAgeTB.Text =       employee.Age.ToString();
                ePNTB.Text =        employee.PhoneNumber;
                eNTB.Text =         employee.Nif.ToString();
                eAddressTB.Text =   employee.Address;
                eSalaryTB.Text =    employee.Salary.ToString();
                eJobTB.Text =       employee.Job;
                string mypassword = employee.Password;
                ePTB.Text = EmployeeList.DecryptPassword(mypassword);
            }
        }

        private void CenterFormOnScreen()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Check if the text boxes are filled and valid before saving employee information.
            if (TextBoxesFilledAndValid())
            {
                string name =        eNameTB.Text;
                int age =            int.Parse(eAgeTB.Text);
                string phoneNumber = ePNTB.Text;
                int nif =            int.Parse(eNTB.Text);
                string password =    ePTB.Text;
                string address =     eAddressTB.Text;
                double salary =      double.Parse(eSalaryTB.Text);
                string job =         eJobTB.Text;

                if (rowIndex >= 0)
                {
                    string EncryptPassword = EmployeeList.EncryptPassword(password);
                    Employee editedEmployee = new Employee(name, age, phoneNumber, nif, EncryptPassword, address, salary, job);
                    EmployeeList.EditEmployee(rowIndex, editedEmployee);
                    EmployeeList.SaveToCSV("employees.csv");
                    MessageBox.Show("Employee edited successfully!");
                }
                else
                {
                    string EncryptPassword = EmployeeList.EncryptPassword(password);
                    Employee newEmployee = new Employee(name, age, phoneNumber, nif, EncryptPassword, address, salary, job);
                    EmployeeList.AddEmployee(newEmployee);
                    EmployeeList.SaveToCSV("employees.csv");
                    MessageBox.Show("Employee created successfully!");
                }

                parentForm.RefreshDataGridView();
                this.Close();
            }
        }

        private bool TextBoxesFilledAndValid()
        {
            // Check if all text boxes are filled and contain valid data.
            bool nameValid =     !string.IsNullOrWhiteSpace(eNameTB.Text) && !eNameTB.Text.Contains(";");
            bool ageValid =      !string.IsNullOrWhiteSpace(eAgeTB.Text) && !eAgeTB.Text.Contains(";"); 
            bool phoneValid =    !string.IsNullOrWhiteSpace(ePNTB.Text) && !ePNTB.Text.Contains(";");
            bool nifValid =      !string.IsNullOrWhiteSpace(eNTB.Text) && !eNTB.Text.Contains(";");
            bool passwordValid = !string.IsNullOrWhiteSpace(ePTB.Text) && !ePTB.Text.Contains(";");
            bool addressValid =  !string.IsNullOrWhiteSpace(eAddressTB.Text) && !eAddressTB.Text.Contains(";");
            bool salaryValid =   !string.IsNullOrWhiteSpace(eSalaryTB.Text) && !eSalaryTB.Text.Contains(";");
            bool jobValid =      !string.IsNullOrWhiteSpace(eJobTB.Text) && !eJobTB.Text.Contains(";");

            if (!nameValid || !ageValid || !phoneValid || !nifValid || !passwordValid || !jobValid || !salaryValid || !addressValid)
            {
                MessageBox.Show("Please fill in all fields and do not use semicolons.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidInt(eAgeTB.Text))
            {
                MessageBox.Show("Invalid age format. Please enter a valid numerical value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidDouble(eSalaryTB.Text))
            {
                MessageBox.Show("Invalid salary format. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidInt(eNTB.Text))
            {
                MessageBox.Show("Invalid NIF format. Please enter a valid numerical value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (rowIndex >= 0)
            {
                if (EmployeeList.IfNifExistsIndex(eNTB.Text, rowIndex) == true || ClientList.IfNifExistsIndex(eNTB.Text, rowIndex) == true)
                {
                    MessageBox.Show("NIF Alredy Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (EmployeeList.IfContactExistsIndex(ePNTB.Text, rowIndex) == true)
                {
                    MessageBox.Show("This phone alredy exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                if (EmployeeList.IfNifExists(eNTB.Text) == true || ClientList.IfNifExists(eNTB.Text) == true)
                {
                    MessageBox.Show("NIF alredy exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (EmployeeList.IfContactExists(ePNTB.Text) == true)
                {
                    MessageBox.Show("This Phone alredy exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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
    }
}
