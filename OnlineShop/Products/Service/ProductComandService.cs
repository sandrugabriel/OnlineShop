using OnlineShop.Models;
using OnlineShop.Products.Service.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Products
{
    public class ProductComandService : IProductComandService
    {

        private List<Product> products;

        public ProductComandService()
        {
            products = new List<Product>();

            load();
        }

        public ProductComandService(List<Product> products)
        {
            this.products = products;
        }

        public void load()
        {

            string path = Application.StartupPath + Path();

            StreamReader streamReader = new StreamReader(path);


            string t = "";

            while((t = streamReader.ReadLine()) != null)
            {
                products.Add(new Product(t));
            }

            streamReader.Close();
        }

        public string Path()
        {
            return @"\data\products.txt";
        }

        public void saveFisier(string text)
        {
            File.AppendAllText(Application.StartupPath + Path(), text + "\n");
        }

        public Product getById(int id)
        {

            for (int i = 0; i < products.Count; i++)
            {
                if (id == products[i].getId())
                {
                    return products[i];
                }
            }

            return null;
        }

        public int generareIdProduct()
        {

            Random rand = new Random();

            int id = rand.Next(1, 10000);

            while (this.getById(id) != null)
            {
                id = rand.Next(1, 10000);
            }

            return id;
        }

        public string toSaveFisier()
        {
            string t = "";

            for (int i = 0; i < products.Count; i++)
            {
                t += products[i].toSave() + "\n";
            }

            return t;
        }

        public void update()
        {

            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + Path());


            string value = toSaveFisier();
            streamWriter.Write(value);

            //  MessageBox.Show(value);


            streamWriter.Close();
        }

        public int pozProduct(int idProduct)
        {
            int poz = -1;
            for (int i = 0; i < products.Count; i++)
            {
                if (idProduct == products[i].getId())
                {
                    return i;
                }
            }

            return -1;
        }

        public void stergere(int id)
        {
            int p = pozProduct(id);
            products.RemoveAt(p);

        }

        public void deleteCard(Product product)
        {

            this.stergere(product.getId());

            string path = Application.StartupPath + Path();

            StreamWriter stream = new StreamWriter(path);

            stream.Write(this.toSaveFisier());

            stream.Close();
        }

        public void save(List<Product> products)
        {
            this.products = products;
        }

    }
}
