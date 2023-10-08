using OnlineShop.Models;
using OnlineShop.Products.Service.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Products.Service
{
    public class ProductQueryService : IProductQueryService
    {

        private List<Product> products;

        public ProductQueryService()
        {
            products = new List<Product>();

            load();
        }
    
        public ProductQueryService(List<Product> products)
        {
            this.products = products;
        }

        public void load()
        {

            string path = Application.StartupPath.Remove(44) + "Products/Data/products.txt";

            StreamReader streamReader = new StreamReader(path);


            string t = "";

            while ((t = streamReader.ReadLine()) != null)
            {
                products.Add(new Product(t));
            }

            streamReader.Close();
        }

        public List<Product> getAll()
        {
            return products;
        }

        public List<Product> getProductWithCateg(string c)
        {
            List<Product> list = new List<Product>();

            for (int i = 0; i < products.Count; i++)
            {
                    if (c == products[i].getCategorie()) list.Add(products[i]);
            }

            return list;
        }

        public Product getByID(int id)
        {
            for(int i=0;i< products.Count; i++)
            {
                if (products[i].getId() == id) return products[i];
            }

            return null;
        }

    }
}
