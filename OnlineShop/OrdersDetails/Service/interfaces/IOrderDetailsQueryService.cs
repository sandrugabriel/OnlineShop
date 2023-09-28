using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.OrdersDetails.Service.interfaces
{
    interface IOrderDetailsQueryService
    {

        List<OrderDetalis> getAllOrdersDetails();

        List<OrderDetalis> getMyOrdersDetails(int idUser);

        OrderDetalis getById(int id);


    }
}
