using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Orders.Service
{
    interface IOrderQueryService
    {

        List<Order> getAllOrders();

        List<Order> getMyOrders(int idClient);

        Order getById(int id);


    }
}
