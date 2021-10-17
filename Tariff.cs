using System;
using System.Collections.Generic;
using System.Text;

namespace net_3
{
    abstract class Tariff : ITariff, IComparable<Tariff>
    {
        List<Client> clients = new List<Client>();

        private int Cost { get; set; }
        int id;
        private int Internet { get; set; }
        private int Minutes { get; set; }

        public int CompareTo(Tariff p)
        {
            return this.Cost.CompareTo(p.Cost);
        }

        public Tariff(int cost, int internet, int minutes)
        {
            id = TariffService.getCountAllTariffs();
            Cost = cost;
            Internet = internet;
            Minutes = minutes;
        }

        public void connect(Client client)
        {
            Console.WriteLine("Connect " + client.getName() + " to " + this.getID()+ "...");
            clients.Add(client);
            client.setTariff(this);

        }

        public void disable(Client client)
        {
            Console.WriteLine("Disable... " + client.getName());
            clients.Remove(client);
        }

        public int getCost()
        {
            return this.Cost;
        }
        public int getID()
        {
            return this.id;
        }
        public int getInternet()
        {
            return this.Internet;
        }


        public int getCountClients()
        {
            return clients.Count;
        }
        public List<Client> getClients()
        {
            return clients;
        }
        public void printClients()
        {
            Console.WriteLine("All clients: ");
            foreach (Client c in clients)
            {
                Console.Write(c.getName() + " - " + c.getNumber() + "; ");
            }
            Console.WriteLine();
        }
    }
}
