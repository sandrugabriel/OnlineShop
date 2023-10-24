using OnlineShop.Models;
using OnlineShop.Products.Service;
using OnlineShop.Products.Service.interfaces;
using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.View.Panels.Admin
{
    public class PnlEditProducts : Panel
    {

        Label lblProduct;
        PictureBox pctDesign1;

        Form1 form;

        IProductQueryService queryService;

        List<Product> products;

        PnlSlideBarAdmin pnlSlide;

        public PnlEditProducts(Form1 form1) {

            form = form1;

            queryService = ProductQueryServiceSingleton.Instance;

            products = queryService.getAll();

            this.Name = "PnlEditProducts";
            this.Size = new System.Drawing.Size(1797, 981);
        
            lblProduct = new Label();
            pctDesign1 = new PictureBox();
            pnlSlide = new PnlSlideBarAdmin(form);
            
            //lblProduct
            this.lblProduct.Location = new System.Drawing.Point(426, 9);
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Century Gothic", 25);
            this.lblProduct.Text = "Products";

            //pctdesign1
            this.pctDesign1.Location = new System.Drawing.Point(423, 63);
            this.pctDesign1.Size = new System.Drawing.Size(235, 2);
            this.pctDesign1.BackColor = System.Drawing.Color.Black;

            createCard(4);

        }

        public void createCard(int nr)
        {

            this.Controls.Clear();

            this.Controls.Add(lblProduct);
            this.Controls.Add(pctDesign1);
            this.form.Controls.Add(pnlSlide);

            pnlSlide.Dock = DockStyle.Left;
            pnlSlide.BringToFront();

            int x = 193, y = 144, ct = 0;

            foreach (Product p in products)
            {
                ct++;
                PnlAdminCardProduct pnlCard = new PnlAdminCardProduct(form, p);
                pnlCard.Location = new System.Drawing.Point(x,y);

                this.Controls.Add(pnlCard);

                x += 400;

                if (ct % nr == 0)
                {
                    x = 193;
                    y += 500;
                }

                if(y> this.Height)
                {
                    this.AutoScroll = true;
                }

            }

        }

    }
}
