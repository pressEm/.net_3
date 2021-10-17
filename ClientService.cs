using System;
using System.Collections.Generic;
using System.Text;

namespace net_3
{
    static class ClientService
    {
        private static List<Client> clients = new List<Client>();
        public static List<Client> createClientsList()
        {
            Console.WriteLine("Creating standart clients... ");
            Client c1 = new Client("Tom", 89529562882);
            Client c2 = new Client("Alex", 89529562883);
            Client c3 = new Client("Dima", 89529562884);
            Client c4 = new Client("Misha", 89529562885);
            clients = new List<Client>();
            clients.Add(c1);
            clients.Add(c2);
            clients.Add(c3);
            clients.Add(c4);
            return clients;
        }

        public static void printAllClients()
        {
            Console.WriteLine("All clients: ");
            foreach (Client c in clients)
            {
                Console.WriteLine(c);
                //Console.WriteLine(c.getName());
            }
            Console.WriteLine("_____________________________________");
        }

        public static Client getClient(long num)
        {
            foreach (Client c in clients)
            {
                if (c.getNumber() == num)
                {
                    return c;
                }
            }
            return null;
        }

        public static void addClient(string name, long num)
        {
            Console.WriteLine("Add new client " + name);
            clients.Add(new Client(name, num));
        }
        public static void addClient(Client c)
        {
            Console.WriteLine("Add new client " + c.getName());
            clients.Add(c);
        }
    }
}
