using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net_3
{
    static class TariffService
    {
        private static List<Tariff> Tariffs = new List<Tariff>();

        public static List<Client> getAllOperatorClients()
        {
            Console.WriteLine("All the operators clients: ");
            List<Client> clients = new List<Client>();
            foreach (Tariff t in Tariffs)
            {
                Console.WriteLine("id " + t.getID());
                foreach (Client c in t.getClients())
                {
                    clients.Add(c);
                    Console.Write(c.getName() + " - " + c.getNumber() + "; ");
                }
                Console.WriteLine();
            }
            return clients;
        }
        public static List<Tariff> createListTariff()
        {
            Console.WriteLine("Creating standart tariffs... ");
            Fix_tariff t1 = new Fix_tariff(299, 20, 20);
            Tariffs.Add(t1);
           
            Fix_tariff t2 = new Fix_tariff(600, 60, 60);
            Tariffs.Add(t2);
            
            Fix_tariff t3 = new Fix_tariff(400, 40, 40);
            Tariffs.Add(t3);
           
            return Tariffs;
        }

        public static void printTariffs()
        {
            Console.WriteLine("All tariffs: ");
            foreach (Tariff t in Tariffs)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("_____________________________________");
        }

        public static int getCountAllClients()
        {
            int count = 0;
            foreach(Tariff t in Tariffs)
            {
                count += t.getCountClients();
            }
            return count;
        }
        public static int getCountAllTariffs()
        {
            return Tariffs.Count;
        }

        public static List<Tariff> getTariffs()
        {
            return Tariffs;
        }

        public static Tariff getTariff(int id)
        {
            foreach (Tariff t in Tariffs)
            {
                if (t.getID() == id)
                {
                    return t;
                }
            }
            return null;
        }


        private static void addTariff(Tariff t)
        {
            Tariffs.Add(t);
        }

        public static void addTariff(int cost, int internet, int minutes)
        {
            Console.WriteLine("Add new tariff...");
            Tariffs.Add(new Fix_tariff(cost, internet, minutes));
        }

        public static void sortByCost(int cost)
        {
            Console.WriteLine(cost + " Search for a tariffs with cost < " + cost + ";");
            var selectedTariff = from tariff in Tariffs
                                 where tariff.getCost() < cost
                                 select tariff;
            foreach (Tariff tariff in selectedTariff)
                Console.WriteLine(tariff);

        }

        public static void sortByInternet(int internet)
        {
            Console.WriteLine("Search for a tariffs with intenet > " + internet + ";");
            var selectedTariff = from tariff in Tariffs
                                 where tariff.getInternet() > internet
                                 select tariff;
            foreach (Tariff tariff in selectedTariff)
                Console.WriteLine(tariff);

        }

    }
}
