using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Siticone.Desktop.UI.WinForms.Suite.ShadowForm;

namespace OnlineShop.Orders.Service
{
    public interface IOrderQueryService
    {

        List<Order> getAllOrders();

        List<Order> getMyOrders(int idClient);

        Order getById(int id);

        void save(List<Order> orders);

    }
}
