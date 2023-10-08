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
        private List<int> _items = new List<int>();

        public Favourite(int id, int idClient, List<int> items)
        {
            _id = id;
            _idClient = idClient;
            _items = items;
        }

        public Favourite() { }

        public Favourite(string text)
        {

            string[] prop = text.Split('|');
            _items = null;

            _id = int.Parse(prop[0]);
            _idClient = int.Parse(prop[1]);
            
            if (prop.Length >2)
                for (int i = 2; i < prop.Length-1; i++)
                    _items.Add(int.Parse(prop[i]));
            else _items = null;
        }


        public int Id { get => _id; set => _id = value; }

        public int IdClient { get => _idClient; set => _idClient = value; }

        public List<int> Items { get => _items; set => _items = value; }

        public string toSave()
        {
            string text = "";

            text = _id.ToString() + "|" + _idClient.ToString();
            if (_items != null)
                for (int i = 0; i < _items.Count; i++)
                {
                    text += "|" + _items[i].ToString();
                }
            else text += "|";
            MessageBox.Show(text);
            return text;
        }

    }
}
