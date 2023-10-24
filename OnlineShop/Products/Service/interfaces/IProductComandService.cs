using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Products.Service.interfaces
{
    public interface IProductComandService
    {

        int generareIdProduct();

        void saveFisier(string text);

        string Path();

        void load();

        void update();

        int pozProduct(int idProduct);

        void stergere(int id);

        void deleteCard(Product product);

        void save(List<Product> products);
    }
}
