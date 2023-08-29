﻿using System;
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
                    writer.WriteLine($"{employee.Name}|{employee.Age}|{employee.PhoneNumber}|{employee.Nif}|{employee.Password}|{employee.Address}|{employee.Salary}|{employee.Job}");
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
                        string[] parts = line.Split('|');
                        if (parts.Length == 8)
                        {
                            string name = parts[0];
                            int age = Convert.ToInt32(parts[1]);
                            string phoneNumber = parts[2];
                            int nif = Convert.ToInt32(parts[3]);
                            string password = parts[4];
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
    }
}
