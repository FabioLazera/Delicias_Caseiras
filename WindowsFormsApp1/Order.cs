using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public class Order
    {
        private int _id;
        private string _orderType;
        private DateTime _orderTime;
        private DateTime _readyForDelivery;
        private string _status;
        private Delivery _delivery;

        public Order (int id, string orderType, DateTime orderTime, DateTime readyForDelivery, string status)
        {
            _id = id;
            _orderType = orderType;
            _orderTime = orderTime;
            _readyForDelivery = readyForDelivery;
            _status = status;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string OrderType
        {
            get { return _orderType; }
            set { _orderType = value; }
        }

        public DateTime OrderTime
        {
            get { return _orderTime; }
            set { _orderTime = value; }
        }

        public DateTime ReadyForDelivery
        {
            get { return _readyForDelivery; }
            set { _readyForDelivery = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Delivery Delivery
        {
            get { return _delivery; }
            set { _delivery = value; }
        }
    }
}

