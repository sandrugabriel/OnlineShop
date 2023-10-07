﻿using OnlineShop.Panels;
using OnlineShop.Products.Service;
using OnlineShop.Products.Service.interfaces;
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

            this.Controls.Add(new PnlLogin(this));

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
