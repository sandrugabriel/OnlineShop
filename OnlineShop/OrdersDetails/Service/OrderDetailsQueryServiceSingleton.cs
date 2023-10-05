using OnlineShop.OrdersDetails.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.OrdersDetails.Service
{
    public class OrderDetailsQueryServiceSingleton
    {

        private static readonly Lazy<IOrderDetailsQueryService> _instance = new Lazy<IOrderDetailsQueryService>(() => new OrderDetailsQueryServicecs());

        public static IOrderDetailsQueryService Instance => _instance.Value;

        private OrderDetailsQueryServiceSingleton() { }

    }
}
