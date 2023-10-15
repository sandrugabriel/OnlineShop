using OnlineShop.Products.Service.interfaces;
using OnlineShop.Products.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.OrdersDetails.Service.interfaces;

namespace OnlineShop.OrdersDetails.Service
{
    public class OrderDetailsComandServiceSingleton
    {

        private static readonly Lazy<IOrderDetailsComandService> _instance = new Lazy<IOrderDetailsComandService>(() => new OrderDetailsComandService());

        public static IOrderDetailsComandService Instance => _instance.Value;

        private OrderDetailsComandServiceSingleton() { }
    }
}
