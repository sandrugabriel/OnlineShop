using OnlineShop.Models;
using OnlineShop.Orders.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Orders
{
    internal class OrderComandService : IOrderComandSerice
    {

        private List<Order> orders;

        public OrderComandService()
        {

            orders = new List<Order>();

            load();

        }

        public void load() {

            string path = Application.StartupPath.Remove(44) + @"Orders\Data\orders.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while((t = streamReader.ReadLine()) != null)
            {
                orders.Add(new Order(t));
            }

            streamReader.Close();
        }

        public void saveFisier(string text)
        {
            File.AppendAllText(Application.StartupPath.Remove(44) + @"Orders\Data\orders.txt",text+"\n");
        }

        public Order getById(int id)
        {

            for(int i=0;i<orders.Count;i++)
            {
                if(id == orders[i].Id)
                {
                    return orders[i];
                }
            }

            return null;
        }

        public int generareIdOrder()
        {

            Random rand = new Random(); 

            int id = rand.Next(1,10000);

            while(this.getById(id) != null)
            {
                id = rand.Next(1, 10000);
            }

            return id;
        }
        
    }
}
