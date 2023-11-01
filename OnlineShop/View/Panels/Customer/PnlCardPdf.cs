using Bunifu.Framework.UI;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.View.Panels.Customer
{
    public class PnlCardPdf : Panel
    {

        PictureBox pctImage;
        Label lblTile;
        Label lblPrice;
        Label numeric;

        Form1 form;
        Product product;
        Order order;

        BunifuElipse elithis;
        BunifuElipse eliImg;

        public PnlCardPdf(Form1 form1, Product product1, Order order1)
        {
            this.form = form1;
            this.product = product1;
            this.order = order1;

            //PnlCardPdf
            this.Name = "PnlCardPdf";
            this.Size = new System.Drawing.Size(1201, 206);
            this.Font = new System.Drawing.Font("Century Gothic", 12);
            this.BackColor = SystemColors.ControlLight;

            this.pctImage = new PictureBox();
            this.lblTile = new Label();
            this.lblPrice = new Label();
            this.numeric = new Label();
            this.elithis = new BunifuElipse();
            this.eliImg = new BunifuElipse();

            this.Controls.Add(pctImage);
            this.Controls.Add(lblTile);
            this.Controls.Add(lblPrice);
            this.Controls.Add(numeric);

            //pctImage 
            this.pctImage.Location = new System.Drawing.Point(7,7);
            this.pctImage.Size = new System.Drawing.Size(365, 188);
            this.pctImage.BackColor = SystemColors.Control;
            this.pctImage.Image = Image.FromFile(Application.StartupPath +@"/Images/Products/"+product.getPathImage());
            this.pctImage.SizeMode = PictureBoxSizeMode.Zoom;

            //lbltile
            this.lblTile.Location = new Point(441, 31);
            this.lblTile.AutoEllipsis = true;
            this.lblTile.Size = new Size(433, 132);
            this.lblTile.Text = product.getName() ;

            //lblprice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new Point(940, 49);
            this.lblPrice.Font = new Font("Century Gothic", 16);
            this.lblPrice.Text = "Price: "+ (product.getPrice()* order.getquantity()).ToString("F2") + " Lei";
            this.lblPrice.ForeColor = Color.DimGray;

            //numeric
            this.numeric.AutoSize = true;
            this.numeric.Location = new Point(940, 116);
            this.numeric.Text = "Quantity: "+ order.getquantity().ToString();
            this.numeric.ForeColor = Color.DimGray;
            this.numeric.Font = new Font("Century Gothic", 14);

            this.elithis.TargetControl = this;
            this.elithis.ElipseRadius = 25;

            this.eliImg.TargetControl = pctImage;
            this.eliImg.ElipseRadius = 30;
            
        }


    }
}
