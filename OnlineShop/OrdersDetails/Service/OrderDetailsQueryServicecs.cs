using OnlineShop.Models;
using OnlineShop.OrdersDetails.Service.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.OrdersDetails.Service
{
    internal class OrderDetailsQueryServicecs : IOrderDetailsQueryService
    {


        List<OrderDetalis> ordersDetails;

        public OrderDetailsQueryServicecs()
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

        public List<OrderDetalis> getAllOrdersDetails()
        {
            return ordersDetails;
        }

        public List<OrderDetalis> getMyOrdersDetails(int idUser)
        {
            List<OrderDetalis> myorderDetalis = new List<OrderDetalis>();

            for(int i = 0; i < ordersDetails.Count; i++)
            {
                if (ordersDetails[i].IdUser == idUser) myorderDetalis.Add(ordersDetails[i]);
            }

            return myorderDetalis;
        }

        public OrderDetalis getById(int id)
        {
            for (int i = 0; i < ordersDetails.Count; i++)
            {
                if (ordersDetails[i].Id == id) return ordersDetails[i];
            }

            return null;
        }
    }
}
