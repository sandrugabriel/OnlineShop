using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Users.Service.interfaces
{
    interface IUserComandService
    {

        int generareIdUser();

        void saveFisier(string text);

        void load();


    }
}
