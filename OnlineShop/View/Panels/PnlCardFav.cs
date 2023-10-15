using Bunifu.Framework.UI;
using OnlineShop.Favourites.Models;
using OnlineShop.Favourites.Service;
using OnlineShop.Favourites.Service.interfaces;
using OnlineShop.Models;
using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.View.Panels
{
    public class PnlCardFav : Panel
    {

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPRP;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.PictureBox pctImage;

        private Form1 form;
        private User user;
        private Product product;

        private IFavouriteQueryService favouriteQueryService;
        private IFavouriteComandService favouriteComandService;
        private string path;

        List<Favourite> favourites = new List<Favourite>();

        BunifuElipse eliImage;
        BunifuElipse eliThis;

        public PnlCardFav(Form1 form1, Product product1, User user1) {


            this.form = form1;
            this.user = user1;
            this.product = product1;


            favouriteQueryService = FavouriteQueryServiceSingleton.Instance;
            favouriteComandService = FavouriteComandServiceSingleton.Instance;

            favourites = favouriteQueryService.getByIdClient(user.getId());

            path = Application.StartupPath + @"\Images\";

            //PnlCardFav
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Size = new System.Drawing.Size(1600, 216);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlCardFav";

            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPRP = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            eliImage = new BunifuElipse();
            eliThis = new BunifuElipse();
            this.pctImage = new System.Windows.Forms.PictureBox();

            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pctImage);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPRP);

            // btnRemove
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRemove.Image = Image.FromFile(path + @"remove.png");
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(1425, 158);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 36);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "    Remove";
            this.btnRemove.Click += new EventHandler(btnRemove_Click);
             
            // btnAddCart
            this.btnAddCart.BackColor = System.Drawing.Color.Orange;
            this.btnAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCart.FlatAppearance.BorderSize = 0;
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCart.Image = Image.FromFile(path + @"favCart.png");
            this.btnAddCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCart.Location = new System.Drawing.Point(1400, 105);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(174, 47);
            this.btnAddCart.TabIndex = 2;
            this.btnAddCart.Text = "      Add to Cart";
             
            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(1405, 55);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(140, 37);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = product.getPrice().ToString("F2") + "Lei";
             
            // lblPRP
            this.lblPRP.AutoSize = true;
            this.lblPRP.BackColor = System.Drawing.Color.Transparent;
            this.lblPRP.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular);
            this.lblPRP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPRP.Location = new System.Drawing.Point(1410, 31);
            this.lblPRP.Name = "lblPRP";
            this.lblPRP.Size = new System.Drawing.Size(121, 21);
            this.lblPRP.TabIndex = 1;
            this.lblPRP.Text = "PRP: " + (product.getPrice() * 1.5).ToString("F2") + "Lei";
             
            // lblTile
            this.lblTile.AutoSize = false;
            this.lblTile.BackColor = System.Drawing.Color.Transparent;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.lblTile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTile.Location = new System.Drawing.Point(446, 52);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(921, 125);
            this.lblTile.Text = product.getName();
            this.lblTile.AutoEllipsis = true;

            // pctImage
            this.pctImage.BackColor = System.Drawing.Color.White;
            this.pctImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pctImage.Image = Image.FromFile(path + @"Products\" + product.getPathImage());
            this.pctImage.Location = new System.Drawing.Point(12, 7);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(386, 194);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.eliImage.TargetControl = pctImage;
            this.eliImage.ElipseRadius = 25;

            this.eliThis.TargetControl = this;
            this.eliThis.ElipseRadius = 25;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            Favourite favourite = favouriteQueryService.getByIdUserPro(user.getId(), product.getId());

            favouriteComandService.deleteCard(favourite);
            favouriteComandService.save(favourites);
            this.Visible = false;
        }

    }
}
