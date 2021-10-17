using System;
using System.Collections.Generic;
using System.Text;

namespace net_3
{
    interface ITariff
    {
        void connect(Client client);
        void disable(Client client);
        int getCountClients();
        int getCost();

    }
}

