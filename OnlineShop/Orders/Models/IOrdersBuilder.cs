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
        Order Quantity(int q);
        Order IdUser(int id);
        Order Address(string address);
        Order Phone(string phone);
        Order Date(DateTime date);
    }
}
