using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Products.Service.interfaces
{
    public interface IProductBuilder
    {

        Product Id(int id);
        Product Name(string name);
        Product Price(int price);
        Product Stock(int stock);
        Product PathImage(string path);
        Product IdTags(List<int> tags);


    }
}
