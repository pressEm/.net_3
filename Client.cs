using System;
using System.Collections.Generic;
using System.Text;

namespace net_3
{
    class Client
    {
        string name;
        long number;
        Tariff t;
        public Client(string name, long number)
        {
            this.name = name;
            this.number = number;
        }
        public string getName()
        {
            return this.name;
        }
        public long getNumber()
        {
            return this.number;
        }
        public void setTariff(Tariff t)
        {
            this.t = t;
        }
        public void pay()
        {
            if (t != null)
            {
                Console.WriteLine("Pay " + t.getCost() + " by " + this.name);
               
            }
        }
        public override string ToString()
        {
            return this.getName() + " - " + this.getNumber() + "; ";
        }

    }
}
