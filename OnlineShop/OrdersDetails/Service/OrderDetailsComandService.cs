using OnlineShop.Favourites.Models;
using OnlineShop.Models;
using OnlineShop.OrdersDetails.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.OrdersDetails.Service
{
    public class OrderDetailsComandService : IOrderDetailsComandService
    {

        List<OrderDetalis> ordersDetails;

        public OrderDetailsComandService()
        {

            ordersDetails = new List<OrderDetalis>();

            load();

        }

        public OrderDetailsComandService(List<OrderDetalis> ordersDetails)
        {
            this.ordersDetails = ordersDetails;
        }

        public void load()
        {

            string path = Application.StartupPath + Path();

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while ((t = streamReader.ReadLine()) != null)
            {
                ordersDetails.Add(new OrderDetalis(t));
            }

            streamReader.Close();
        }

        public void saveFisier(string text)
        {
            File.AppendAllText(Application.StartupPath + Path(), text + "\n");
        }

        public string Path()
        {
            return @"\data\ordersDetalis.txt";
        }

        public OrderDetalis getById(int id)
        {

            for (int i = 0; i < ordersDetails.Count; i++)
            {
                if (id == ordersDetails[i].getId())
                {
                    return ordersDetails[i];
                }
            }

            return null;
        }

        public int generareIdOrder()
        {

            Random rand = new Random();

            int id = rand.Next(1, 10000);

            while (this.getById(id) != null)
            {
                id = rand.Next(1, 10000);
            }

            return id;
        }

        public int pozOrderDetails(int id)
        {
            for (int i = 0; i < ordersDetails.Count; i++)
            {
                if (ordersDetails[i].getId() == id)
                {
                    return i;
                }
            }

            return -1;
        }

        public void stergere(int id)
        {
            int p = pozOrderDetails(id);
            ordersDetails.RemoveAt(p);

        }

        public string toSaveFisier()
        {

            string t = "";

            for (int i = 0; i < ordersDetails.Count; i++)
            {
                t += ordersDetails[i].toSave() + "\n";
            }

            return t;
        }

        public void setQuantity(int idUser,int idProduct,int quantity)
        {

            for(int i=0;i<ordersDetails.Count;i++)
            {
                if(idUser == ordersDetails[i].getIdUser() && idProduct == ordersDetails[i].getIdProduct()) {
                    ordersDetails[i].setQuantities(quantity);
                }
            }

        }

        public void update()
        {
            string path = Application.StartupPath + Path();
            StreamWriter writer = new StreamWriter(path);
            writer.Write(this.toSaveFisier());
            writer.Close();
        }

        public void deleteCard(OrderDetalis order)
        {

            this.stergere(order.getId());
            //favourites.Remove(favourite);

            string path = Application.StartupPath + @"/data/ordersDetalis.txt";

            StreamWriter stream = new StreamWriter(path);

            stream.Write(this.toSaveFisier());

            stream.Close();
        }

        public void save(List<OrderDetalis> orderDetalis)
        {
            this.ordersDetails = orderDetalis;
        }

        public int ctCart(int idUser)
        {
            int ct = 0;
            for (int i = 0; i < ordersDetails.Count; i++)
            {
                if (ordersDetails[i].getIdUser() == idUser)
                    ct++;
            }

            return ct;
        }

        public int[] frecventa()
        {

            int[] f = new int[10000];

            for (int i = 0; i < ordersDetails.Count; i++)
            {
                f[ordersDetails[i].getIdProduct()]++;
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
