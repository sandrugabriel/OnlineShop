using OnlineShop.Models;
using OnlineShop.Panels;
using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.View.Panels
{
    public class PnlFavorites : Panel
    {


        Form1 form;
        public List<Product> products;
        User user;


        private System.Windows.Forms.Label lblFav;
        private System.Windows.Forms.PictureBox pctDesign1;

        public PnlFavorites(Form1 form, User user1, List<Product> products1)
        {
            this.form = form;
            this.user = user1;

            this.products = products1;

            this.Size = new System.Drawing.Size(1692, 855);
            this.AutoScroll = true;
            this.Location = new System.Drawing.Point(105, 126);
          //  this.BackColor = System.Drawing.Color.Red;
            this.Name = "PnlFavourites";

            this.pctDesign1 = new System.Windows.Forms.PictureBox();
            this.lblFav = new System.Windows.Forms.Label();

            // pctDesign1
            this.pctDesign1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctDesign1.Location = new System.Drawing.Point(33, 101);
            this.pctDesign1.Name = "pctDesign1";
            this.pctDesign1.Size = new System.Drawing.Size(235, 2);
            this.pctDesign1.TabIndex = 2;
            this.pctDesign1.TabStop = false;

            // lblFav
            this.lblFav.AutoSize = true;
            this.lblFav.BackColor = System.Drawing.Color.Transparent;
            this.lblFav.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular);
            this.lblFav.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFav.Location = new System.Drawing.Point(54, 50);
            this.lblFav.Name = "lblFav";
            this.lblFav.Size = new System.Drawing.Size(202, 51);
            this.lblFav.TabIndex = 1;
            this.lblFav.Text = "Favorites";

            createCard();
        }

        public void createCard()
        {
            this.Controls.Clear();

            this.Controls.Add(lblFav);
            this.Controls.Add(pctDesign1);

            int x = 25, y = 135, ct = 0;

            foreach (Product p in products)
            {

                ct++;
                PnlCardFav pnlCard = new PnlCardFav(form, p, user);
                pnlCard.Location = new System.Drawing.Point(x, y);

                this.Controls.Add(pnlCard);
                x += 400;

                if (ct % 1 == 0)
                {
                    x = 25;
                    y += 300;
                }
                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }
            }
        }
    }
}
