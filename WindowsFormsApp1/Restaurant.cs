using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Restaurant
    {
        private static List<Order> orders = new List<Order>();
        private static int nextOrderId = 1;

        public static void AddOrder(Order order)
        {
            order.ID = nextOrderId;
            nextOrderId++;
            orders.Add(order);
        }

        public static List<Order> GetOrders()
        {
            return orders;
        }

        public static Order GetOrdersById(int Id)
        {

            foreach (Order order in orders)
            {
                if (order.ID == Id)
                {
                    return order;
                }
            }
            return null;
        }

        public static int GetNextOrderId()
        {
            return nextOrderId;
        }

        public static void SaveToCSV(string fileName)
        {
            string folderPath = Path.Combine(Program.ProjectDirectory, "csvFiles");
            string fullPath = Path.Combine(folderPath, fileName);
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (Order order in orders)
                {
                    string formattedAmount = string.Format(CultureInfo.InvariantCulture, "{0:0.00}", order.Amount);
                    string formattedDeliveryForecast = order.Delivery != null ? order.Delivery.DeliveryForecast.ToString("dd/MM/yyyy HH:mm:ss") : "";
                    string formattedLine;

                    if (order.Delivery == null)
                    {
                        formattedLine = $"{order.ID};{order.ClientName};{order.OrderType};{order.OrderTime.ToString("dd/MM/yyyy HH:mm:ss")};{order.NextStage.ToString("dd/MM/yyyy HH:mm:ss")};{order.Status};{formattedAmount}";
                    }
                    else
                    {
                        formattedLine = $"{order.ID};{order.ClientName};{order.OrderType};{order.OrderTime.ToString("dd/MM/yyyy HH:mm:ss")};{order.NextStage.ToString("dd/MM/yyyy HH:mm:ss")};{order.Status};{formattedAmount};{order.Delivery.DeliveryAddress};{formattedDeliveryForecast}";
                    }

                    writer.WriteLine(formattedLine);
                }
            }
        }

        public static void LoadFromCSV(string fileName)
        {
            string fullPath = Path.Combine(Program.ProjectDirectory, "csvFiles", fileName);

            if (File.Exists(fullPath))
            {
                using (StreamReader reader = new StreamReader(fullPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        
                        string[] parts = line.Split(';');
                        if (parts.Length == 7)
                        {
                            int id = Convert.ToInt32(parts[0]);
                            string clienteName = parts[1];
                            string status = Convert.ToString(parts[5]);
                            string orderType = parts[2];
                            DateTime orderTime = ConvertStrToDT(parts[3]);
                            DateTime nextStage = ConvertStrToDT(parts[4]);
                            double amount = Convert.ToDouble(parts[6], CultureInfo.InvariantCulture);

                            Order newOrder = new Order(id, clienteName, status, orderType, orderTime, nextStage, amount);
                            orders.Add(newOrder);
                        }
                        else if (parts.Length == 9)
                        {
                            int id = Convert.ToInt32(parts[0]);
                            string clienteName = parts[1];
                            string status = Convert.ToString(parts[5]);
                            string orderType = parts[2];
                            DateTime orderTime = ConvertStrToDT(parts[3]);
                            DateTime nextStage = ConvertStrToDT(parts[4]);
                            double amount = Convert.ToDouble(parts[6], CultureInfo.InvariantCulture);

                            string deliveryAddress = parts[7];
                            DateTime deliveryForecast = ConvertStrToDT(parts[8]);
                            Delivery delivery = new Delivery(deliveryAddress, deliveryForecast);

                            Order newOrder = new Order(id, clienteName, status, orderType, orderTime, nextStage, amount, delivery);
                            orders.Add(newOrder);
                        }
                    }
                }
            }
        }

        public static void DeleteOrder(int Id)
        {
            Order remove = null;
            foreach (Order order in orders)
            {
                if (order.ID == Id)
                {
                    remove = order;
                }
            }
            orders.Remove(remove);
            RecalculateNextOrderId();
        }

        public static DateTime ConvertStrToDT(string dateString)
        {
            DateTime result;
            if (DateTime.TryParseExact(dateString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException("Invalid Date String Format", nameof(dateString));
            }
        }

        public static void LoadOrderIfIsNeeded()
        {
            if (orders.Count == 0)
            {
                LoadFromCSV("orders.csv");
                RecalculateNextOrderId();

            }
        }

        private static void RecalculateNextOrderId()
        {
            nextOrderId = orders.Count > 0 ? orders.Max(order => order.ID) + 1 : 1;
        }
    }
}
