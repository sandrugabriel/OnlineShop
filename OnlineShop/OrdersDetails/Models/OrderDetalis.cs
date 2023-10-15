using OnlineShop.OrdersDetails.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Models
{
    public class OrderDetalis : IComparable<OrderDetalis>,IOrderDetalisBuilder
    {

        private int _id;
        private int _idUser;
        private int _idProduct;
        private int _quantities;

        public OrderDetalis(int id, int idUser, int idProduct, int quantities)
        {
            _id = id;
            _idUser = idUser;
            this._idProduct = idProduct;
            this._quantities = quantities;
        }

        public OrderDetalis()
        {

        }

        public OrderDetalis(string text)
        {

            string[] prop = text.Split('|');

            _id = int.Parse(prop[0]);
            _idUser = int.Parse(prop[1]);
            _idProduct = int.Parse(prop[2]);
            _quantities = int.Parse(prop[3]);

        }

        public int getId() { return _id; }

        public void setId(int value) { _id = value; }

        public int getIdUser() { return _idUser; }

        public void setIdUser(int value) {  _idUser = value; }

        public int getIdProduct() { return _idProduct; }

        public void setIdProducts(int value) {  _idProduct = value; }

        public int getQuantities() { return _quantities; }

        public void setQuantities(int value) { _quantities = value; } 

        public string descriere()
        {
            string t = "";

            t += "Id: " + _id.ToString() + "\n";
            t += "IdProducts: "+_idProduct.ToString() + "\n";
            t += "IdUser: " + _idUser.ToString() + "\n";

            return t;
        }

        public int CompareTo(OrderDetalis other)
        {
            if(_quantities > other._quantities)
            {
                return 1;
            }else if(_quantities == other._quantities)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public OrderDetalis Id(int id)
        {
            this._id = id;
            return this;
        }

        public OrderDetalis IdUser(int id)
        {
            this._idUser = id;
            return this;
        }

        public OrderDetalis Quantities(int quantities)
        {
            this._quantities = quantities; return this;
        }

        public OrderDetalis IdProduct(int id)
        {
            this._idProduct = id; return this;
        }

        public static OrderDetalis Build()
        {
            return new OrderDetalis();
        }

        public string toSave()
        {
            return _id.ToString() + "|" + _idUser.ToString() + "|" + _idProduct.ToString() + "|" + _quantities.ToString();
        }
    }
}
