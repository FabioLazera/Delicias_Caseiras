using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ClientList
    {
        private static List<Client> clients = new List<Client>();

        public static void AddClient(Client client)
        {

            clients.Add(client);
        }

        public static List<Client> GetClients()
        {
            return clients;
        }

        public static void EditClient(int index, Client newClientData)
        {
            if (index >= 0 && index < clients.Count)
            {
                clients[index] = newClientData;
            }
        }

        public static void DeleteClient(int index)
        {
            if (index >= 0 && index < clients.Count)
            {
                clients.RemoveAt(index);
            }
        }
    }
}
