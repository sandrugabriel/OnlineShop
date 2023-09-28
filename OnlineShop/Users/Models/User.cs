using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Users.Models
{
    public class User
    {

        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private string _phone;
        private string _address;

        public User(int id, string name, string email, string password, string phone, string address)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
            _phone = phone;
            _address = address;
        }

        public User(string text)
        {
            string[] prop = text.Split('|');

            _id = int.Parse(prop[0]);
            _name = prop[1];
            _email = prop[2];
            _password = prop[3];
            _phone = prop[4];
            _address = prop[5];

        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }


    }
}
