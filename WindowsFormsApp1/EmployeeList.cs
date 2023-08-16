using System;
using System.Collections.Generic;
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
    }
}
