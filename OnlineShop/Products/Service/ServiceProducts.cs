using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Products
{
    internal class ServiceProducts
    {

        private List<Product> products;

        public ServiceProducts()
        {
            products = new List<Product>();

            load();
        }

        public void load()
        {

            string path = Application.StartupPath.Remove(44) + "Products/Data/products.txt";

            StreamReader streamReader = new StreamReader(path);

            //MessageBox.Show(path);

            string t = "";

            while((t = streamReader.ReadLine()) != null)
            {
                products.Add(new Product(t));
            }

            streamReader.Close();
        }

        public void afisare()
        {
            for(int i=0;i<products.Count; i++)
            {
                MessageBox.Show(products[i].descriere());
            }
        }

    }
}
