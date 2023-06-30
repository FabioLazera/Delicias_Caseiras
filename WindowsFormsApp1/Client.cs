using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Client : Order
    {
         public string Name { get; set; }
         public string Address { get; set; }
         public string Mobile_Number { get; set; }

      public Client(string status, string name, string address, string mobile_number) : base (status)
        {
            Name = name;
            Address = address;
            Mobile_Number = mobile_number;
        }
    }
}
