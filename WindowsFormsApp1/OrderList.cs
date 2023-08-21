using System;
using System.Collections.Generic;
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

        // Outros métodos para editar, excluir, salvar em CSV, etc.

        public static int GetNextOrderId()
        {
            return nextOrderId;
        }
    }
}
