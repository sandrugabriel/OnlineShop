﻿using OnlineShop.Users.Models;
using OnlineShop.Users.Service.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Users.Service
{
    internal class UserQueryservice : IUserQueryService
    {


        List<User> users;

        public UserQueryservice()
        {

            users = new List<User>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath.Remove(44) + @"Users\Data\users.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while ((t = streamReader.ReadLine()) != null)
            {
                users.Add(new User(t));
            }

            streamReader.Close();
        }


        public List<User> getAllUser()
        {
            return users;
        }

        public User getById(int id)
        {

            for(int i=0;i<users.Count; i++)
            {
                if (users[i].Id == id) return users[i];
            }

            return null;
        }

        public User getByEmailPass(string email, string pass)
        {

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Email == email && users[i].Password == pass) return users[i];
            }

            return null;
        }



    }
}