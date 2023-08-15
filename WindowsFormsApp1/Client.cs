using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Client //: Order
    {
        private string _name;
        private string _phone_number;
        private string _address;
        private long _nIF;

        public Client(string name, string phone_number, string address, long nIF)
        {
            _name = name;
            _phone_number = phone_number;
            _address = address;
            _nIF = nIF;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Phone_Number
        {
            get { return _phone_number; }
            set { _phone_number = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public long NIF
        {
            get { return _nIF; }
            set{  _nIF = value; }
        }
    }
}
