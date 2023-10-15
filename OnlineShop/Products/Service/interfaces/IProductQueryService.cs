using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Products.Service.interfaces
{
    public interface IProductQueryService
    {

        List<Product> getAll();

        List<Product> getProductWithCateg(string c);

        Product getByID(int id);

        List<Product> getByListId(List<int> ids);

    }
}
