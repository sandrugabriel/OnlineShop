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

            string path = Application.StartupPath.Remove(44) + Path();

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
            return @"Favourites\Data\favourites.txt";
        }

        public void saveFisier(string text)
        {
            File.AppendAllText(Application.StartupPath.Remove(44) + Path(), text + "\n");
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

            int id = rand.Next(1, 10000);

            while (this.getById(id) != null)
            {
                id = rand.Next(1, 10000);
            }

            return id;
        }

        public void setList(int id,List<int> items)
        {
            for(int i=0;i<favourites.Count;i++)
            {
                if(id == favourites[i].Id)
                {
                    favourites[i].Items = items;
                }
            }

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
           // MessageBox.Show(toSaveFisier());
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath.Remove(44) + Path());

            streamWriter.Write(this.toSaveFisier());

            streamWriter.Close();
        }

        public int pozProduct(int id, int idProduct)
        {
            int poz = -1;
            for (int i = 0; i < favourites.Count; i++)
            {
                if (id == favourites[i].IdClient)
                {
                    for(int j = 0; j < favourites[i].Items.Count; j++)
                    {
                        if (favourites[i].Items[j] == idProduct)
                        {
                            poz = j;
                        }
                    }
                   
                }
            }

            return poz;    
        }

    }
}
