using OnlineShop.Favourites.Service;
using OnlineShop.Models;
using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Panels
{
    public class PnlCards : Panel
    {

        Form1 form;
        public List<Product> products;
        User user;
        int nrCollom;

        public ComboBox cmbSort;
        Label lblSort;

        public PnlCards(int ct1, Form1 form1, List<Product> products1, User user1)
        {

            form = form1;
            products = products1;
            user = user1;

            this.Size = new System.Drawing.Size(1692, 855);
            this.AutoScroll = true;
            nrCollom = ct1;
            this.Location = new System.Drawing.Point(105, 126);
            
            this.Name = "PnlCards";

            cmbSort = new ComboBox();
            lblSort = new Label();


            // lblSort
            this.lblSort.AutoSize = true;
            this.lblSort.BackColor = System.Drawing.Color.Transparent;
            this.lblSort.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSort.Location = new System.Drawing.Point(163, 37);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(102, 31);
            this.lblSort.TabIndex = 10;
            this.lblSort.Text = "Sort by:";
             
            // cmbSort
            this.cmbSort.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular);
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Price: Low to High",
            "Price: High to Low"});
            this.cmbSort.Location = new System.Drawing.Point(271, 41);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(210, 100);
            this.cmbSort.Text = "Price: Low to High";

            createCard(nrCollom);
        }

        public void createCard(int nr)
        {
            this.Controls.Clear();

            this.Controls.Add(cmbSort);
            this.Controls.Add(lblSort);

            int x = 53, y = 135, ct = 0;

            foreach (Product p in products)
            {

                ct++;
                PnlCard pnlCard = new PnlCard(form, p, user);
                pnlCard.Location = new System.Drawing.Point(x, y);

                this.Controls.Add(pnlCard);
                x += 400;

                if (ct % nr == 0)
                {
                    x = 55;
                    y += 485;
                }
                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }
            }
        }

           



        }
    }
