using OnlineShop.Panels;
using Siticone.Desktop.UI.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.View.Panels.Admin
{
    public class PnlSlideBarAdmin : Panel
    {

        Button btnAddProduct;
        Button btnProducts;
        Button btnTopOrderd;
        Button btnTopFav;

        PictureBox pctAdd;
        PictureBox pctProducts;
        PictureBox pctOrders;
        PictureBox pctTopOrderd;
        PictureBox pctTopFav;
        PictureBox pctMenu;
        PictureBox pctDesign;
        PictureBox pctSignOut;

        Label lblMenu;
        Label lblSignOut;

        Form1 form;
        bool sidebar;
        Timer timeSlideMenu;
        public PnlSlideBarAdmin(Form1 form1)
        {

            this.form = form1;

            this.Name = "PnlSlideBar";
            this.Size = new System.Drawing.Size(0, 981);
            this.MinimumSize = new Size(85, 981);
            this.MaximumSize = new Size(398, 981);
            this.Dock = DockStyle.Left;
            this.BackColor = Color.FromArgb(18, 18, 39);
            this.Font = new Font("Century Gothic", 14);

            this.btnAddProduct = new Button();
            this.btnProducts = new Button();
            this.btnTopOrderd = new Button();
            this.btnTopFav = new Button();
            this.pctMenu = new PictureBox();
            this.pctDesign = new PictureBox();
            this.pctSignOut = new PictureBox();
            this.pctAdd = new PictureBox();
            this.pctProducts = new PictureBox();
            this.pctOrders = new PictureBox();
            this.pctTopOrderd = new PictureBox();
            this.pctTopFav = new PictureBox();
            this.lblMenu = new Label();
            this.lblSignOut = new Label();
            this.timeSlideMenu = new Timer();

            timeSlideMenu.Interval = 10;
            timeSlideMenu.Tick += timeSlideMenu_Tick;
           // timeSlideMenu.Start();

            this.Controls.Add(btnAddProduct);
            this.Controls.Add(btnProducts);
            this.Controls.Add(btnTopOrderd);
            this.Controls.Add(btnTopFav);
            this.Controls.Add(pctMenu);
            this.Controls.Add(pctDesign);
            this.Controls.Add(pctSignOut);
            this.btnAddProduct.Controls.Add(pctAdd);
            this.btnProducts.Controls.Add(pctProducts);
            this.btnTopOrderd.Controls.Add(pctTopOrderd);
            this.btnTopFav.Controls.Add(pctTopFav);
            this.Controls.Add(lblMenu);
            this.Controls.Add(lblSignOut);

            //btnAddProduct
            this.btnAddProduct.Location = new System.Drawing.Point(12, 148);
            this.btnAddProduct.Text = "         Add Product";
            this.btnAddProduct.Size = new System.Drawing.Size(386, 65);
            this.btnAddProduct.Font = new Font("Century Gothic", 14);
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = FlatStyle.Flat;
            this.btnAddProduct.BackColor = Color.Transparent;
            this.btnAddProduct.ForeColor = Color.White;
            this.btnAddProduct.Image = Image.FromFile(Application.StartupPath + @"/Images/dreapta.png");
            this.btnAddProduct.ImageAlign = ContentAlignment.MiddleRight;
            this.btnAddProduct.TextAlign = ContentAlignment.MiddleLeft;
            this.btnAddProduct.Cursor = Cursors.Hand;
            this.btnAddProduct.Click += new EventHandler(btnAddProduct_Click);

            //btnProducts
            this.btnProducts.Location = new System.Drawing.Point(12,btnAddProduct.Location.Y +btnAddProduct.Size.Height + 15 );
            this.btnProducts.Text = "         Edit Products";
            this.btnProducts.Size = new System.Drawing.Size(386, 65);
            this.btnProducts.Font = new Font("Century Gothic", 14);
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = FlatStyle.Flat;
            this.btnProducts.BackColor = Color.Transparent;
            this.btnProducts.ForeColor = Color.White;
            this.btnProducts.Image = Image.FromFile(Application.StartupPath + @"/Images/dreapta.png");
            this.btnProducts.ImageAlign = ContentAlignment.MiddleRight;
            this.btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            this.btnProducts.Cursor = Cursors.Hand;
            this.btnProducts.Click += new EventHandler(btnProducts_Click);

            //btnTopOrderd
            this.btnTopOrderd.Location = new System.Drawing.Point(12, btnProducts.Location.Y + btnProducts.Size.Height + 15);
            this.btnTopOrderd.Text = "         Top Products Orderd";
            this.btnTopOrderd.Size = new System.Drawing.Size(386, 65);
            this.btnTopOrderd.Font = new Font("Century Gothic", 14);
            this.btnTopOrderd.FlatAppearance.BorderSize = 0;
            this.btnTopOrderd.FlatStyle = FlatStyle.Flat;
            this.btnTopOrderd.BackColor = Color.Transparent;
            this.btnTopOrderd.ForeColor = Color.White;
            this.btnTopOrderd.Image = Image.FromFile(Application.StartupPath + @"/Images/dreapta.png");
            this.btnTopOrderd.ImageAlign = ContentAlignment.MiddleRight;
            this.btnTopOrderd.TextAlign = ContentAlignment.MiddleLeft;
            this.btnTopOrderd.Cursor = Cursors.Hand;
            this.btnTopOrderd.Click += new EventHandler(btnTopOrderd_Click);

            //btnTopFav
            this.btnTopFav.Location = new System.Drawing.Point(12, btnTopOrderd.Location.Y + btnTopOrderd.Size.Height + 15);
            this.btnTopFav.Text = "         Top Favorite Products";
            this.btnTopFav.Size = new System.Drawing.Size(386, 65);
            this.btnTopFav.Font = new Font("Century Gothic", 14);
            this.btnTopFav.FlatAppearance.BorderSize = 0;
            this.btnTopFav.FlatStyle = FlatStyle.Flat;
            this.btnTopFav.BackColor = Color.Transparent;
            this.btnTopFav.ForeColor = Color.White;
            this.btnTopFav.Image = Image.FromFile(Application.StartupPath + @"/Images/dreapta.png");
            this.btnTopFav.ImageAlign = ContentAlignment.MiddleRight;
            this.btnTopFav.TextAlign = ContentAlignment.MiddleLeft;
            this.btnTopFav.Cursor = Cursors.Hand;
            this.btnTopFav.Click += new EventHandler(btnTopFav_Click);

            //pctAdd
            this.pctAdd.Size = new System.Drawing.Size(54, 54);
            this.pctAdd.Location = new System.Drawing.Point(3,5);
            this.pctAdd.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctAdd.Image = Image.FromFile(Application.StartupPath + @"/Images/AddProduct.png");
            this.pctAdd.Cursor = Cursors.Hand;
            this.pctAdd.Click += new EventHandler(btnAddProduct_Click);

            //pctProduct
            this.pctProducts.Size = new System.Drawing.Size(54, 54);
            this.pctProducts.Location = new System.Drawing.Point(0, 5);
            this.pctProducts.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctProducts.Image = Image.FromFile(Application.StartupPath + @"/Images/Edit.png");
            this.pctProducts.Cursor = Cursors.Hand;
            this.pctProducts.Click += new EventHandler(btnProducts_Click);

            //pctTopOrderd
            this.pctTopOrderd.Size = new System.Drawing.Size(54, 54);
            this.pctTopOrderd.Location = new System.Drawing.Point(0, 5);
            this.pctTopOrderd.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctTopOrderd.Image = Image.FromFile(Application.StartupPath + @"/Images/topOrder.png");
            this.pctTopOrderd.Cursor = Cursors.Hand;
            this.pctTopOrderd.Click += new EventHandler(btnTopOrderd_Click);

            //pctTopFav
            this.pctTopFav.Size = new System.Drawing.Size(54, 54);
            this.pctTopFav.Location = new System.Drawing.Point(0, 5);
            this.pctTopFav.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctTopFav.Image = Image.FromFile(Application.StartupPath + @"/Images/topFav.png");
            this.pctTopFav.Cursor = Cursors.Hand;
            this.pctTopFav.Click += new EventHandler(btnTopFav_Click);

            //pctMenu
            this.pctMenu.Size = new System.Drawing.Size(62, 45);
            this.pctMenu.Location = new System.Drawing.Point(15, 34);
            this.pctMenu.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctMenu.Image = Image.FromFile(Application.StartupPath + @"/Images/menu.png");
            this.pctMenu.Cursor = Cursors.Hand;
            this.pctMenu.Click += new EventHandler(pctMenu_Click);

            //lblMenu
            this.lblMenu.Text = "Menu";
            this.lblMenu.Font = new Font("Century Gothic", 22);
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(123, 29);
            this.lblMenu.ForeColor = Color.White;

            //pctDesign
            this.pctDesign.Size = new System.Drawing.Size(347, 1);
            this.pctDesign.Location = new System.Drawing.Point(106, 78);
            this.pctDesign.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctDesign.BackColor = Color.White;

            //pctSign
            this.pctSignOut.Size = new System.Drawing.Size(54, 54);
            this.pctSignOut.Location = new System.Drawing.Point(15, 901);
            this.pctSignOut.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctSignOut.Image = Image.FromFile(Application.StartupPath + @"/Images/exit.png");
            this.pctSignOut.Cursor = Cursors.Hand;
            this.pctSignOut.Click += new EventHandler(pctSignOut_Click);

            //lblSignOut
            this.lblSignOut.Text = "Sign Out";
            this.lblSignOut.Font = new Font("Century Gothic", 16);
            this.lblSignOut.AutoSize = true;
            this.lblSignOut.Location = new System.Drawing.Point(100, 912);
            this.lblSignOut.ForeColor = Color.White;
            this.lblSignOut.Cursor = Cursors.Hand;
            this.lblSignOut.Click += new EventHandler(pctSignOut_Click);

           // timeSlideMenu.Start();
        }

        private void timeSlideMenu_Tick(object sender, EventArgs e)
        {

            if (sidebar)
            {
                this.Width -= 10;
                if (this.Width == this.MinimumSize.Width)
                {
                    sidebar = false;
                    timeSlideMenu.Stop();

                }

            }
            else
            {
                this.Width += 10;
                if (this.Width == this.MaximumSize.Width)
                {
                    sidebar = true;
                    timeSlideMenu.Stop();

                }
            }

        }

        private void pctSignOut_Click(object sender, EventArgs e)
        {
            this.form.Controls.Clear();
            this.form.Controls.Add(new PnlLogin(form));
        }

        private void pctMenu_Click(object sender, EventArgs e)
        {
            timeSlideMenu.Start();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            this.form.Controls.Clear(); 
            this.form.Controls.Add(new PnlAddProduct(form));

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

            this.form.Controls.Clear();
            this.form.Controls.Add(new PnlEditProducts(form));

        }

        private void btnTopOrderd_Click(object sender, EventArgs e)
        {

            this.form.Controls.Clear();
            this.form.removePnl("PnlAddProduct");
            this.form.Controls.Add(new PnlTopOrder(form));

        }

        private void btnTopFav_Click(object sender, EventArgs e)
        {
            this.form.Controls.Clear();
            this.form.removePnl("PnlAddProduct");
            this.form.Controls.Add(new PnlTopFav(form));

        }

    }
}
