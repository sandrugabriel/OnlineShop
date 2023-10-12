using OnlineShop.Favourites.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Favourites.Service
{
    public class FavouriteComandServiceSingleton
    {

        private static readonly Lazy<IFavouriteComandService> _instance = new Lazy<IFavouriteComandService>(() => new FavouriteComandService());

        public static IFavouriteComandService Instance => _instance.Value;

        private FavouriteComandServiceSingleton() { }
    }
}
