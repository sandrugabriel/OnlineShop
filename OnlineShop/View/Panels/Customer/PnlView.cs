using OnlineShop.Favourites.Models;
using OnlineShop.Favourites.Service;
using OnlineShop.Favourites.Service.interfaces;
using OnlineShop.Models;
using OnlineShop.OrdersDetails.Service;
using OnlineShop.OrdersDetails.Service.interfaces;
using OnlineShop.Panels;
using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.View.Panels
{

    public class PnlView : Panel
    {


        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.PictureBox pctBack;
        private System.Windows.Forms.Button btnFav;
        private System.Windows.Forms.Button btncart;
        private Bunifu.Framework.UI.BunifuElipse eliCart;
        private Bunifu.Framework.UI.BunifuElipse eliFav;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPRP;
        private System.Windows.Forms.Label lblPiexl;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.PictureBox pctDesign;
        private System.Windows.Forms.Label lblDescriere;
        private Button btnUnFav;
        private PictureBox pctClose;
        private Bunifu.Framework.UI.BunifuElipse eliunfavt;

        Form1 form;
        User user;
        Product product;

        private IFavouriteQueryService favouriteQueryService;
        private IFavouriteComandService favouriteComandService;

        List<Favourite> favourites = new List<Favourite>();

        IOrderDetailsComandService orderDetailsComandService;
        IOrderDetailsQueryService orderDetailsQueryService;

        List<OrderDetalis> orderDetalis;

        public PnlView(Form1 form1, User user1, Product product1)
        {
            form = form1;
            user = user1;
            product = product1;

            favouriteQueryService = FavouriteQueryServiceSingleton.Instance;
            favouriteComandService = FavouriteComandServiceSingleton.Instance;

            orderDetailsComandService = OrderDetailsComandServiceSingleton.Instance;
            orderDetailsQueryService = OrderDetailsQueryServiceSingleton.Instance;

            orderDetalis = orderDetailsQueryService.getMyOrdersDetails(user.getId());

            favourites = favouriteQueryService.getByIdClient(user.getId());

            //PnlView
            this.AutoScroll = true;
            this.Size = new System.Drawing.Size(1818, 1002);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlView";

            eliunfavt = new Bunifu.Framework.UI.BunifuElipse();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.btnUnFav = new System.Windows.Forms.Button();
            this.btncart = new System.Windows.Forms.Button();
            this.btnFav = new System.Windows.Forms.Button();
            this.pctBack = new System.Windows.Forms.PictureBox();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.eliCart = new Bunifu.Framework.UI.BunifuElipse();
            this.eliFav = new Bunifu.Framework.UI.BunifuElipse();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPRP = new System.Windows.Forms.Label();
            this.lblPiexl = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.pctDesign = new System.Windows.Forms.PictureBox();
            this.lblDescriere = new System.Windows.Forms.Label();

            this.Controls.Add(this.pctDesign);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.lblPiexl);
            this.Controls.Add(this.lblPRP);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btncart);
            this.Controls.Add(this.btnFav);
            this.Controls.Add(this.btnUnFav);
            this.Controls.Add(this.pctClose);
            this.Controls.Add(this.pctBack);
            this.Controls.Add(this.pctImage);

            // btncart
            this.btncart.BackColor = System.Drawing.Color.Orange;
            this.btncart.FlatAppearance.BorderSize = 0;
            this.btncart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncart.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.btncart.Image = Image.FromFile(Application.StartupPath + @"/Images/addCart.png");
            this.btncart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncart.Location = new System.Drawing.Point(1290, 380);
            this.btncart.Name = "btncart";
            this.btncart.Size = new System.Drawing.Size(369, 104);
            this.btncart.TabIndex = 1;
            this.btncart.Text = "Add to Cart";
            this.btncart.Click += new EventHandler(btncart_Click);
             
            // btnFav
            this.btnFav.BackColor = System.Drawing.Color.Wheat;
            this.btnFav.FlatAppearance.BorderSize = 0;
            this.btnFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFav.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.btnFav.Image = Image.FromFile(Application.StartupPath + @"/Images/10.png");
            this.btnFav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFav.Location = new System.Drawing.Point(1290, 261);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(369, 104);
            this.btnFav.TabIndex = 1;
            this.btnFav.Text = "     Add to Favourite";
            this.btnFav.Click += new EventHandler(btnFav_Click);
            this.btnFav.Visible = true;

            // btnUnFav
            this.btnUnFav.BackColor = System.Drawing.Color.Wheat;
            this.btnUnFav.FlatAppearance.BorderSize = 0;
            this.btnUnFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnFav.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.btnUnFav.Image = Image.FromFile(Application.StartupPath + @"/Images/11.png");
            this.btnUnFav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnFav.Location = new System.Drawing.Point(1290, 261);
            this.btnUnFav.Name = "btnFav";
            this.btnUnFav.Size = new System.Drawing.Size(369, 104);
            this.btnUnFav.TabIndex = 1;
            this.btnUnFav.Text = "  Remove to Favourite";
            this.btnUnFav.Click += new EventHandler(btnUnFav_Click);
            this.btnUnFav.Visible = false;

            if (favourites != null)
                for (int i = 0; i < favourites.Count; i++)
                {
                    if (favourites[i].IdProduct == product.getId())
                    {
                        this.btnUnFav.Visible = true;
                        this.btnFav.Visible = false;

                    }
                }

            // pctBack
            this.pctBack.Image = Image.FromFile(Application.StartupPath + @"/Images/back.png");
            this.pctBack.Location = new System.Drawing.Point(30, 17);
            this.pctBack.Name = "pctBack";
            this.pctBack.Size = new System.Drawing.Size(67, 61);
            this.pctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBack.Click += new EventHandler(pctBack_Click);
             
            // pctImage
            this.pctImage.Location = new System.Drawing.Point(30, 116);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(436, 368);
            this.pctImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctImage.Image = Image.FromFile(Application.StartupPath + $@"/Images/Products/{product.getPathImage()}");
             
            // eliCart
            this.eliCart.ElipseRadius = 30;
            this.eliCart.TargetControl = this.btncart;

            // eliCart
            this.eliunfavt.ElipseRadius = 30;
            this.eliunfavt.TargetControl = this.btnUnFav;

            // eliFav
            this.eliFav.ElipseRadius = 30;
            this.eliFav.TargetControl = this.btnFav;
             
            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(1351, 134);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(245, 49);
            this.lblPrice.Text = product.getPrice().ToString("F2")+" Lei";
            
            // lblPRP
            this.lblPRP.AutoSize = true;
            this.lblPRP.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular);
            this.lblPRP.ForeColor = System.Drawing.Color.DimGray;
            this.lblPRP.Location = new System.Drawing.Point(1354, 195);
            this.lblPRP.Name = "lblPRP";
            this.lblPRP.Size = new System.Drawing.Size(180, 33);
            this.lblPRP.TabIndex = 2;
            this.lblPRP.Text = "PRP: " + (product.getPrice() * 1.5).ToString("F2") + "Lei";
             
            // lblPiexl
            this.lblPiexl.AutoSize = true;
            this.lblPiexl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular);
            this.lblPiexl.ForeColor = System.Drawing.Color.Black;
            this.lblPiexl.Location = new System.Drawing.Point(498, 232);
            this.lblPiexl.Name = "lblPiexl";
            this.lblPiexl.Size = new System.Drawing.Size(269, 23);
            this.lblPiexl.TabIndex = 2;
            this.lblPiexl.Text = "Sold and Shipped by: Pixel";
             
            // lblDelivery
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular);
            this.lblDelivery.ForeColor = System.Drawing.Color.Black;
            this.lblDelivery.Location = new System.Drawing.Point(496, 179);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(155, 31);
            this.lblDelivery.TabIndex = 2;
            this.lblDelivery.Text = "Delivery in: " + user.getAddress();
            
            // lblTile
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular);
            this.lblTile.ForeColor = System.Drawing.Color.Black;
            this.lblTile.Location = new System.Drawing.Point(22, 551);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(560, 44);
            this.lblTile.TabIndex = 2;
            this.lblTile.Text = "Description and Specifications";
             
            // pctDesign
            this.pctDesign.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctDesign.Location = new System.Drawing.Point(12, 596);
            this.pctDesign.Name = "pctDesign";
            this.pctDesign.Size = new System.Drawing.Size(603, 2);
             
            // lblDescriere
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular);
            this.lblDescriere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescriere.Location = new System.Drawing.Point(56, 623);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(455, 217);
            this.lblDescriere.TabIndex = 2;
            this.lblDescriere.Text = File.ReadAllText(Application.StartupPath + @"\descriere\" + $"{product.getId()}.txt");
           
            // pctClose
            this.pctClose.Image = global::OnlineShop.Properties.Resources.left_arrow;
            this.pctClose.Location = new System.Drawing.Point(1739, 17);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(67, 61);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClose.TabIndex = 0;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.pctClose_Click);
        }

        private void pctClose_Click(object sender, System.EventArgs e)
        {
            this.form.Close();
        }

        private void btncart_Click(object sender, EventArgs e)
        {

            string t = orderDetailsComandService.generareIdOrder().ToString() + "|" + user.getId().ToString() + "|" + product.getId().ToString() + "|" + 1;
            OrderDetalis order = new OrderDetalis(t);
            orderDetailsComandService.saveFisier(t);
            orderDetalis.Add(order);

            orderDetailsComandService.save(orderDetalis);
        }

        private void btnFav_Click(object sender, EventArgs e)
        {


            this.btnUnFav.Visible = true;
            this.btnFav.Visible = false;
            Favourite favourite = new Favourite(favouriteComandService.generareId(), user.getId(), product.getId());

            favourites.Add(favourite);
            favouriteQueryService.save(favourites);
            favouriteComandService.save(favourites);
            string t = favouriteComandService.generareId() + "|" + user.getId() + "|" + product.getId();
            favouriteComandService.saveFisier(t);
            string ct = favourites.Count().ToString();


        }

        private void pctBack_Click(object sender, EventArgs e)
        {

            this.form.removePnl("PnlView");
            this.form.Controls.Add(new PnlHome(form,user));
        
        }

        private void btnUnFav_Click(object sender, EventArgs e)
        {

            this.btnUnFav.Visible = false;
            this.btnFav.Visible = true;

            Favourite favourite = favouriteQueryService.getByIdUserPro(user.getId(), product.getId());

            favouriteComandService.deleteCard(favourite);

        }

    }
}
