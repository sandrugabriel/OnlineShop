using Bunifu.Framework.UI;
using OnlineShop.Models;
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

        public PnlAdminCardProduct(Form1 form1,Product product1) {
        
            this.form = form1;
            this.product = product1;

            this.Name = "PnlAdminCardProduct";
            this.Size = new System.Drawing.Size(334, 445);

            pctImage = new PictureBox();
            lblTitle = new Label();
            lblPRP = new Label();
            lblPrice = new Label();
            btnRemove = new Button();
            eliBtn = new BunifuElipse();

            this.form.Controls.Add(pctImage);
            this.form.Controls.Add(lblTitle);
            this.form.Controls.Add(lblPRP);
            this.form.Controls.Add(lblPrice);
            this.form.Controls.Add(btnRemove);

            this.eliBtn.TargetControl = this;
            this.eliBtn.ElipseRadius = 35;

            //pctImage
            this.pctImage.Location = new System.Drawing.Point(6, 5);
            this.pctImage.Size = new System.Drawing.Size(321, 225);
            this.pctImage.Image = Image.FromFile(Application.StartupPath + $@"/Images/Products/{product.getPathImage()}");
            this.pctImage.SizeMode = PictureBoxSizeMode.Zoom;

            //lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.Size = new System.Drawing.Size(333, 75);
            this.lblTitle.Location = new Point(1, 244);
            this.lblTitle.Text = product.getName();
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new Font("Century Gothic", 13);

            //lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Size = new System.Drawing.Size(333, 75);
            this.lblPrice.Location = new Point(12, 355);
            this.lblPrice.Text = product.getPrice().ToString("F2") + " Lei";
            this.lblPrice.ForeColor = Color.Red;
            this.lblPrice.Font = new Font("Century Gothic", 14,FontStyle.Bold);

            //lblPRP
            this.lblPRP.AutoSize = true;
            this.lblPRP.Size = new System.Drawing.Size(333, 75);
            this.lblPRP.Location = new Point(13, 335);
            this.lblPRP.Text = (product.getPrice() * 1.5).ToString("F2") + " Lei";
            this.lblPRP.ForeColor = SystemColors.ControlDarkDark;

            //btnRemove
            this.btnRemove.Location = new Point(0, 398);
            this.btnRemove.Size = new System.Drawing.Size(334, 47);
            this.btnRemove.Text = "Remove";
            this.btnRemove.Image = Image.FromFile(Application.StartupPath + @"/Images/");
            this.btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = FlatStyle.Flat;
            this.btnRemove.Dock = DockStyle.Bottom;
            this.btnRemove.ForeColor = Color.White;
            this.btnRemove.Click += new EventHandler(btnRemove_Click);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {


        }


    }
}
