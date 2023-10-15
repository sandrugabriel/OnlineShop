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

        OrderDetalis IdProduct(int id);

        OrderDetalis Quantities(int quantity);

    }

}
