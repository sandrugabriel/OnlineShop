﻿using Bunifu.Framework.UI;
using OnlineShop.Favourites.Models;
using OnlineShop.Favourites.Service;
using OnlineShop.Favourites.Service.interfaces;
using OnlineShop.Models;
using OnlineShop.OrdersDetails.Service;
using OnlineShop.OrdersDetails.Service.interfaces;
using OnlineShop.Users.Models;
using OnlineShop.View.Panels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace OnlineShop.Panels
{
    public class PnlCard : Panel
    {


        private System.Windows.Forms.PictureBox pctFav;
        private PictureBox pctUnFav;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPRP;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Button btnAddCart;
        private Bunifu.Framework.UI.BunifuElipse eliCard;
        private BunifuElipse eliImage;

        private Form1 form;
        private User user;
        private Product product;
        private string path;
        private IFavouriteQueryService favouriteQueryService;
        private IFavouriteComandService favouriteComandService;

        List<Favourite> favourites = new List<Favourite>();

        IOrderDetailsComandService orderDetailsComandService;
        IOrderDetailsQueryService orderDetailsQueryService;

        List<OrderDetalis> orderDetalis;

        public PnlCard(Form1 form1, Product product1, User user1) {

            this.form = form1;
            this.user = user1;
            this.product = product1;

            favouriteQueryService = FavouriteQueryServiceSingleton.Instance;
            favouriteComandService = FavouriteComandServiceSingleton.Instance;

            orderDetailsComandService = OrderDetailsComandServiceSingleton.Instance;
            orderDetailsQueryService = OrderDetailsQueryServiceSingleton.Instance;

            orderDetalis = orderDetailsQueryService.getMyOrdersDetails(user.getId());  

            favourites = favouriteQueryService.getByIdClient(user.getId());

            path = Application.StartupPath + @"\Images\";

            //PnlCard
            this.Size = new System.Drawing.Size(336, 437);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PnlCard";
            this.Click += new EventHandler(this_Click);
            this.BackColor = System.Drawing.SystemColors.ControlLight;

            this.pctUnFav = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPRP = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.pctFav = new System.Windows.Forms.PictureBox();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.eliCard = new Bunifu.Framework.UI.BunifuElipse();
            this.eliImage = new BunifuElipse();    

            this.pctImage.Controls.Add(this.pctUnFav);
            this.Controls.Add(this.btnAddCart);
            this.pctImage.Controls.Add(this.pctFav);
            this.Controls.Add(this.pctImage);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPRP);
            this.Controls.Add(this.lblTile);

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(12, 350);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(110, 28);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = product.getPrice().ToString("F2") + "Lei";
            this.lblPrice.Click += new EventHandler(this_Click);

            //this.lblCountFav.BringToFront();

            // lblPRP
            this.lblPRP.AutoSize = true;
            this.lblPRP.BackColor = System.Drawing.Color.Transparent;
            this.lblPRP.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblPRP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPRP.Location = new System.Drawing.Point(13, 325);
            this.lblPRP.Name = "lblPRP";
            this.lblPRP.Size = new System.Drawing.Size(100, 20);
            this.lblPRP.Text = "PRP: " + (product.getPrice() * 1.5).ToString("F2") + "Lei";
            this.lblPRP.Click += new EventHandler(this_Click);

            // lblTile
            this.lblTile.AutoSize = false;
            this.lblTile.BackColor = System.Drawing.Color.Transparent;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.lblTile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTile.Location = new System.Drawing.Point(4, 240);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(333, 75);
            this.lblTile.Text = product.getName();
            this.lblTile.AutoEllipsis = true;
            this.lblTile.Click += new EventHandler(this_Click);

            // pctFav
            this.pctFav.Image = Image.FromFile(path + "fav.png");
            this.pctFav.BackColor = System.Drawing.Color.Transparent;
            this.pctFav.Location = new System.Drawing.Point(300, 12);
            this.pctFav.Name = "pctFav";
            this.pctFav.Size = new System.Drawing.Size(24, 28);
            this.pctFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFav.Click += new System.EventHandler(this.pctFav_Click);
            this.pctFav.Visible = false;

            // pctUnFav
            this.pctUnFav.Image = Image.FromFile(path + "unfav.png");
            this.pctUnFav.BackColor = System.Drawing.Color.Transparent;
            this.pctUnFav.Location = new System.Drawing.Point(300, 12);
            this.pctUnFav.Name = "pctFav";
            this.pctUnFav.Size = new System.Drawing.Size(24, 28);
            this.pctUnFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUnFav.Click += new System.EventHandler(this.pctUnFav_Click);
            this.pctUnFav.Visible = true;

            if (favourites != null)
                for (int i = 0; i < favourites.Count; i++)
                {
                    if (favourites[i].IdProduct == product.getId())
                    {
                        this.pctFav.Visible = true;
                        this.pctUnFav.Visible = false;

                    }
                }

            // pctImage
            this.pctImage.BackColor = System.Drawing.Color.White;
            this.pctImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pctImage.Image = Image.FromFile(path + @"Products\" + product.getPathImage());
            this.pctImage.Location = new System.Drawing.Point(6, 6);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(325, 229);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImage.Click += new EventHandler(this_Click);

            this.eliImage.TargetControl = pctImage;
            this.eliImage.ElipseRadius = 40;

            // btnAddCart
            this.btnAddCart.BackColor = System.Drawing.Color.Orange;
            this.btnAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddCart.FlatAppearance.BorderSize = 0;
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddCart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCart.Image = Image.FromFile(path + "addCart.png");
            this.btnAddCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCart.Location = new System.Drawing.Point(0, 390);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(336, 47);
            this.btnAddCart.TabIndex = 9;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);

            // eliCard
            this.eliCard.ElipseRadius = 35;
            this.eliCard.TargetControl = this;


            orderDetailsComandService.save(orderDetalis);
            orderDetailsQueryService.save(orderDetalis);
        }


        private void btnAddCart_Click(object sender, EventArgs e)
        {
            favouriteComandService.save(favourites);
            favouriteQueryService.save(favourites);

            orderDetailsComandService.save(orderDetalis);
            orderDetailsQueryService.save(orderDetalis);
            orderDetailsComandService.save(orderDetalis);
            orderDetailsQueryService.save(orderDetalis);
            string t = orderDetailsComandService.generareIdOrder().ToString() + "|" + user.getId().ToString() + "|" + product.getId().ToString() + "|" + 1;
            OrderDetalis order = new OrderDetalis(t);
            orderDetailsComandService.saveFisier(t);
            orderDetalis.Add(order);

            orderDetailsComandService.save(orderDetalis);

        }

        private void pctFav_Click(object sender, EventArgs e)
        {
            favouriteComandService.save(favourites);
            favouriteQueryService.save(favourites);

            this.pctFav.Visible = false;
            this.pctUnFav.Visible = true;

            Favourite favourite = favouriteQueryService.getByIdUserPro(user.getId(), product.getId());

            favouriteComandService.deleteCard(favourite);
           // favourites.RemoveAt(favouriteComandService.pozFavourite(favourite.Id));

        }

        private void pctUnFav_Click(object sender, EventArgs e)
        {

            this.pctFav.Visible = true;
            this.pctUnFav.Visible = false;

            int id = favouriteComandService.generareId();
            Favourite favourite = new Favourite(id, user.getId(), product.getId());

            favourites.Add(favourite);
            string t = id.ToString() + "|" + user.getId() + "|" + product.getId();
            favouriteComandService.saveFisier(t);
            string ct = favourites.Count().ToString();

            favouriteQueryService.save(favourites);
            favouriteComandService.save(favourites);

        }

        private void this_Click(object sender, EventArgs e)
        {
            this.form.removePnl("PnlHome");
            this.form.Controls.Add(new PnlView(form,user,product));
        }
    }
}
