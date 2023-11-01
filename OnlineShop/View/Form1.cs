using OnlineShop.Models;
using OnlineShop.Panels;
using OnlineShop.Products.Service;
using OnlineShop.Products.Service.interfaces;
using OnlineShop.Users.Models;
using OnlineShop.View.Panels.Admin;
using OnlineShop.View.Panels.Customer;
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

        public int ct = 0, ct1 = 0, ct3 = 0;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1797, 981);
            User user = new User("1|Gabi|gabi@mail.com|gabi1234|0777777|Sadu, Livezi|17|admin");

            this.pictureBox1.SendToBack(); 
            this.Controls.Add(new PnlLogin(this));
            this.pictureBox1.SendToBack();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
