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
        private static List<Order> Rest1 = new List<Order>();
        private static int nextOrderId = 1;

        public static void AddOrder(Order order)
        {
            order.ID = nextOrderId;
            nextOrderId++;
            Rest1.Add(order);
        }

        public static List<Order> GetOrders()
        {
            return Rest1;
        }
        
        // Method to retrieve an order by its ID.
        public static Order GetOrdersById(int Id)
        {

            foreach (Order order in Rest1)
            {
                if (order.ID == Id)
                {
                    return order;
                }
            }
            return null;
        }

        // Method to get the next available order ID.
        public static int GetNextOrderId()
        {
            return nextOrderId;
        }

        public static void SaveToCSV(string fileName)
        {
            // Prepare the file path for saving the CSV file.
            string folderPath = Path.Combine(Program.ProjectDirectory, "csvFiles");
            string fullPath = Path.Combine(folderPath, fileName);
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (Order order in Rest1)
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
            // Prepare the full path for the CSV file.
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
                            // Parse order data from the CSV line for orders without delivery information.
                            int id = Convert.ToInt32(parts[0]);
                            string clienteName = parts[1];
                            string status = Convert.ToString(parts[5]);
                            string orderType = parts[2];
                            DateTime orderTime = ConvertStrToDT(parts[3]);
                            DateTime nextStage = ConvertStrToDT(parts[4]);
                            double amount = Convert.ToDouble(parts[6], CultureInfo.InvariantCulture);

                            // Create a new order and add it to the list.
                            Order newOrder = new Order(id, clienteName, status, orderType, orderTime, nextStage, amount);
                            Rest1.Add(newOrder);
                        }
                        else if (parts.Length == 9)
                        {
                            // Parse order data from the CSV line for orders with delivery information.
                            int id = Convert.ToInt32(parts[0]);
                            string clienteName = parts[1];
                            string status = Convert.ToString(parts[5]);
                            string orderType = parts[2];
                            DateTime orderTime = ConvertStrToDT(parts[3]);
                            DateTime nextStage = ConvertStrToDT(parts[4]);
                            double amount = Convert.ToDouble(parts[6], CultureInfo.InvariantCulture);
                            string deliveryAddress = parts[7];
                            DateTime deliveryForecast = ConvertStrToDT(parts[8]);

                            // Create a new order with delivery information and add it to the list.
                            Delivery delivery = new Delivery(deliveryAddress, deliveryForecast);
                            Order newOrder = new Order(id, clienteName, status, orderType, orderTime, nextStage, amount, delivery);
                            Rest1.Add(newOrder);
                        }
                    }
                }
            }
        }

        public static void DeleteOrder(int Id)
        {
            Order remove = null;
            foreach (Order order in Rest1)
            {
                if (order.ID == Id)
                {
                    remove = order;
                }
            }
            Rest1.Remove(remove);
            RecalculateNextOrderId();
        }

        // Method to convert a date string to a DateTime object using a specific format.
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

        // Method to load orders from CSV if needed, typically called when the application starts.
        public static void LoadOrderIfIsNeeded()
        {
            if (Rest1.Count == 0)
            {
                LoadFromCSV("orders.csv");
                RecalculateNextOrderId();
            }
        }

        // Private method to recalculate the next available order ID based on existing orders.
        private static void RecalculateNextOrderId()
        {
            nextOrderId = Rest1.Count > 0 ? Rest1.Max(order => order.ID) + 1 : 1;
        }
    }
}
