using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Favourites.Service.interfaces
{
    public interface IFavouriteComandService
    {
        int generareId();

        void saveFisier(string text);

        void update();

        void load();

        string Path();

        int pozProduct(int id, int idProduct);

    }
}
