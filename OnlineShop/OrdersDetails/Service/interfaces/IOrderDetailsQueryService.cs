using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.OrdersDetails.Service.interfaces
{
    public interface IOrderDetailsQueryService
    {

        List<OrderDetalis> getAllOrdersDetails();

        List<OrderDetalis> getMyOrdersDetails(int idUser);

        OrderDetalis getById(int id);

        OrderDetalis getByIdUserPro(int idUser, int idPro);

        List<int> getByIdOrders(int idUser);
    }
}
