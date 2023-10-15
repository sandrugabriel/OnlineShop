using OnlineShop.Products.Service.interfaces;
using OnlineShop.Products.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Users.Service.interfaces;

namespace OnlineShop.Users.Service
{
    public class UserComandServiceSingleton
    {

        private static readonly Lazy<IUserComandService> _instance = new Lazy<IUserComandService>(() => new UserComandService());

        public static IUserComandService Instance => _instance.Value;

        private UserComandServiceSingleton() { }
    }
}
