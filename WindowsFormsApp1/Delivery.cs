using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Delivery : Order
    {
        public string Address { get; set; }
        public DateTime Date { get; set; }

        public Delivery (string status, string address, DateTime date) : base(status)
        {
            Address = address;
            Date = date;
        }
    }
}
