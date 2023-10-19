using OnlineShop.Favourites.Service;
using OnlineShop.Mockups;
using OnlineShop.Orders;
using OnlineShop.OrdersDetails.Service;
using OnlineShop.Products;
using OnlineShop.View.Mockups;
using OnlineShop.View.Mockups.Admin;
using Siticone.Desktop.UI.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.IO;
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
            

        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]


        private static extern bool SetProcessDPIAware();


    }
}
