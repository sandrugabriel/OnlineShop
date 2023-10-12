using OnlineShop.Favourites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Favourites.Service.interfaces
{
    public interface IFavouriteQueryService
    {

        Favourite getById(int id);

        List<Favourite> getByIdClient(int idClient);

        Favourite getByIdUserPro(int idUser, int idProduct);
    }
}
