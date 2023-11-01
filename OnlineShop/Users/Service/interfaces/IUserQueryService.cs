using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Users.Service.interfaces
{
    public interface IUserQueryService
    {

        List<User> getAllUser();

        User getById(int id);

        User getByEmailPass(string email, string pass);

        void save(List<User> users);
    }
}
