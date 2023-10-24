using OnlineShop.Products.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace OnlineShop.Models
{
    public class Product : IComparable<Product> , IProductBuilder
    {

        private int _id;
        private string _name;
        private double _price;
        private int _stock;
        private string _pathImage;
        private string _description;
        private string _categorie;

        public Product(int id, string name, double price, int stock, string pathImage,string d, string categ)
        {
            _id = id;
            _name = name;
            _price = price;
            _stock = stock;
            _pathImage = pathImage;
            _description = d;
            this._categorie = categ;
        }

        public Product(string text)
        {
            string[] prop = text.Split('|');

            _id = int.Parse(prop[0]);
            _name = prop[1];
            _price = double.Parse(prop[2]);
            _stock = int.Parse(prop[3]);
            _pathImage = prop[4];
            _categorie = prop[5];
            _description = prop[6];

        }

        public Product()
        {

        }

        public int getId() { return _id; }

        public void setid(int id) { _id = id; }
        
        public string getName() { return _name; }

        public void setName(string name) { _name = name; }

        public double getPrice() { return _price;}

        public void setPrice(double price) { _price = price; }

        public int getStock() { return _stock; }

        public void setStock(int value) {  _stock = value; }

        public string getPathImage() {return _pathImage; }

        public void setPathImage(string path) {  _pathImage = path; }

        public string getDescriere() {return _description;}

        public void setDescriere(string d) {  _description = d; }

        public string getCategorie() { return _categorie; }

        public void setCategorie(string d) { _categorie = d; }

        public string descriere()
        {

            string t="";

            t += "Id: " + _id.ToString() + "\n";
            t += "Name : " + _name + "\n";
            t += "Price: " + _price.ToString() + "\n";
            t += "Stock: " + _stock.ToString() + "\n";

            return t;
        }

        public int CompareTo(Product other)
        {
            if (this._price > other._price)
            {
                return 1;
            }
            else if (this._price == other._price)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public Product Id(int id)
        {
            this._id = id;
            return this;
        }

        public Product PathImage(string path)
        {
            this._pathImage = path;
            return this;
        }

        public Product Categorie(string c)
        {
            this._categorie = c;
            return this;
        }

        public Product Descriere(string d)
        {
            this._description = d;
            return this;
        }

        public Product Stock(int stock)
        {
            this._stock = stock;
                return this;
        }

        public Product Price(int price)
        {
            this._price = price;
            return this;
        }

        public Product Name(string name)
        {
            this._name = name;
            return this;
        }

        public static Product Build()
        {
            return new Product();
        }

        public string toSave()
        {
            return _id.ToString() + "|" + _name +"|"+ _price.ToString("F2") + "|" + _stock + "|" + _pathImage + "|" + _categorie + "|" + _description;
        }

    }
}
