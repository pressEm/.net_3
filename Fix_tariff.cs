using System;
using System.Collections.Generic;
using System.Text;

namespace net_3
{
    class Fix_tariff : Tariff
    {
        private int id;
        private int Cost { get; set; }
        private int Internet { get; set; }
        private int Minutes { get; set; }

        public Fix_tariff(int cost, int internet, int minutes): base(cost, internet, minutes)
        {
            this.id = TariffService.getCountAllTariffs();
            this.Cost = cost;
            this.Internet = internet;
            this.Minutes = minutes;
        }

        public override string ToString()
        {
            return "ID: " + id + ") Cost: " + Cost + "; Internet: " + Internet + "; Minutes: " + Minutes;
        }
    }
}
