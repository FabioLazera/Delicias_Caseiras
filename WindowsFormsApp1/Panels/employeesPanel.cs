﻿using System;
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
            searchTB.TextChanged += searchTB_TextChanged;
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
            foreach (Employee employee in EmployeeList.GetEmployees())
            {
                employeesGrid.Rows.Add(employee.Name, employee.Age, employee.PhoneNumber, employee.Address, employee.Salary, employee.Job);
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text.Trim().ToLower();

            employeesGrid.Rows.Clear();

            foreach (Employee employee in EmployeeList.GetEmployees())
            {
                if (employee.Name.ToLower().StartsWith(searchValue))
                {
                    employeesGrid.Rows.Add(employee.Name, employee.Age, employee.PhoneNumber, employee.Address, employee.Salary, employee.Job);
                }
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
                        addEmployeePanel addEmployeesPanel = new addEmployeePanel(this, rowIndex);
                        addEmployeesPanel.ShowDialog();
                        RefreshDataGridView();
                    }
                    else if (imageColumn.Name == "gridDelete")
                    {
                        DialogResult result = MessageBox.Show("Do you want to remove the employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            EmployeeList.DeleteEmployee(rowIndex);
                            RefreshDataGridView();
                        }
                    }
                }
            }
        }
    }
}
