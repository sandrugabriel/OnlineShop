using OnlineShop.Favourites.Models;
using OnlineShop.Favourites.Service.interfaces;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Favourites.Service
{
    public class FavouriteComandService : IFavouriteComandService
    {

        private List<Favourite> favourites;

        public FavouriteComandService()
        {

            favourites = new List<Favourite>();

            load();

        }

        public FavouriteComandService(List<Favourite> favourites)
        {
            this.favourites = favourites;
        }


        public void load()
        {

            string path = Application.StartupPath + Path();

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while ((t = streamReader.ReadLine()) != null)
            {
                favourites.Add(new Favourite(t));
            }

            streamReader.Close();
        }

        public string Path()
        {
            return @"/data/favourites.txt";
        }

        public void saveFisier(string text)
        {
            File.AppendAllText(Application.StartupPath + Path(), text + "\n");
        }

        public Favourite getById(int id)
        {

            for (int i = 0; i < favourites.Count; i++)
            {
                if (id == favourites[i].Id)
                {
                    return favourites[i];
                }
            }

            return null;
        }

        public int generareId()
        {

            Random rand = new Random();

            int id = rand.Next(1, 1000000);

            while (this.getById(id) != null)
            {
                id = rand.Next(1, 1000000);
            }

            return id;
        }

        public string toSaveFisier()
        {

            string t = "";

            for(int i = 0; i < favourites.Count; i++)
            {
                t += favourites[i].toSave() + "\n";
            }

            return t;
        }

        public void update()
        {
            
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + Path());


            string value = toSaveFisier();
            streamWriter.Write(value);

          //  MessageBox.Show(value);
   

            streamWriter.Close();
        }

        public int pozProduct(int idClient, int idProduct)
        {
            int poz = -1;
            for (int i = 0; i < favourites.Count; i++)
            {
                if (idClient == favourites[i].IdClient && idProduct == favourites[i].IdProduct)
                {
                    return poz; 
                }
            }

            return -1;    
        }

    }
}
