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

        void deleteCard(OrderDetalis order);

        void setQuantity(int idUser, int idProduct, int quantity);

        void update();

        int pozOrderDetails(int id);

        void stergere(int id);

        void save(List<OrderDetalis> orderDetalis);

    }
}
