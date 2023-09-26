using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Orders
{
    internal class ServiceOrders
    {

        private List<Order> orders;

        public ServiceOrders()
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

        public void afisare()
        {

            for(int i=0;i<orders.Count; i++)
            {
                MessageBox.Show(orders[i].descriere());
            }

        }



    }
}
