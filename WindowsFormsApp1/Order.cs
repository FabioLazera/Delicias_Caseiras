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
        private DateTime _nextStage;
        private string _status;
        private Delivery _delivery;

        public Order (int id, string orderType, DateTime orderTime, DateTime nextStage, string status)
        {
            _id = id;
            _orderType = orderType;
            _orderTime = orderTime;
            _nextStage = nextStage;
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

        public DateTime NextStage
        {
            get { return _nextStage; }
            set { _nextStage = value; }
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

