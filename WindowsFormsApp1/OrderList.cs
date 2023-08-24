using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class OrderList
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
                    writer.WriteLine($"{order.ID},{order.ClientName},{order.OrderType},{order.OrderTime.ToString("dd/MM/yyyy HH:mm:ss")},{order.NextStage.ToString("dd/MM/yyyy HH:mm:ss")},{order.Status},{order.Amount}");
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
                        string[] parts = line.Split(',');
                        if (parts.Length == 7)
                        {
                            int id = Convert.ToInt32(parts[0]);
                            string clienteName = parts[1];
                            string status = Convert.ToString(parts[5]);
                            string orderType = parts[2];
                            DateTime orderTime = ConvertStrToDT(parts[3]);
                            DateTime nextStage = ConvertStrToDT(parts[4]);
                            double amount = Convert.ToDouble(parts[6]);

                            Order newOrder = new Order(id, clienteName, status, orderType, orderTime, nextStage, amount);
                            orders.Add(newOrder);
                        }
                    }
                }
            }
        }

        public static void DeleteOrder(int index)
        {
            if (index >= 0 && index < orders.Count)
            {
                orders.RemoveAt(index);
            }
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
                throw new ArgumentException("Invalid date string format", nameof(dateString));
            }
        }

        public static void LoadOrderIfIsNeeded()
        {
            if (orders.Count == 0)
            {
                LoadFromCSV("orders.csv");
            }
        }
    }
}
