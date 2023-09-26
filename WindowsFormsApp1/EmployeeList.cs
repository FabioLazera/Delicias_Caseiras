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

        public static void SaveToCSV(string fileName)
        {
            string folderPath = Path.Combine(Program.ProjectDirectory, "csvFiles");
            string fullPath = Path.Combine(folderPath, fileName);
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (Employee employee in employees)
                {
                    string password = EncryptPassword(employee.Password, 150);
                    writer.WriteLine($"{employee.Name};{employee.Age};{employee.PhoneNumber};{employee.Nif};{password};{employee.Address};{employee.Salary};{employee.Job}");
                }
            }
        }

        public static void LoadFromCSV(string fileName)
        {
            string fullPath = Path.Combine(Program.ProjectDirectory, "csvFiles", fileName);
            if (File.Exists(fullPath))
            {
                using (StreamReader reader = new StreamReader(fullPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        string password = EncryptPassword(parts[4], 150);
                        if (parts.Length == 8)
                        {
                            string name = parts[0];
                            int age = Convert.ToInt32(parts[1]);
                            string phoneNumber = parts[2];
                            int nif = Convert.ToInt32(parts[3]);
                            password = parts[4];
                            string address = parts[5];
                            double salary = Convert.ToDouble(parts[6]);
                            string job = parts[7];
                            Employee newEmployee = new Employee(name, age, phoneNumber, nif, password, address, salary, job);
                            employees.Add(newEmployee);
                        }
                    }
                }
            }
        }

        public static void LoadEmployeeIfNeeded()
        {
            if (employees.Count == 0)
            {
                LoadFromCSV("employees.csv");
            }
        }

        public static bool IfNifExists(string nif)
        {
            long myNif = long.Parse(nif);
            bool flag = false;

            foreach (Employee emp in employees)
            {
                if (emp.Nif == myNif)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public static bool IfNifExistsIndex(string nif, int MyIndex)
        {
            long myNif = long.Parse(nif);
            bool flag = false;

            for (int i = 0; i < employees.Count; i++)
            {
                if (i != MyIndex && employees[i].Nif == myNif)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public static bool IfContactExists(string contact)
        {
            bool flag = false;

            foreach (Employee emp in employees)
            {
                if (emp.PhoneNumber == contact)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public static bool IfContactExistsIndex(string contact, int MyIndex)
        {
            bool flag = false;

            for (int i = 0; i < employees.Count; i++)
            {
                if (i != MyIndex && employees[i].PhoneNumber == contact)
                {
                    flag = true;
                    break; 
                }
            }
            return flag;
        }
        public static string EncryptPassword(string password, int leap)

        {
            char[] chars = password.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    char baseChar = char.IsLower(chars[i]) ? 'a' : 'A';
                    chars[i] = (char)(baseChar + (chars[i] - baseChar + leap) % 26);
                }
                else if (char.IsDigit(chars[i]))
                {
                    chars[i] = (char)((chars[i] - '0' + leap) % 10 + '0');
                }
            }
            return new string(chars);
        }
    }
}
