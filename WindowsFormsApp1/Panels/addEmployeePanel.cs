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

        public addEmployeePanel(employeesPanel parent)
        {
            InitializeComponent();
            CenterFormOnScreen();
            this.parentForm = parent;
        }

        private void addEmployeePanel_Load(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;

            if (eNameTB.Text == "" || eAgeTB.Text == "" || ePNTB.Text == "" || eAddressTB.Text == "" || eSalaryTB.Text == "" || eJobTB.Text == "")
            {
                saveBtn.Enabled = false;
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
            if (TextBoxesFilledAndValid())
            {
                string name = eNameTB.Text;
                int age = int.Parse(eAgeTB.Text);
                string phoneNumber = ePNTB.Text;
                string address = eAddressTB.Text;
                double salary = double.Parse(eSalaryTB.Text);
                string job = eJobTB.Text;


                Employee newEmployee = new Employee(name, age, phoneNumber, address, salary, job);
                parentForm.AddEmployee(newEmployee);

                MessageBox.Show("Customer created successfully!");

                eNameTB.Clear();
                eAgeTB.Clear();
                ePNTB.Clear();
                eAddressTB.Clear();
                eSalaryTB.Clear();
                eJobTB.Clear();
            }
        }

        private bool TextBoxesFilledAndValid()
        {
            bool nameValid = !string.IsNullOrWhiteSpace(eNameTB.Text);
            bool ageValid = !string.IsNullOrWhiteSpace(eAgeTB.Text); 
            bool phoneValid = !string.IsNullOrWhiteSpace(ePNTB.Text);
            bool addressValid = !string.IsNullOrWhiteSpace(eAddressTB.Text);
            bool salaryValid = double.TryParse(eSalaryTB.Text, out double salary);
            bool jobValid = !string.IsNullOrWhiteSpace(eJobTB.Text);

            if (!nameValid || !ageValid || !phoneValid || !jobValid || !salaryValid || !addressValid)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            return true;
        }

        private bool IsValidInt(string input)
        {
            if (int.TryParse(input,out int result))
            {
                return true;
            }
            return false;
        }

        private bool IsValidDouble(string input)
        {
            if (double.TryParse(input, out double result))
            {
                return true;
            }
            return false;
        }
    }
}
