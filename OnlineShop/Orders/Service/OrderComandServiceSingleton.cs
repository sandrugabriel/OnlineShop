using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Orders.Service
{
    public class OrderComandServiceSingleton
    {
        private static readonly Lazy<IOrderComandSerice> _instance = new Lazy<IOrderComandSerice>(() => new OrderComandService());

        public static IOrderComandSerice Instance => _instance.Value;

        private OrderComandServiceSingleton() { }
    }
}
