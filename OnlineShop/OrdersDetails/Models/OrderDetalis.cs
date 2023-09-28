using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Models
{
    internal class OrderDetalis : IComparable<OrderDetalis>
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

        public int Id { get => _id; set => _id = value; }

        public int IdUser { get => _idUser; set => _idUser = value; }

        public string OrderAddress { get => _orderAddress; set => _orderAddress = value; }

        public DateTime OrderDate { get => _orderDate; set => _orderDate = value; }

        public List<int> IdProducts { get => idProducts; set => idProducts = value; }

        public List<int> Quantities { get => quantities; set => quantities = value; }

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
    }
}
