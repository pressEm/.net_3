using System;
using System.Collections.Generic;
using System.Linq;

namespace net_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose action:\n1)Create test data.\n2)Create new tariff.\n3)Create new client and connect.\n4)Print all tariffs.\n5)Print all clients.\n6)Print clients by tarif...\n7)Sort tariffs.\n8)Choose tariffs...\n_______________________________________");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 0) break;
                switch (i)
                {
                    case 1:
                        test();
                        break;
                    case 2:
                        Console.WriteLine("Input {cost internet minutes} of tariff: ");
                        int[] t = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                        TariffService.addTariff(t[0], t[1], t[2]);
                        break;
                    case 3:
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Number: ");
                        long num = Int64.Parse(Console.ReadLine());
                        Client c = new Client(name, num);
                        ClientService.addClient(c);
                        TariffService.printTariffs();
                        Console.WriteLine("Enter tariff id you want to connect: ");
                        int id = Int32.Parse(Console.ReadLine());
                        TariffService.getTariff(id).connect(c);
                        break;
                    case 4:
                        TariffService.printTariffs();
                        break;
                    case 5:
                        ClientService.printAllClients();
                        break;
                    case 6:
                        Console.WriteLine("Enter tariff id");
                        int tID = Int32.Parse(Console.ReadLine());
                        foreach(Client client in TariffService.getTariff(tID).getClients())
                        {
                            Console.WriteLine(client);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Sorted tarifs:");
                        TariffService.getTariffs().Sort();
                        TariffService.printTariffs();
                        break;
                    case 8:
                        Console.WriteLine("1 - cost; 2 - internet");
                        int j = Int32.Parse(Console.ReadLine());
                        switch (j)
                        {
                            case 1:
                                Console.WriteLine("Input cost");
                                TariffService.sortByCost(Int32.Parse(Console.ReadLine()));

                                break;
                            case 2:
                                Console.WriteLine("Input internet");
                                TariffService.sortByInternet(Int32.Parse(Console.ReadLine()));
                                break;
                        }
                        break;
                }
            }
        }

        private static void test()
        {
           Console.WriteLine("Hello World!");

           List<Tariff> tariffs = TariffService.createListTariff();

           List<Client> clients = ClientService.createClientsList();

           Console.WriteLine("List of tarifs: ");
           TariffService.printTariffs();
           TariffService.getTariffs().Sort();
           Console.WriteLine("Sorted list of tarifs: ");
           TariffService.printTariffs();

           ClientService.printAllClients();

           tariffs[0].connect(clients[0]);
           tariffs[1].connect(clients[1]);

           Console.WriteLine("Count all clients: " + TariffService.getCountAllClients());

           clients[0].pay();

           ClientService.addClient("Valentina", 89529562886);
           ClientService.printAllClients();

           TariffService.addTariff(1000, 1000, 100);
           TariffService.printTariffs();

           TariffService.sortByCost(500);
           TariffService.sortByInternet(100);
        }
    }
}
