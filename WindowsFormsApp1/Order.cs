using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Order
    {
        private String Status { get; set; }

        public Order (String status)
        {
            Status = status;
        }
    }
}
