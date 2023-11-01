using OnlineShop.Favourites.Models;
using OnlineShop.Favourites.Service;
using OnlineShop.Models;
using OnlineShop.OrdersDetails.Service;
using OnlineShop.OrdersDetails.Service.interfaces;
using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.View.Panels
{
    public class PnlCardCart : Panel
    {


        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTile;
        private Bunifu.Framework.UI.BunifuElipse eliThis;
        private Bunifu.Framework.UI.BunifuElipse eliImage;
        private NumericUpDown quantity;

        private Form1 form;
        private User user;
        private Product product;

        IOrderDetailsComandService orderDetailsComandService;
        IOrderDetailsQueryService orderDetailsQueryService;

        List<OrderDetalis> orderDetalis = new List<OrderDetalis>();

        OrderDetalis order;

        public PnlCardCart(Form1 form1, Product product1, User user1)
        {

            form = form1;
            product = product1;
            user = user1;

            orderDetailsComandService = OrderDetailsComandServiceSingleton.Instance;
            orderDetailsQueryService = OrderDetailsQueryServiceSingleton.Instance;

            orderDetalis = orderDetailsQueryService.getMyOrdersDetails(user.getId());

            order = orderDetailsQueryService.getByIdUserPro(user.getId(), product.getId());

            //PnlCartCard
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Size = new System.Drawing.Size(1100, 208);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PnlCartCard";
            
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.eliThis = new Bunifu.Framework.UI.BunifuElipse();
            this.eliImage = new Bunifu.Framework.UI.BunifuElipse();
            this.quantity = new NumericUpDown();

            this.Controls.Add(this.quantity);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pctImage);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTile);

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrice.Location = new System.Drawing.Point(915, 21);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(140, 37);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = (order.getQuantities()*product.getPrice()).ToString("F2") + " Lei";
             
            // lblTile
            this.lblTile.BackColor = System.Drawing.Color.Transparent;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.lblTile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTile.Location = new System.Drawing.Point(450, 32);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(380, 110);
            this.lblTile.TabIndex = 1;
            this.lblTile.Text = product.getName();
            this.lblTile.AutoEllipsis = true;
             
            // btnRemove
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRemove.Image = Image.FromFile(Application.StartupPath + @"/Images/remove.png");
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(920, 124);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 36);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "    Remove";
            this.btnRemove.Click += new EventHandler(btnRemove_Click);
             
            // pctImage
            this.pctImage.BackColor = System.Drawing.Color.White;
            this.pctImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pctImage.Image = Image.FromFile(Application.StartupPath + @"/Images/Products/"+ product.getPathImage());
            this.pctImage.Location = new System.Drawing.Point(10, 8);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(365, 188);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImage.TabIndex = 0;
            this.pctImage.TabStop = false;
             
            // eliThis
            this.eliThis.ElipseRadius = 25;
            this.eliThis.TargetControl = this;
            
            // eliImage
            this.eliImage.ElipseRadius = 25;
            this.eliImage.TargetControl = this.pctImage;
             
            // quantity
            this.quantity.BackColor = System.Drawing.Color.White;
            this.quantity.BorderStyle = BorderStyle.None;
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular);
            this.quantity.ForeColor = System.Drawing.Color.Black;
            this.quantity.Location = new System.Drawing.Point(945, 78);
            this.quantity.Maximum = ((long)(product.getStock()));
            this.quantity.Minimum = ((long)(1));
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(92, 30);
            this.quantity.TabIndex = 3;
            //this.quantity.Text = "gunaNumeric1";
            this.quantity.Value = order.getQuantities();
            this.quantity.Click += new EventHandler(quantity_Click);


            orderDetailsComandService.save(orderDetalis);
            orderDetailsQueryService.save(orderDetalis);
        }

        private void quantity_Click(object sender, EventArgs e)
        {
            order.setQuantities(((int)quantity.Value));
            orderDetailsComandService.setQuantity(user.getId(), product.getId(), ((int)quantity.Value));
            orderDetailsComandService.update();

            orderDetailsComandService.save(orderDetalis);
            orderDetailsQueryService.save(orderDetalis);

            this.lblPrice.Text = (((int)quantity.Value) * product.getPrice()).ToString("F2") + " Lei";

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {


            this.Visible = false;
            orderDetailsComandService.save(orderDetalis);
            orderDetailsQueryService.save(orderDetalis);
            OrderDetalis order = orderDetailsQueryService.getByIdUserPro(user.getId(), product.getId());
           // if (form.ct3 == 0)
            //orderDetalis.RemoveAt(orderDetailsComandService.pozOrderDetails(order.getId()));

            orderDetailsComandService.deleteCard(order);

            orderDetailsComandService.save(orderDetalis);
            orderDetailsQueryService.save(orderDetalis);

        }

    }
}
