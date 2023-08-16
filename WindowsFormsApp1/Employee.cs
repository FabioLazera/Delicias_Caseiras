using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Employee
    {
        private static List<Employee> employees = new List<Employee>();

        private string _name;
        private int _age;
        private string _phone_number;
        private string _address;
        private double _salary;
        private string _job;

        public Employee(string name, int age, string phone_number, string address, double salary, string job)
        {
            _name = name;
            _age = age;
            _phone_number = phone_number;
            _address = address;
            _salary = salary;
            _job = job;
        }

        public string Name
        {
            get { return _name;  }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age;  }
            set { _age = value; }
        }

        public string PhoneNumber
        { 
            get { return _phone_number;  }   
            set { _phone_number = value; }
        }

        public string Address
        {
            get { return _address; }
            set {_address = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set {_salary = value; }
        }

        public string Job
        {
            get { return _job;  }
            set { _job = value; }
        }

    }
}
