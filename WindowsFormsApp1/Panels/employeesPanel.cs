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
            // Set a specific format for the 6th column in the DataGridView.
            employeesGrid.Columns[6].DefaultCellStyle.Format = "0.00";
            if (EmployeeList.GetEmployees().Count == 0)
            {
                EmployeeList.LoadFromCSV("employees.csv");
            }
            RefreshDataGridView();
        }

        private void employeesPImg_Click(object sender, EventArgs e)
        {
            addEmployeePanel addEmployeePanel = new addEmployeePanel(this);
            addEmployeePanel.ShowDialog();
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            employeesGrid.Rows.Clear();
            // Display employee data while hiding sensitive information.
            foreach (Employee employee in EmployeeList.GetEmployees())
            {
                employeesGrid.Rows.Add(employee.Name, employee.Age, employee.PhoneNumber, employee.Nif,"******", employee.Address, employee.Salary, employee.Job);
            }
        }

        private void employeesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (employeesGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn imageColumn)
                {
                    int rowIndex = e.RowIndex;

                    if (imageColumn.Name == "gridEdit")
                    {
                        addEmployeePanel addEmployeePanel = new addEmployeePanel(this, rowIndex);
                        // If changes are saved in the child form, update and save the employee list.
                        if (addEmployeePanel.ShowDialog() == DialogResult.OK)
                        {
                            EmployeeList.SaveToCSV("employees.csv");
                            RefreshDataGridView();
                        }
                    }
                    else if (imageColumn.Name == "gridDelete")
                    {
                        DialogResult result = MessageBox.Show("Do you want to remove the employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            EmployeeList.DeleteEmployee(rowIndex);
                            EmployeeList.SaveToCSV("employees.csv");
                            RefreshDataGridView();
                        }
                    }
                }
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text.Trim().ToLower();

            employeesGrid.Rows.Clear();
            // Iterate through employees and add those whose names start with the search value to the DataGridView.
            foreach (Employee employee in EmployeeList.GetEmployees())
            {
                if (employee.Name.ToLower().StartsWith(searchValue))
                {
                    employeesGrid.Rows.Add(employee.Name, employee.Age, employee.PhoneNumber, employee.Nif, "******", employee.Address, employee.Salary, employee.Job);
                }
            }
        }
    }
}
