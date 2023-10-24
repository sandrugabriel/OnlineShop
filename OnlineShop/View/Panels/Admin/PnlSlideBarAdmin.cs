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

        Button btnClient;
        Button btnProducts;
        Button btnOrders;
        Button btnTopOrderd;
        Button btnTopFav;

        PictureBox pctClient;
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

            this.btnClient = new Button();
            this.btnProducts = new Button();
            this.btnOrders = new Button();
            this.btnTopOrderd = new Button();
            this.btnTopFav = new Button();
            this.pctMenu = new PictureBox();
            this.pctDesign = new PictureBox();
            this.pctSignOut = new PictureBox();
            this.pctClient = new PictureBox();
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

            this.Controls.Add(btnClient);
            this.Controls.Add(btnProducts);
            this.Controls.Add(btnOrders);
            this.Controls.Add(btnTopOrderd);
            this.Controls.Add(btnTopFav);
            this.Controls.Add(pctMenu);
            this.Controls.Add(pctDesign);
            this.Controls.Add(pctSignOut);
            this.btnClient.Controls.Add(pctClient);
            this.btnProducts.Controls.Add(pctProducts);
            this.btnOrders.Controls.Add(pctOrders);
            this.btnTopOrderd.Controls.Add(pctTopOrderd);
            this.btnTopFav.Controls.Add(pctTopFav);
            this.Controls.Add(lblMenu);
            this.Controls.Add(lblSignOut);

            //btnClient
            this.btnClient.Location = new System.Drawing.Point(12, 148);
            this.btnClient.Text = "         Edit Cont Client";
            this.btnClient.Size = new System.Drawing.Size(386, 65);
            this.btnClient.Font = new Font("Century Gothic", 14);
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = FlatStyle.Flat;
            this.btnClient.BackColor = Color.Transparent;
            this.btnClient.ForeColor = Color.White;
            this.btnClient.Image = Image.FromFile(Application.StartupPath + @"/Images/dreapta.png");
            this.btnClient.ImageAlign = ContentAlignment.MiddleRight;
            this.btnClient.TextAlign = ContentAlignment.MiddleLeft;
            this.btnClient.Cursor = Cursors.Hand;
            this.btnClient.Click += new EventHandler(btnClient_Click);

            //btnProducts
            this.btnProducts.Location = new System.Drawing.Point(12,btnClient.Location.Y +btnClient.Size.Height + 15 );
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

            //btnOrders
            this.btnOrders.Location = new System.Drawing.Point(12, btnProducts.Location.Y + btnProducts.Size.Height + 15);
            this.btnOrders.Text = "         Edit Orders";
            this.btnOrders.Size = new System.Drawing.Size(386, 65);
            this.btnOrders.Font = new Font("Century Gothic", 14);
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = FlatStyle.Flat;
            this.btnOrders.BackColor = Color.Transparent;
            this.btnOrders.ForeColor = Color.White;
            this.btnOrders.Image = Image.FromFile(Application.StartupPath + @"/Images/dreapta.png");
            this.btnOrders.ImageAlign = ContentAlignment.MiddleRight;
            this.btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            this.btnOrders.Cursor = Cursors.Hand;
            this.btnOrders.Click += new EventHandler(btnOrders_Click);

            //btnTopOrderd
            this.btnTopOrderd.Location = new System.Drawing.Point(12, btnOrders.Location.Y + btnOrders.Size.Height + 15);
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

            //pctClient
            this.pctClient.Size = new System.Drawing.Size(54, 54);
            this.pctClient.Location = new System.Drawing.Point(0,5);
            this.pctClient.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctClient.Image = Image.FromFile(Application.StartupPath + @"/Images/it.png");
            this.pctSignOut.Cursor = Cursors.Hand;

            //pctProduct
            this.pctProducts.Size = new System.Drawing.Size(54, 54);
            this.pctProducts.Location = new System.Drawing.Point(0, 5);
            this.pctProducts.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctProducts.Image = Image.FromFile(Application.StartupPath + @"/Images/it.png");
            this.pctSignOut.Cursor = Cursors.Hand;

            //pctOrders
            this.pctOrders.Size = new System.Drawing.Size(54, 54);
            this.pctOrders.Location = new System.Drawing.Point(0, 5);
            this.pctOrders.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctOrders.Image = Image.FromFile(Application.StartupPath + @"/Images/it.png");
            this.pctOrders.Cursor = Cursors.Hand;

            //pctTopOrderd
            this.pctTopOrderd.Size = new System.Drawing.Size(54, 54);
            this.pctTopOrderd.Location = new System.Drawing.Point(0, 5);
            this.pctTopOrderd.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctTopOrderd.Image = Image.FromFile(Application.StartupPath + @"/Images/it.png");
            this.pctTopOrderd.Cursor = Cursors.Hand;

            //pctTopFav
            this.pctTopFav.Size = new System.Drawing.Size(54, 54);
            this.pctTopFav.Location = new System.Drawing.Point(0, 5);
            this.pctTopFav.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctTopFav.Image = Image.FromFile(Application.StartupPath + @"/Images/it.png");
            this.pctTopFav.Cursor = Cursors.Hand;

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

        private void btnClient_Click(object sender, EventArgs e)
        {



        }

        private void btnProducts_Click(object sender, EventArgs e)
        {



        }

        private void btnOrders_Click(object sender, EventArgs e)
        {


        }

        private void btnTopOrderd_Click(object sender, EventArgs e)
        {


        }

        private void btnTopFav_Click(object sender, EventArgs e)
        {


        }

    }
}
