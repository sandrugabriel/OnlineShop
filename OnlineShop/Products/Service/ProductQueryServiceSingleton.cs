using OnlineShop.Models;
using OnlineShop.Products.Service.interfaces;
using OnlineShop.Users.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Products.Service
{
    public class ProductQueryServiceSingleton
    {

        private static readonly Lazy<IProductQueryService> _instance = new Lazy<IProductQueryService>(() => new ProductQueryService());

        public static IProductQueryService Instance => _instance.Value;

        private ProductQueryServiceSingleton() { }

    }
}
