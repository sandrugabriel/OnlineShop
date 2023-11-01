using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Users.Service.interfaces
{
    public interface IUserComandService
    {

        int generareIdUser();

        void saveFisier(string text);

        string Path();

        void load();

        void setAll(int id, string name,string email, string pass, string address, string phone);

        void update();

        void save(List<User> users);
    }
}
