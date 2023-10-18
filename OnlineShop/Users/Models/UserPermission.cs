using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Users.Models
{
    public class UserPermission
    {
        public const string CUSTOMER_READ = "customer:read";
        public const string CUSTOMER_WRITE = "customer:write";
        public const string ORDER_READ = "order:read";
        public const string ORDER_WRITE = "order:write";
        public const string PRODUCT_READ = "product:read";
        public const string PRODUCT_WRITE = "product:write";

    }
}
