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
        private string _clientName;
        private string _status;
        private string _orderType;
        private DateTime _orderTime;
        private DateTime _nextStage;
        private double _amount;
        private Delivery _delivery;

        public Order (int id,string clientName, string status, string orderType, DateTime orderTime, DateTime nextStage,  double amount)
        {
            _id = id;
            _clientName = clientName;
            _status = status;
            _orderType = orderType;
            _orderTime = orderTime;
            _nextStage = nextStage;
            _amount = amount;
        }

        public Order(int id, string clientName, string status, string orderType, DateTime orderTime, DateTime nextStage, double amount, Delivery delivery)
        {
            _id = id;
            _clientName = clientName;
            _status = status;
            _orderType = orderType;
            _orderTime = orderTime;
            _nextStage = nextStage;
            _amount = amount;
            _delivery = delivery;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ClientName
        {
            get { return _clientName; }
            set { _clientName = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
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

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public Delivery Delivery
        {
            get { return _delivery;}
            set { _delivery = value; }
        }
    }
}

