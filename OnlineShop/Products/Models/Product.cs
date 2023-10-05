using OnlineShop.Products.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Product : IComparable<Product> , IProductBuilder
    {

        private int _id;
        private string _name;
        private double _price;
        private int _stock;
        private string _pathImage;
        private List<int> idTags = new List<int>();

        public Product(int id, string name, double price, int stock, string pathImage, List<int> idTags)
        {
            _id = id;
            _name = name;
            _price = price;
            _stock = stock;
            _pathImage = pathImage;
            this.idTags = idTags;
        }

        public Product(string text)
        {
            string[] prop = text.Split('|');

            _id = int.Parse(prop[0]);
            _name = prop[1];
            _price = double.Parse(prop[2]);
            _stock = int.Parse(prop[3]);
            _pathImage = prop[4];

            for (int i = 5; i < prop.Length; i++)
            {
                idTags.Add(int.Parse(prop[i]));
            }

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

        public List<int> getIdTags() {return idTags;}

        public void setIdTags(List<int> ids) {  idTags = ids; }

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

        public Product IdTags(List<int> idTags)
        {
            this.idTags = idTags;
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

    }
}
