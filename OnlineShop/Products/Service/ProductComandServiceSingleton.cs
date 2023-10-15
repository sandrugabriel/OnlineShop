using OnlineShop.Products.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Products.Service
{
    public class ProductComandServiceSingleton
    { 

        private static readonly Lazy<IProductComandService> _instance = new Lazy<IProductComandService>(() => new ProductComandService());

        public static IProductComandService Instance => _instance.Value;

        private ProductComandServiceSingleton() { }
    }
}
