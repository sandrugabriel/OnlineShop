using OnlineShop.Orders.Service.interafaces;
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
    public class Order : IComparable<Order> , IOrdersBuilder
    {

        private int _id;
        private double _price;
        private List<int> idProducts = new List<int>();
        private int _idUser;

        public int getId() { return _id; }

        public void setId(int value) {  _id = value; }

        public double getPrice() {return _price; }

        public void setPrice(double price) { _price = price; }

        public List<int> getIdProducts() { return idProducts; }

        public void setIdProducts(List<int> ids) {  idProducts = ids; }

        public int getIdUser() {return _idUser;}

        public void setIdUser(int  value) { _idUser = value; }

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

        public Order() { }

        public string descriere()
        {
            string t = "";

            t += "Id: " + _id.ToString() + "\n";
            t += "Price: " + _price.ToString() + "\n";

            return t;
        }

        public int CompareTo(Order other)
        {
            if (_price > other._price)
            {
                return 1;
            }
            else if (_price == other._price)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public Order Id(int id)
        {
            this._id = id;
            return this;
        }

        public Order IdUser(int idUser)
        {
            this._idUser = idUser;
                return this;
        }

        public Order Price(double price)
        {
            this._price = price;
            return this;
        }

        public Order IdProducts(List<int> products) {
        
            this.idProducts = products;
            return this;
        
        }

    }
}
