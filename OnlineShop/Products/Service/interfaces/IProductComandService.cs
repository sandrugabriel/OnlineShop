using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Products.Service.interfaces
{
    interface IProductComandService
    {

        int generareIdProduct();

        void saveFisier(string text);

        void load();
    }
}
