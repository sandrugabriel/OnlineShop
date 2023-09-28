using OnlineShop.Models;
using OnlineShop.Users.Models;
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
    internal class UserComandService : IUserComandService
    {

        List<User> users;

        public UserComandService()
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

        public void saveFisier(string text)
        {
            File.AppendAllText(Application.StartupPath.Remove(44) + @"Users\Data\users.txt", text + "\n");
        }

        public User getById(int id)
        {

            for (int i = 0; i < users.Count; i++)
            {
                if (id == users[i].Id)
                {
                    return users[i];
                }
            }

            return null;
        }

        public int generareIdUser()
        {

            Random rand = new Random();

            int id = rand.Next(1, 10000);

            while (this.getById(id) != null)
            {
                id = rand.Next(1, 10000);
            }

            return id;
        }

    }
}
