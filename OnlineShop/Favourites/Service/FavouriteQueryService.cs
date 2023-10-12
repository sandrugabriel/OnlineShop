using OnlineShop.Favourites.Models;
using OnlineShop.Favourites.Service.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Favourites.Service
{
    public class FavouriteQueryService : IFavouriteQueryService
    {
        private List<Favourite> favourites;

        public FavouriteQueryService()
        {

            favourites = new List<Favourite>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/favourites.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while ((t = streamReader.ReadLine()) != null)
            {
                favourites.Add(new Favourite(t));
            }

            streamReader.Close();
        }

        public void af()
        {
            for(int i=0;i<favourites.Count;i++)
            {
                MessageBox.Show(favourites[i].Id.ToString());
            }
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

        public List<Favourite> getByIdClient(int idClient)
        {
            List<Favourite> list = new List<Favourite>();

            for (int i = 0; i < favourites.Count; i++)
            {
                if (idClient == favourites[i].IdClient)
                {
                    list.Add(favourites[i]);
                }
            }

            return list;
        }

    }
}
