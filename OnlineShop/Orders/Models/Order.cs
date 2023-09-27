using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Models
{
    internal class Order
    {

        private int _id;
        private double _price;
        private List<int> idProducts = new List<int>();
        private int _idUser;

        public int Id { get => _id; set => _id = value; }

        public double Price { get => _price; set => _price = value; }

        public List<int> IdProducts { get => idProducts; set => idProducts = value; }
        public int IdUser { get => _idUser; set => _idUser = value; }

        public Order(int id, double price, List<int> idProducts, int idUser)
        {
            _id = id;
            _price = price;
            _idUser = idUser;
            this.idProducts = idProducts;
        }

        public Order(string text)
        {
            string[] prop = text.Split('|');

            _id = int.Parse(prop[0]);
            _idUser = int.Parse(prop[1]);
            _price = double.Parse(prop[2]);

            for (int i = 3; i < prop.Length; i++)
                idProducts.Add(int.Parse(prop[i]));

        }

        public string descriere()
        {
            string t = "";

            t += "Id: " + _id.ToString() + "\n";
            t += "Price: " + _price.ToString() + "\n";

            return t;
        }

    }
}
