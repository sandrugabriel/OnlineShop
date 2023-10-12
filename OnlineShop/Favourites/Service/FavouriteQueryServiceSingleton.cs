using OnlineShop.Users.Service.interfaces;
using OnlineShop.Users.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Favourites.Service.interfaces;

namespace OnlineShop.Favourites.Service
{
    public class FavouriteQueryServiceSingleton
    {

        private static readonly Lazy<IFavouriteQueryService> _instance = new Lazy<IFavouriteQueryService>(() => new FavouriteQueryService());

        public static IFavouriteQueryService Instance => _instance.Value;

        private FavouriteQueryServiceSingleton() { }
    }
}
