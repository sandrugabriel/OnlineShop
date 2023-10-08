using OnlineShop.Favourites.Service;
using OnlineShop.Mockups;
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
        {

            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /*
                        FavouriteQueryService favouriteQueryService = new FavouriteQueryService();
                        favouriteQueryService.af();*/

        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]


        private static extern bool SetProcessDPIAware();


    }
}
