﻿using OnlineShop.Models;
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
    internal class ProductComandService : IProductComandService
    {

        private List<Product> products;

        public ProductComandService()
        {
            products = new List<Product>();

            load();
        }

        public void load()
        {

            string path = Application.StartupPath.Remove(44) + "Products/Data/products.txt";

            StreamReader streamReader = new StreamReader(path);


            string t = "";

            while((t = streamReader.ReadLine()) != null)
            {
                products.Add(new Product(t));
            }

            streamReader.Close();
        }


        public void saveFisier(string text)
        {
            File.AppendAllText(Application.StartupPath.Remove(44) + @"Users\Data\users.txt", text + "\n");
        }

        public Product getById(int id)
        {

            for (int i = 0; i < products.Count; i++)
            {
                if (id == products[i].Id)
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
    }
}