using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Orders.Service.interafaces
{
    public class OrderQueryServiceSingleton
    {

        private static readonly Lazy<IOrderQueryService> _instance = new Lazy<IOrderQueryService>(() => new OrderQueryService());

        public static IOrderQueryService Instance =>_instance.Value;

        private OrderQueryServiceSingleton() { }

    }
}
