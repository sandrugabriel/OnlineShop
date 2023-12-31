﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Users.Models
{
    public class User :IComparable<User> , IUserBuilder 
    {

        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private string _phone;
        private string _address;
        private int _varsta;
        string userRole = null;

        public User(int id, string name, string email, string password, string phone, string address, int varsta, string userRole)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
            _phone = phone;
            _address = address;
            _varsta = varsta;
            this.userRole = userRole;
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
            _varsta = int.Parse(prop[6]);
            userRole = prop[7];
         /*   if (prop[7].Equals("admin"))
            {

              userRole = new UserRole("admin", new List<string>
               {
            UserPermission.CUSTOMER_READ,
            UserPermission.CUSTOMER_WRITE,
            UserPermission.ORDER_READ,
            UserPermission.ORDER_WRITE,
            UserPermission.PRODUCT_READ,
            UserPermission.PRODUCT_WRITE
                });


            }
            else
            {
               userRole = new UserRole("customer", new List<string>
                 {
            UserPermission.PRODUCT_READ,
            UserPermission.ORDER_WRITE,
            UserPermission.ORDER_READ
                  });
            }*/
        }

        public User()
        {

        }

        public string getUserRole() {  return userRole; }

        public void setUserRole(string role) { userRole = role; }

        public int getId() { return _id; }

        public void setId(int id) { _id = id; }

        public string getName() {return _name; }

        public void setName(string name) { _name = name; }

        public string getEmail() { return _email; }

        public void setEmail(string email) { _email = email; }

        public string getPassword() { return _password; }

        public void setPassword(string password) { _password = password; }

        public string getPhone() {return _phone; }

        public void setPhone(string phone) { _phone = phone; }

        public string getAddress() {return _address; }

        public void setAddress(string address) { _address = address; }
        
        public int CompareTo(User other)
        {
            if (this._varsta > other._varsta)
            {
                return 1;
            }else if(this._varsta == other._varsta)
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }

        public User Id(int id)
        {
            this._id = id;
            return this;
        }

        public User Name(string name) { 
            this._name = name;
        return this; 
        }

        public User Email(string email) { 
            this._email = email;
        return this; 
        }

        public User Password(string pass)
        {
            this._password = pass;
            return this;
        }

        public User Phone(string phone)
        {
            this._phone = phone;
            return this;
        }

        public User Address(string address)
        {
            this._address = address;
            return this;
        }

        public User Varsta(int varsta)
        {
            this._varsta = varsta;
            return this;
        }

        public static User Build()
        {
            return new User();
        }

        public string toSave()
        {
            return _id.ToString() + "|" + _name + "|" + _email + "|" + _password + "|" + _phone + "|" + _address + "|" + _varsta;
        }

    }
}
