using OnlineShop.Models;
using OnlineShop.OrdersDetails.Service;
using OnlineShop.OrdersDetails.Service.interfaces;
using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.View.Panels
{
    public class PnlOrder : Panel
    {


        private System.Windows.Forms.PictureBox pctDesign;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblORder;
        private System.Windows.Forms.Label lblPriceProd;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblCostProduct;
        private System.Windows.Forms.Label lblCostDelivery;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnContinues;
        private Bunifu.Framework.UI.BunifuElipse eliBtn;
        private System.Windows.Forms.Panel DetalisPrice;
        private Bunifu.Framework.UI.BunifuElipse eliDetailes;

        Form1 form;
        User user;
        List<Product> products;
        double totalPrice = 0;

        IOrderDetailsComandService orderDetailsComandService;
        IOrderDetailsQueryService orderDetailsQueryService;

        List<OrderDetalis> orders;

        Timer timer;

        public PnlOrder(Form1 form1, User user1, List<Product> products1) {

            form = form1;
            user = user1;
            products = products1;

            orderDetailsComandService = OrderDetailsComandServiceSingleton.Instance;
            orderDetailsQueryService = OrderDetailsQueryServiceSingleton.Instance;

            orders = orderDetailsQueryService.getMyOrdersDetails(user.getId());

            this.Size = new System.Drawing.Size(1692, 855);
            this.AutoScroll = true;
            this.Location = new System.Drawing.Point(105, 126);

            for (int i = 0; i < products.Count; i++)
            {
               for (int j = 0;j<orders.Count; j++)
                {
                    if (orders[j].getIdProduct() == products[i].getId())
                        totalPrice += products[i].getPrice() * orders[j].getQuantities();

                }
            }

            // MockupCart
            this.ClientSize = new System.Drawing.Size(1797, 855);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PnlCart";

            this.lblCart = new System.Windows.Forms.Label();
            this.lblORder = new System.Windows.Forms.Label();
            this.lblPriceProd = new System.Windows.Forms.Label();
            this.timer = new Timer();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblCostProduct = new System.Windows.Forms.Label();
            this.lblCostDelivery = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.eliBtn = new Bunifu.Framework.UI.BunifuElipse();
            this.btnContinues = new System.Windows.Forms.Button();
            this.pctDesign = new System.Windows.Forms.PictureBox();
            this.DetalisPrice = new System.Windows.Forms.Panel();
            this.eliDetailes = new Bunifu.Framework.UI.BunifuElipse();

            this.Controls.Add(this.pctDesign);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.DetalisPrice);

            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Click);
            timer.Start();

            // lblCart
            this.lblCart.AutoSize = true;
            this.lblCart.BackColor = System.Drawing.Color.Transparent;
            this.lblCart.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCart.Location = new System.Drawing.Point(78, 34);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(112, 51);
            this.lblCart.TabIndex = 5;
            this.lblCart.Text = "Cart";
             
            // lblORder
            this.lblORder.AutoSize = true;
            this.lblORder.BackColor = System.Drawing.Color.Transparent;
            this.lblORder.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblORder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblORder.Location = new System.Drawing.Point(51, 38);
            this.lblORder.Name = "lblORder";
            this.lblORder.Size = new System.Drawing.Size(241, 37);
            this.lblORder.TabIndex = 1;
            this.lblORder.Text = "Order summary";
             
            // lblPriceProd
            this.lblPriceProd.AutoSize = true;
            this.lblPriceProd.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceProd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceProd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPriceProd.Location = new System.Drawing.Point(53, 120);
            this.lblPriceProd.Name = "lblPriceProd";
            this.lblPriceProd.Size = new System.Drawing.Size(157, 27);
            this.lblPriceProd.TabIndex = 1;
            this.lblPriceProd.Text = "Product cost:";
             
            // lblDelivery
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.BackColor = System.Drawing.Color.Transparent;
            this.lblDelivery.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDelivery.Location = new System.Drawing.Point(53, 167);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(162, 27);
            this.lblDelivery.TabIndex = 1;
            this.lblDelivery.Text = "Delivery cost:";
             
            // lblCostProduct
            this.lblCostProduct.AutoSize = true;
            this.lblCostProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblCostProduct.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostProduct.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCostProduct.Location = new System.Drawing.Point(360, 120);
            this.lblCostProduct.Name = "lblCostProduct";
            this.lblCostProduct.Size = new System.Drawing.Size(107, 27);
            this.lblCostProduct.TabIndex = 1;
            this.lblCostProduct.Text = totalPrice.ToString("F2") +" Lei";
             
            // lblCostDelivery
            this.lblCostDelivery.AutoSize = true;
            this.lblCostDelivery.BackColor = System.Drawing.Color.Transparent;
            this.lblCostDelivery.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostDelivery.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCostDelivery.Location = new System.Drawing.Point(396, 167);
            this.lblCostDelivery.Name = "lblCostDelivery";
            this.lblCostDelivery.Size = new System.Drawing.Size(75, 27);
            this.lblCostDelivery.TabIndex = 1;
            this.lblCostDelivery.Text = "12 Lei";
             
            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(50, 281);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(113, 44);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
             
            // lblTotalPrice
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(50, 335);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(172, 44);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = (totalPrice+12).ToString("F2")+" Lei";

            // eliBtn
            this.eliBtn.ElipseRadius = 35;
            this.eliBtn.TargetControl = this.btnContinues;
             
            // btnContinues
            this.btnContinues.BackColor = System.Drawing.Color.Orange;
            this.btnContinues.FlatAppearance.BorderSize = 0;
            this.btnContinues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinues.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinues.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContinues.Image = global::OnlineShop.Properties.Resources.fast_forward_double_right_arrows_symbol;
            this.btnContinues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinues.Location = new System.Drawing.Point(92, 408);
            this.btnContinues.Name = "btnContinues";
            this.btnContinues.Size = new System.Drawing.Size(326, 76);
            this.btnContinues.TabIndex = 10;
            this.btnContinues.Text = "Continues";
            this.btnContinues.Click += new EventHandler(btnContinues_Click);

            // pctDesign
            this.pctDesign.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctDesign.Location = new System.Drawing.Point(57, 85);
            this.pctDesign.Name = "pctDesign";
            this.pctDesign.Size = new System.Drawing.Size(235, 2);
            this.pctDesign.TabIndex = 6;
            this.pctDesign.TabStop = false;
             
            // DetalisPrice
            this.DetalisPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.DetalisPrice.Controls.Add(this.btnContinues);
            this.DetalisPrice.Controls.Add(this.lblORder);
            this.DetalisPrice.Controls.Add(this.lblCostDelivery);
            this.DetalisPrice.Controls.Add(this.lblPriceProd);
            this.DetalisPrice.Controls.Add(this.lblCostProduct);
            this.DetalisPrice.Controls.Add(this.lblTotalPrice);
            this.DetalisPrice.Controls.Add(this.lblTotal);
            this.DetalisPrice.Controls.Add(this.lblDelivery);
            this.DetalisPrice.Location = new System.Drawing.Point(1150, 72);
            this.DetalisPrice.Name = "DetalisPrice";
            this.DetalisPrice.Size = new System.Drawing.Size(511, 511);
            this.DetalisPrice.TabIndex = 11;
             
            // eliDetailes
            this.eliDetailes.ElipseRadius = 35;
            this.eliDetailes.TargetControl = this.DetalisPrice;

            createCard();

        }

        public void createCard()
        {
            this.Controls.Clear();

            this.Controls.Add(lblCart);
            this.Controls.Add(pctDesign);
            this.Controls.Add(DetalisPrice);

            int x = 27, y = 130, ct = 0;

            foreach (Product p in products)
            {

                ct++;
                PnlCardCart pnlCard = new PnlCardCart(form, p, user);
                pnlCard.Location = new System.Drawing.Point(x, y);

                this.Controls.Add(pnlCard);
                x += 400;

                if (ct % 1 == 0)
                {
                    x = 27;
                    y += 250;
                }
                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }
            }
        }

        public void timer_Click(object sender, EventArgs e)
        {
            totalPrice = 0;

            orderDetailsQueryService = OrderDetailsQueryServiceSingleton.Instance;

            orders = orderDetailsQueryService.getMyOrdersDetails(user.getId());

            for (int i = 0; i < products.Count; i++)
            {
                for (int j = 0; j < orders.Count; j++)
                {
                    if (orders[j].getIdProduct() == products[i].getId())
                        totalPrice += products[i].getPrice() * orders[j].getQuantities();

                }
            }

            this.lblTotalPrice.Text = (totalPrice + 12).ToString("F2") + " Lei";
            this.lblCostProduct.Text = totalPrice.ToString("F2") + " Lei";

        }

        private void btnContinues_Click(object sender, EventArgs e)
        {


        }
    }
}
