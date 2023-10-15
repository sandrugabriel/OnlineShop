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
    public class UserComandService : IUserComandService
    {

        List<User> users;

        public UserComandService()
        {

            users = new List<User>();

            load();

        }

        public UserComandService(List<User> users)
        {
            this.users = users;
        }

        public string Path()
        {
            return @"\data\users.txt";
        }

        public void load()
        {

            string path = Application.StartupPath + Path();

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
            File.AppendAllText(Application.StartupPath + Path(), text + "\n");
        }

        public User getById(int id)
        {

            for (int i = 0; i < users.Count; i++)
            {
                if (id == users[i].getId())
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

        public string toSaveFisier()
        {
            string t = "";

            for(int i=0;i<users.Count; i++)
            {
                t += users[i].toSave() + "\n";
            }
            return t;
        }

        public void update()
        {
            string path = Application.StartupPath + Path();
            StreamWriter writer = new StreamWriter(path);
            writer.Write(this.toSaveFisier());
            writer.Close();
        }

        public void setAll(int id,string name, string email, string pass, string address, string phone)
        {

            for (int i = 0; i < users.Count; i++)
            {
                if (id == users[i].getId())
                {
                    users[i].setName(name);
                    users[i].setEmail(email);
                    users[i].setAddress(address);
                    users[i].setPhone(phone);
                    users[i].setPassword(email);

                }
            }

        }

    }
}
