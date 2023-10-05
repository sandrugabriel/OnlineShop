using OnlineShop.Users.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Users.Service
{
    public class UserQueryServiceSingleton
    {

        private static readonly Lazy<IUserQueryService> _instance = new Lazy<IUserQueryService>(() => new UserQueryservice());

        public static IUserQueryService Instance => _instance.Value;

        private UserQueryServiceSingleton() { }

    }
}
