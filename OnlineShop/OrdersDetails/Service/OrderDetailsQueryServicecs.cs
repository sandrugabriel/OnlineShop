using OnlineShop.Favourites.Models;
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
    public class OrderDetailsQueryServicecs : IOrderDetailsQueryService
    {


        List<OrderDetalis> ordersDetails;

        public OrderDetailsQueryServicecs()
        {

            ordersDetails = new List<OrderDetalis>();

            load();

        }

        public OrderDetailsQueryServicecs(List<OrderDetalis> ordersDetails)
        {
            this.ordersDetails = ordersDetails;
        }

        public void load()
        {

            string path = Application.StartupPath + @"\data\ordersDetalis.txt";

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
                if (ordersDetails[i].getIdUser() == idUser) myorderDetalis.Add(ordersDetails[i]);
            }

            return myorderDetalis;
        }

        public List<int> getByIdOrders(int idUser)
        {
            List<int> myorderDetalis = new List<int>();

            for (int i = 0; i < ordersDetails.Count; i++)
            {
                if (ordersDetails[i].getIdUser() == idUser) myorderDetalis.Add(ordersDetails[i].getIdProduct());
            }

            return myorderDetalis;
        }

        public OrderDetalis getByIdUserPro(int idUser, int idPro)
        {

            for (int i = 0; i < ordersDetails.Count; i++)
            {
                if (ordersDetails[i].getIdProduct() == idPro && ordersDetails[i].getIdUser() == idUser)
                {
                    return ordersDetails[i];
                }
            }

            return null;
        }


        public void save(List<OrderDetalis> orderDetalis)
        {
            this.ordersDetails = orderDetalis;
        }

        public OrderDetalis getById(int id)
        {
            for (int i = 0; i < ordersDetails.Count; i++)
            {
                if (ordersDetails[i].getId() == id) return ordersDetails[i];
            }

            return null;
        }
    }
}
