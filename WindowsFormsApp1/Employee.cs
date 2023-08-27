using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Employee
    {
        private string _name;
        private int _age;
        private string _phone_number;
        private int _nif;
        private string _password;
        private string _address;
        private double _salary;
        private string _job;

        public Employee(string name, int age, string phone_number, int nif, string password, string address, double salary, string job)
        {
            _name = name;
            _age = age;
            _phone_number = phone_number;
            _nif = nif;
            _password = password;
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

        public int Nif
        {
            get { return _nif; }
            set { _nif = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
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
