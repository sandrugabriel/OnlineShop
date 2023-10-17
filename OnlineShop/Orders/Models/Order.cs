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
        private int _idUser;
        private int _idProduct;
        private int _quantity;
        private string _address;
        private string phone;

        public int getId() { return _id; }

        public void setId(int value) {  _id = value; }

        public double getquantity() {return _quantity; }

        public void setPrice(int q) { _quantity = q; }

        public int getIdProduct() { return _idProduct; }

        public void setIdProduct(int id) {  _idProduct = id; }

        public int getIdUser() {return _idUser;}

        public void setIdUser(int  value) { _idUser = value; }

        public Order(int id, int idUser, int idProduct, int quantities, string address, string phone)
        {
            _id = id;
            _idUser = idUser;
            _idProduct = idProduct;
            _quantity = quantities;
            _address = address;
            this.phone = phone;
        }


        public Order(string text)
        {
            string[] prop = text.Split('|');

            _id = int.Parse(prop[0]);
            _idUser = int.Parse(prop[1]);
            _idProduct = int.Parse(prop[2]);
            _quantity = int.Parse(prop[3]);
            _address = prop[4];
            this.phone = prop[5];

        }

        public Order() { }

        public string descriere()
        {
            string t = "";

            t += "Id: " + _id.ToString() + "\n";
            t += "Quantity: " + _quantity.ToString() + "\n";

            return t;
        }

        public int CompareTo(Order other)
        {
            if (_quantity > other._quantity)
            {
                return 1;
            }
            else if (_quantity == other._quantity)
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

        public Order Quantity(int q)
        {
            this._quantity = q;
            return this;
        }

        public Order IdProduct(int product) {
        
            this._idProduct = product;
            return this;
        
        }

        public Order Address(string address)
        {
            this._address = address;
            return this;
        }

        public Order Phone(string phone)
        {
            this.phone = phone;
            return this;
        }

        public static Order Build()
        {
            return new Order();
        }

    }
}
