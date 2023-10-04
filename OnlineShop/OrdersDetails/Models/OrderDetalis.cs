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
        private string _orderAddress;
        private DateTime _orderDate;
        private List<int> idProducts = new List<int>();
        private List<int> quantities = new List<int>();

        public OrderDetalis(int id, int idUser, string orderAddress, DateTime orderDate, List<int> idProducts, List<int> quantities)
        {
            _id = id;
            _idUser = idUser;
            _orderAddress = orderAddress;
            _orderDate = orderDate;
            this.idProducts = idProducts;
            this.quantities = quantities;
        }

        public OrderDetalis()
        {

        }

        public OrderDetalis(string text) {

            string[] prop = text.Split('|');
        
            _id = int.Parse(prop[0]);
            _idUser = int.Parse(prop[1]);
            _orderAddress = prop[2];
            _orderDate = DateTime.Parse(prop[3]);
            int ct = -1;

            for (int i = 4; i < prop.Length; i++)
            {
                if (prop[i] == "Quantity:")
                {
                    ct++;
                    MessageBox.Show("Asd\n");
                }
                    

                if (ct >= 0 && i+1 <= prop.Length-1)
                    quantities.Add(int.Parse(prop[i+1]));
                else if(ct==-1)
                    idProducts.Add(int.Parse(prop[i]));

            }

            
        }

        public int getId() { return _id; }

        public void setId(int value) { _id = value; }

        public int getIdUser() { return _idUser; }

        public void setIdUser(int value) {  _idUser = value; }

        public string getAddress() { return _orderAddress; }

        public void setAddress(string value) { _orderAddress = value; }

        public DateTime getDate() { return _orderDate; }

        public void getDate(DateTime dateTime) { _orderDate = dateTime; }

        public List<int> getIdProducts() { return idProducts; }

        public void setIdProducts(List<int> value) {  idProducts = value; }

        public List<int> getQuantities() { return quantities; }

        public void setQuantities(List<int> value) { quantities = value; } 

        public string descriere()
        {
            string t = "";

            t += "Id: " + _id.ToString() + "\n";
            t += "IdProducts:\n";
            for(int i=0;i<idProducts.Count;i++)
                t += idProducts[i].ToString() + ", ";
            t += "\nQuantity: ";
            for (int i = 0; i < quantities.Count; i++)
                t += quantities[i].ToString() + ", ";

            return t;
        }

        public int CompareTo(OrderDetalis other)
        {
            if(quantities.Count > other.quantities.Count)
            {
                return 1;
            }else if(quantities.Count == other.quantities.Count)
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

        public OrderDetalis Quantities(List<int> quantities)
        {
            this.quantities = quantities; return this;
        }

        public OrderDetalis OrderAddress(string orderAddress)
        {
            this._orderAddress = orderAddress;
            return this;
        }

        public OrderDetalis OrderDate(DateTime orderDate)
        {
            this._orderDate = orderDate;
            return this;
        }

        public OrderDetalis IdProducts(List<int> ids)
        {
            this.idProducts = ids; return this;
        }


    }
}
