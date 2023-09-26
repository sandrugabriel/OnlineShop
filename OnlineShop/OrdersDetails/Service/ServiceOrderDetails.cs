using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.OrdersDetails.Service
{
    internal class ServiceOrderDetails
    {

        private List<OrderDetalis> orders_Details;

        public ServiceOrderDetails()
        {

            orders_Details = new List<OrderDetalis>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath.Remove(44) + @"OrdersDetails\Data\ordersDetalis.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while((t = streamReader.ReadLine()) != null)
            {
                orders_Details.Add(new OrderDetalis(t));
            }

            streamReader.Close();

        }

        public void afisare()
        {

            for(int i=0;i<orders_Details.Count;i++)
            {
                MessageBox.Show(orders_Details[i].descriere());
            }

        }

    }
}
