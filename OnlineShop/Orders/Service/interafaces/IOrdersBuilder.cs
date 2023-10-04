using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Orders.Service.interafaces
{
    public interface IOrdersBuilder
    {

        Order Id(int id);
        Order Price(double price);
        Order IdUser(int id);
        Order IdProducts(List<int> ids);

        static Order Build()
        {
            return new Order();
        }
    }
}
