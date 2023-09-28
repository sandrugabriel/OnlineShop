using OnlineShop.Models;
using OnlineShop.OrdersDetails.Service.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.OrdersDetails.Service
{
    internal class OrderDetailsComandService : IOrderDetailsComandService
    {

        List<OrderDetalis> ordersDetails;

        public OrderDetailsComandService()
        {

            ordersDetails = new List<OrderDetalis>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath.Remove(44) + @"OrdersDetails\Data\ordersDetalis.txt";

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
            File.AppendAllText(Application.StartupPath.Remove(44) + @"OrdersDetails\Data\ordersDetalis.txt", text + "\n");
        }

        public OrderDetalis getById(int id)
        {

            for (int i = 0; i < ordersDetails.Count; i++)
            {
                if (id == ordersDetails[i].Id)
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
    }
}
