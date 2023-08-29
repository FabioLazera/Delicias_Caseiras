using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Delivery
    {
        private string _deliveryAddress;
        private DateTime _deliveryForecast;

        public Delivery(string deliveryAddress, DateTime deliveryForecast)
        {
            _deliveryAddress = deliveryAddress;
            _deliveryForecast = deliveryForecast;
        }

        public string DeliveryAddress
        {
            get { return _deliveryAddress; }
            set { _deliveryAddress = value; }
        }

        public DateTime DeliveryForecast
        {
            get { return _deliveryForecast; }
            set { _deliveryForecast = value; }
        }
    }
}