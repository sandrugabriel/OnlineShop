using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Orders.Service
{
    public class OrderQueryService : IOrderQueryService
    {

        List<Order> orders;

        public OrderQueryService() { 
        
            orders = new List<Order>();

            load();

        }

        public OrderQueryService(List<Order> orders)
        {
            this.orders = orders;
        }

        public void load()
        {

            string path = Application.StartupPath.Remove(44) + @"Orders\Data\orders.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while ((t = streamReader.ReadLine()) != null)
            {
                orders.Add(new Order(t));
            }

            streamReader.Close();
        }

        public List<Order> getAllOrders()
        {
            return orders;
        }

        public List<Order> getMyOrders(int idClient)
        {
            List<Order> myOrders = new List<Order>();
            for (int i = 0; i < orders.Count; i++)
            {

                if (orders[i].IdUser == idClient)
                {
                    myOrders.Add(orders[i]);
                }

            }

            return myOrders;
        }

        public Order getById(int id)
        {

            for (int i = 0; i < orders.Count; i++)
            {
                if (id == orders[i].Id)
                {
                    return orders[i];
                }
            }

            return null;
        }

    }
}
