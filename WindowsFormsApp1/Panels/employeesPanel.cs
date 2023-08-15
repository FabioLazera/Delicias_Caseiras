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
        private List<Employee> employees = new List<Employee>();

        public employeesPanel()
        {
            InitializeComponent();
            searchTB.TextChanged += searchTB_TextChanged;
        }

        private void employeesPImg_Click(object sender, EventArgs e)
        {
            addEmployeePanel addEmployeePanel = new addEmployeePanel(this);
            addEmployeePanel.Show();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            employeesGrid.Rows.Clear();
            foreach (Employee employee in employees)
            {
                employeesGrid.Rows.Add(employee.Name, employee.Age, employee.PhoneNumber, employee.Address, employee.Salary, employee.Job);
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text.Trim().ToLower();

            employeesGrid.Rows.Clear();

            foreach (Employee employee in employees)
            {
                if (employee.Name.ToLower().StartsWith(searchValue))
                {
                    employeesGrid.Rows.Add(employee.Name, employee.Age, employee.PhoneNumber, employee.Address, employee.Salary, employee.Job);
                }
            }
        }
    }
}
