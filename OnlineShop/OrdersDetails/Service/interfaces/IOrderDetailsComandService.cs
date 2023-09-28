using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.OrdersDetails.Service.interfaces
{
    public interface IOrderDetailsComandService
    {

        int generareIdOrder();

        void saveFisier(string text);

        string Path();

        void load();


    }
}
