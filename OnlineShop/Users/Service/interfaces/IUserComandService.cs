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


    }
}
