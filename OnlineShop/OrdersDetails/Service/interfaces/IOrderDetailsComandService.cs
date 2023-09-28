using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.OrdersDetails.Service.interfaces
{
    interface IOrderDetailsComandService
    {

        int generareIdOrder();

        void saveFisier(string text);

        void load();

    }
}
