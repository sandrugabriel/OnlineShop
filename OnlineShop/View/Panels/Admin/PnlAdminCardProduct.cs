using Bunifu.Framework.UI;
using OnlineShop.Models;
using OnlineShop.Products.Service;
using OnlineShop.Products.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.View.Panels.Admin
{
    public class PnlAdminCardProduct : Panel
    {

        Form1 form;
        Product product;

        PictureBox pctImage;
        Label lblTitle;
        Label lblPRP;
        Label lblPrice;
        Button btnRemove;

        BunifuElipse eliBtn;
        BunifuElipse eliImage;

        IProductComandService productComandService;
        IProductQueryService productQueryService;

        List<Product> products;

        public PnlAdminCardProduct(Form1 form1,Product product1) {
        
            this.form = form1;
            this.product = product1;

            productComandService = ProductComandServiceSingleton.Instance;
            productQueryService = ProductQueryServiceSingleton.Instance;

            products = productQueryService.getAll();

            this.Name = "PnlAdminCardProduct";
            this.Size = new System.Drawing.Size(334, 445);
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Click += new EventHandler(all_Click);

            pctImage = new PictureBox();
            lblTitle = new Label();
            lblPRP = new Label();
            lblPrice = new Label();
            btnRemove = new Button();
            eliBtn = new BunifuElipse();
            eliImage = new BunifuElipse();


            this.Controls.Add(pctImage);
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblPRP);
            this.Controls.Add(lblPrice);
            this.Controls.Add(btnRemove);

            this.eliBtn.TargetControl = this;
            this.eliBtn.ElipseRadius = 45;

            this.eliImage.TargetControl = pctImage;
            this.eliImage.ElipseRadius = 45;

            //pctImage
            this.pctImage.Location = new System.Drawing.Point(6, 5);
            this.pctImage.Size = new System.Drawing.Size(321, 225);
            this.pctImage.Image = Image.FromFile(Application.StartupPath + $@"/Images/Products/{product.getPathImage()}");
            this.pctImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctImage.Click += new EventHandler(all_Click);

            //lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.Size = new System.Drawing.Size(333, 75);
            this.lblTitle.Location = new Point(1, 244);
            this.lblTitle.Text = product.getName();
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new Font("Century Gothic", 13);
            this.lblTitle.Click += new EventHandler(all_Click);

            //lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Size = new System.Drawing.Size(333, 75);
            this.lblPrice.Location = new Point(12, 365);
            this.lblPrice.Text = product.getPrice().ToString("F2") + " Lei";
            this.lblPrice.ForeColor = Color.Red;
            this.lblPrice.Font = new Font("Century Gothic", 14,FontStyle.Bold);
            this.lblPrice.Click += new EventHandler(all_Click);

            //lblPRP
            this.lblPRP.AutoSize = true;
            this.lblPRP.Size = new System.Drawing.Size(333, 75);
            this.lblPRP.Location = new Point(13, 335);
            this.lblPRP.Text = (product.getPrice() * 1.5).ToString("F2") + " Lei";
            this.lblPRP.ForeColor = SystemColors.ControlDarkDark;
            this.lblPRP.Click += new EventHandler(all_Click);

            //teste antrenament

            //btnRemove
            this.btnRemove.Location = new Point(0, 398);
            this.btnRemove.Size = new System.Drawing.Size(334, 47);
            this.btnRemove.Text = "Remove";
            this.btnRemove.Image = Image.FromFile(Application.StartupPath + @"/Images/remove.png");
            this.btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = FlatStyle.Flat;
            this.btnRemove.Dock = DockStyle.Bottom;
            this.btnRemove.ForeColor = Color.White;
            this.btnRemove.BackColor = Color.Orange;
            this.btnRemove.Click += new EventHandler(btnRemove_Click);
            this.btnRemove.Cursor = Cursors.Hand;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(form.ct==0)
            products.RemoveAt(productComandService.pozProduct(product.getId()));
            productComandService.deleteCard(product);
            productComandService.save(products);

            form.ct=1;
            this.form.Controls.Clear();
            this.form.removePnl("PnlEditProducts");
            this.form.Controls.Add(new PnlEditProducts(form));

        }

        private void all_Click(object sender, EventArgs e)
        {

            this.form.Controls.Clear();
            this.form.removePnl("PnlEditProducts");
            this.form.Controls.Add(new PnlViewProduct(form,product));

        }

    }
}
