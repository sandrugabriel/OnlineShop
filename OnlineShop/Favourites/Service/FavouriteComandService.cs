using OnlineShop.Favourites.Models;
using OnlineShop.Favourites.Service.interfaces;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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
                    return i; 
                }
            }

            return -1;    
        }

        public int pozFavourite(int id)
        {
            for (int i = 0; i < favourites.Count; i++)
            {
                if (favourites[i].Id == id)
                {
                    return i;
                }
            }

            return -1;
        }

        public void stergere(int id)
        {
            int p = pozFavourite(id);
                favourites.RemoveAt(p);
            
        }

        public void deleteCard(Favourite favourite)
        {

            this.stergere(favourite.Id);
            //favourites.Remove(favourite);

            string path = Application.StartupPath + Path();

            StreamWriter stream = new StreamWriter(path);

            stream.Write(this.toSaveFisier());

            stream.Close();
        }

        public void save(List<Favourite> favourites)
        {
            this.favourites = favourites;
        }

        public int ctFav(int idUser)
        {
            int ct = 0;
            for(int i=0;i<favourites.Count;i++)
            {
                if (favourites[i].IdClient == idUser)
                    ct++;
            }

            return ct;
        }


        public int[] frecventa()
        {

            int[] f = new int[10000];

            for (int i = 0; i < favourites.Count; i++)
            {
                f[favourites[i].IdProduct]++;
            }

            return f;
        }

        public int[] frecventaMaxi()
        {
            int[] fp = frecventa();

            int[] nou = new int[10000];
            int ct = 0;
            for (int i = 0; i < 10000; i++)
            {
                if (fp[i] != 0)
                {
                    nou[ct] = fp[i];
                    ct++;
                }

            }

            return nou;
        }


    }
}
