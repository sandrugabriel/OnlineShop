using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Users.Models
{
    public class UserRole
    {
        public string Name { get; set; }

        public List<string> Permissions { get; private set; }

        public UserRole(string name, List<string> permissions)
        {
            Name = name;
            Permissions = permissions;
        }

        public static class Roles
        {
            public static UserRole Customer { get; } = new UserRole("customer", new List<string>
        {
            UserPermission.PRODUCT_READ,
            UserPermission.ORDER_WRITE,
            UserPermission.ORDER_READ
        });

            public static UserRole Admin { get; } = new UserRole("admin", new List<string>
        {
            UserPermission.CUSTOMER_READ,
            UserPermission.CUSTOMER_WRITE,
            UserPermission.ORDER_READ,
            UserPermission.ORDER_WRITE,
            UserPermission.PRODUCT_READ,
            UserPermission.PRODUCT_WRITE
        });
        }
    }
}
