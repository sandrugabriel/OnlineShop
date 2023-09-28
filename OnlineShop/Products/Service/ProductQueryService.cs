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
    internal class ProductQueryService : IProductQueryService
    {

        private List<Product> products;

        public ProductQueryService()
        {
            products = new List<Product>();

            load();
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

        public List<Product> getProductWithTag(int idTag)
        {
            List<Product> list = new List<Product>();

            for (int i = 0; i < products.Count; i++)
            {
                List<int> tags = products[i].IdTags;
                for(int j = 0; j < tags.Count; j++)
                {
                    if (tags[j] == idTag) list.Add(products[i]);
                }
            }

            return list;
        }


    }
}
