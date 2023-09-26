using OnlineShop.Orders;
using OnlineShop.OrdersDetails.Service;
using OnlineShop.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {/*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
/*
            ControllerProducts controllerProducts = new ControllerProducts();
            controllerProducts.afisare();
*/
            /*
                        ControllerOrders controllerOrders = new ControllerOrders();
                        controllerOrders.afisare();*/

            ServiceOrderDetails controllerOrderDetails = new ServiceOrderDetails();
            controllerOrderDetails.afisare();

        }
    }
}
