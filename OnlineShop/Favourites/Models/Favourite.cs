using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Favourites.Models
{
    public class Favourite
    {

        private int _id;
        private int _idClient;
        private int _idProduct;

        public Favourite(int id, int idClient, int idpro)
        {
            _id = id;
            _idClient = idClient;
            _idProduct = idpro;
        }

        public Favourite() { }

        public Favourite(string text)
        {

            string[] prop = text.Split('|');

            _id = int.Parse(prop[0]);
            _idClient = int.Parse(prop[1]);
            _idProduct = int.Parse(prop[2]);

        }


        public int Id { get => _id; set => _id = value; }

        public int IdClient { get => _idClient; set => _idClient = value; }

        public int IdProduct { get => _idProduct; set => _idProduct = value; }

        public string toSave()
        {
            string text = "";

            text = _id.ToString() + "|" + _idClient.ToString() + "|" + _idProduct.ToString();

            //MessageBox.Show(text);
            return text;
        }

    }
}
