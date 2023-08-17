using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class EmployeeList
    {
        private static List<Employee> employees = new List<Employee>();

        public static void AddEmployee(Employee employee)
        {
       
            employees.Add(employee);
        }

        public static List<Employee> GetEmployees()
        {
            return employees;
        }

        public static void EditEmployee(int index, Employee newEmployeeData)
        {
            if (index >= 0 && index < employees.Count)
            {
                employees[index] = newEmployeeData;
            }
        }

        public static void DeleteEmployee(int index)
        {
            if (index >= 0 && index < employees.Count)
            {
                employees.RemoveAt(index);
            }
        }
    }
}
