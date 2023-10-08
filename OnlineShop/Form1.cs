using OnlineShop.Panels;
using OnlineShop.Products.Service;
using OnlineShop.Products.Service.interfaces;
using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class Form1 : Form {


        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1797, 981);
            User user = new User("1|Gabi|gabi@mail.com|gabi1234|0777777|Sadu, Livezi|17");
            this.Controls.Add(new PnlHome(this,user));

        }

        public void removePnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
