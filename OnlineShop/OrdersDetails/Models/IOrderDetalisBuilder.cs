using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.OrdersDetails.Service.interfaces
{
    public interface IOrderDetalisBuilder
    {

        OrderDetalis Id(int id);
        OrderDetalis IdUser(int idUser);
        OrderDetalis OrderAddress(string orderAddress);
        OrderDetalis OrderDate(DateTime orderDate);
        OrderDetalis IdProducts(List<int> ids);
        OrderDetalis Quantities(List<int> quantity);

    }

}
