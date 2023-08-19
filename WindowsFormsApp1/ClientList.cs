using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

        public static void SaveToCSV(string fileName)
        {
            string folderPath = Path.Combine(Program.ProjectDirectory, "csvFiles");
            string fullPath = Path.Combine(folderPath, fileName);
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (Client client in clients)
                {
                    writer.WriteLine($"{client.Name},{client.Phone_Number},{client.Address},{client.NIF}");
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
                        if (parts.Length == 4)
                        {
                            string name = parts[0];
                            string phoneNumber = parts[1];
                            string address = parts[2];
                            long nif = Convert.ToInt32(parts[3]);
                            Client newClient = new Client(name, phoneNumber, address, nif);
                            clients.Add(newClient);
                        }
                    }
                }
            }
        }
    }
}
