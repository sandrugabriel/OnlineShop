using OnlineShop.Favourites.Models;
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

        int pozFavourite(int id);

        void stergere(int id);

        void deleteCard(Favourite favourite);

        void load();

        string Path();

        int pozProduct(int id, int idProduct);

    }
}
