using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Product : IComparable<Product>
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

        public int Id { get => _id; set => _id = value; }

        public string Name { get => _name; set => _name = value; }

        public double Price { get => _price; set => _price = value; }

        public int Stock { get => _stock; set => _stock = value; }

        public string PathImage { get => _pathImage; set => _pathImage = value; }

        public List<int> IdTags { get => idTags; set => idTags = value; }

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
    }
}
