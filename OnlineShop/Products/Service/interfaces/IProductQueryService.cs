using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Products.Service.interfaces
{
    interface IProductQueryService
    {

        List<Product> getAll();

        List<Product> getProductWithTag(int idTag);

    }
}
