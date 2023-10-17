using OnlineShop.Models;
using OnlineShop.Orders.Service;
using OnlineShop.Orders.Service.interafaces;
using OnlineShop.OrdersDetails.Service;
using OnlineShop.OrdersDetails.Service.interfaces;
using OnlineShop.Panels;
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
    public class PnlPayment : Panel
    {

        private System.Windows.Forms.PictureBox pctDesign;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.PictureBox pctBlue2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.RadioButton radioSame;
        private System.Windows.Forms.RadioButton radioAnother;
        private System.Windows.Forms.PictureBox pct3;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDel;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblCostProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Panel SendOrder;
        private System.Windows.Forms.PictureBox pctBlue1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblBiling;
        private System.Windows.Forms.Panel BilingAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.RadioButton radioBiling;
        private Bunifu.Framework.UI.BunifuElipse eliBiling;
        private System.Windows.Forms.Panel Delivery;
        private Bunifu.Framework.UI.BunifuElipse eliDelivery;
        private System.Windows.Forms.PictureBox pctHide;
        private System.Windows.Forms.PictureBox pctShow;
        private System.Windows.Forms.PictureBox pctShowDelivery;
        private System.Windows.Forms.PictureBox pctHideDelivery;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddressDelivery;
        private System.Windows.Forms.Label lblAddressDelivery;
        private System.Windows.Forms.Panel Payment;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pctShowPay;
        private System.Windows.Forms.PictureBox pctHidePay;
        private Bunifu.Framework.UI.BunifuElipse eliPay;
        private Bunifu.Framework.UI.BunifuElipse eliBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse eliOrder;

        Form1 form;
        User user;
        double total;
        List<OrderDetalis> orderDetalis;

        bool sidebar = false;
        bool sidebar2 = false;
        bool sidebar3 = false;

        string path;

        IOrderComandSerice orderComandSerice;
        IOrderQueryService orderQueryService;

        IOrderDetailsComandService orderDetailsComandService;
        IOrderDetailsQueryService orderDetailsQueryService;

        public PnlPayment(Form1 form1, User user1, double total1, List<OrderDetalis> orderDetalis1) {

            form = form1;
            user = user1;
            total = total1;
            orderDetalis = orderDetalis1;

            path = Application.StartupPath + @"/Images/";

            orderComandSerice = OrderComandServiceSingleton.Instance;
            orderQueryService = OrderQueryServiceSingleton.Instance;

            orderDetailsComandService = OrderDetailsComandServiceSingleton.Instance;
            orderDetailsQueryService = OrderDetailsQueryServiceSingleton.Instance;

            orderDetalis = orderDetailsQueryService.getMyOrdersDetails(user.getId());   

            //PnlPayment
            this.AutoScroll = true;
            this.Size = new System.Drawing.Size(1692, 855);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlPayment";

            this.lblTile = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.radioSame = new System.Windows.Forms.RadioButton();
            this.radioAnother = new System.Windows.Forms.RadioButton();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDel = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblCostProduct = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.SendOrder = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblBiling = new System.Windows.Forms.Label();
            this.BilingAddress = new System.Windows.Forms.Panel();
            this.pctShow = new System.Windows.Forms.PictureBox();
            this.pctHide = new System.Windows.Forms.PictureBox();
            this.radioBiling = new System.Windows.Forms.RadioButton();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pctBlue1 = new System.Windows.Forms.PictureBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.eliBiling = new Bunifu.Framework.UI.BunifuElipse();
            this.Delivery = new System.Windows.Forms.Panel();
            this.pctShowDelivery = new System.Windows.Forms.PictureBox();
            this.pctHideDelivery = new System.Windows.Forms.PictureBox();
            this.txtAddressDelivery = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblAddressDelivery = new System.Windows.Forms.Label();
            this.pctBlue2 = new System.Windows.Forms.PictureBox();
            this.eliDelivery = new Bunifu.Framework.UI.BunifuElipse();
            this.pctDesign = new System.Windows.Forms.PictureBox();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.Payment = new System.Windows.Forms.Panel();
            this.pctShowPay = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pctHidePay = new System.Windows.Forms.PictureBox();
            this.eliPay = new Bunifu.Framework.UI.BunifuElipse();
            this.eliBtn = new Bunifu.Framework.UI.BunifuElipse();
            this.timer1 = new System.Windows.Forms.Timer();
            this.timer2 = new System.Windows.Forms.Timer();
            this.timer3 = new System.Windows.Forms.Timer();
            this.label1 = new System.Windows.Forms.Label();
            this.eliOrder = new Bunifu.Framework.UI.BunifuElipse();

            this.Controls.Add(this.label1);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Delivery);
            this.Controls.Add(this.BilingAddress);
            this.Controls.Add(this.pctDesign);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.SendOrder);

            // lblTile
            this.lblTile.AutoSize = true;
            this.lblTile.BackColor = System.Drawing.Color.Transparent;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular);
            this.lblTile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTile.Location = new System.Drawing.Point(49, 41);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(286, 51);
            this.lblTile.TabIndex = 7;
            this.lblTile.Text = "Order details";
             
            // lbl2
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(55, 32);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 59);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "2";
            
            // lblDelivery
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.BackColor = System.Drawing.Color.Transparent;
            this.lblDelivery.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular);
            this.lblDelivery.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDelivery.Location = new System.Drawing.Point(146, 39);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(278, 40);
            this.lblDelivery.TabIndex = 1;
            this.lblDelivery.Text = "Delivery method";
             
            // radioSame
            this.radioSame.AutoSize = true;
            this.radioSame.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular);
            this.radioSame.ForeColor = System.Drawing.Color.DimGray;
            this.radioSame.Location = new System.Drawing.Point(25, 159);
            this.radioSame.Name = "radioSame";
            this.radioSame.Size = new System.Drawing.Size(418, 37);
            this.radioSame.TabIndex = 9;
            this.radioSame.TabStop = true;
            this.radioSame.Text = "Delivery to the same address";
            this.radioSame.UseVisualStyleBackColor = true;

            // radioAnother
            this.radioAnother.AutoSize = true;
            this.radioAnother.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular);
            this.radioAnother.ForeColor = System.Drawing.Color.DimGray;
            this.radioAnother.Location = new System.Drawing.Point(25, 228);
            this.radioAnother.Name = "radioAnother";
            this.radioAnother.Size = new System.Drawing.Size(399, 37);
            this.radioAnother.TabIndex = 9;
            this.radioAnother.TabStop = true;
            this.radioAnother.Text = "Delivery to another address";
            this.radioAnother.UseVisualStyleBackColor = true;
             
            // lbl3
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(55, 29);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(53, 59);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "3";
             
            // lblPay
            this.lblPay.AutoSize = true;
            this.lblPay.BackColor = System.Drawing.Color.Transparent;
            this.lblPay.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular);
            this.lblPay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPay.Location = new System.Drawing.Point(156, 40);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(293, 40);
            this.lblPay.TabIndex = 1;
            this.lblPay.Text = "Payment method";
             
            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(704, 113);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(113, 44);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total:";
             
            // lblDel
            this.lblDel.AutoSize = true;
            this.lblDel.BackColor = System.Drawing.Color.Transparent;
            this.lblDel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDel.Location = new System.Drawing.Point(64, 175);
            this.lblDel.Name = "lblDel";
            this.lblDel.Size = new System.Drawing.Size(162, 27);
            this.lblDel.TabIndex = 12;
            this.lblDel.Text = "Delivery cost:";
             
            // lblTotalPrice
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(704, 173);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(172, 44);
            this.lblTotalPrice.TabIndex = 13;
            this.lblTotalPrice.Text = total.ToString("F2")+" Lei";
             
            // lblCostProduct
            this.lblCostProduct.AutoSize = true;
            this.lblCostProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblCostProduct.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCostProduct.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCostProduct.Location = new System.Drawing.Point(396, 125);
            this.lblCostProduct.Name = "lblCostProduct";
            this.lblCostProduct.Size = new System.Drawing.Size(107, 27);
            this.lblCostProduct.TabIndex = 14;
            this.lblCostProduct.Text = (total-12).ToString("F2") + " Lei";
             
            // lblProduct
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProduct.Location = new System.Drawing.Point(64, 125);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(157, 27);
            this.lblProduct.TabIndex = 15;
            this.lblProduct.Text = "Product cost:";
            
            // lblOrder
            this.lblOrder.AutoSize = true;
            this.lblOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblOrder.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular);
            this.lblOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOrder.Location = new System.Drawing.Point(62, 39);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(241, 37);
            this.lblOrder.TabIndex = 16;
            this.lblOrder.Text = "Order summary";
             
            // lblCost
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCost.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCost.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCost.Location = new System.Drawing.Point(396, 175);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(75, 27);
            this.lblCost.TabIndex = 19;
            this.lblCost.Text = "12 Lei";
             
            // SendOrder
            this.SendOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.SendOrder.Controls.Add(this.btnSend);
            this.SendOrder.Controls.Add(this.lblCost);
            this.SendOrder.Controls.Add(this.lblTotalPrice);
            this.SendOrder.Controls.Add(this.lblTotal);
            this.SendOrder.Controls.Add(this.lblProduct);
            this.SendOrder.Controls.Add(this.lblOrder);
            this.SendOrder.Controls.Add(this.lblCostProduct);
            this.SendOrder.Controls.Add(this.lblDel);
            this.SendOrder.Location = new System.Drawing.Point(710, 165);
            this.SendOrder.Name = "SendOrder";
            this.SendOrder.Size = new System.Drawing.Size(950, 392);
            this.SendOrder.TabIndex = 20;
             
            // btnSend
            this.btnSend.BackColor = System.Drawing.Color.Orange;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSend.Image = global::OnlineShop.Properties.Resources.fast_forward_double_right_arrows_symbol;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(109, 281);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(750, 68);
            this.btnSend.TabIndex = 18;
            this.btnSend.Text = "Send The Order";
            this.btnSend.Click += new EventHandler(btnSend_Click);
            
            // lbl1
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(55, 37);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 59);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "1";
             
            // lblBiling
            this.lblBiling.AutoSize = true;
            this.lblBiling.BackColor = System.Drawing.Color.Transparent;
            this.lblBiling.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular);
            this.lblBiling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBiling.Location = new System.Drawing.Point(156, 37);
            this.lblBiling.Name = "lblBiling";
            this.lblBiling.Size = new System.Drawing.Size(239, 40);
            this.lblBiling.TabIndex = 1;
            this.lblBiling.Text = "Billing address";
             
            // BilingAddress
            this.BilingAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.BilingAddress.Controls.Add(this.pctShow);
            this.BilingAddress.Controls.Add(this.pctHide);
            this.BilingAddress.Controls.Add(this.radioBiling);
            this.BilingAddress.Controls.Add(this.txtAddress);
            this.BilingAddress.Controls.Add(this.lblBiling);
            this.BilingAddress.Controls.Add(this.txtPhone);
            this.BilingAddress.Controls.Add(this.lbl1);
            this.BilingAddress.Controls.Add(this.pctBlue1);
            this.BilingAddress.Controls.Add(this.lblAddress);
            this.BilingAddress.Controls.Add(this.lblName);
            this.BilingAddress.Controls.Add(this.txtEmail);
            this.BilingAddress.Controls.Add(this.txtName);
            this.BilingAddress.Controls.Add(this.lblPhone);
            this.BilingAddress.Controls.Add(this.lblEmail);
            this.BilingAddress.Location = new System.Drawing.Point(45, 165);
            this.BilingAddress.MaximumSize = new System.Drawing.Size(586, 635);
            this.BilingAddress.MinimumSize = new System.Drawing.Size(586, 122);
            this.BilingAddress.Name = "BilingAddress";
            this.BilingAddress.Size = new System.Drawing.Size(586, 122);
            this.BilingAddress.TabIndex = 21;
             
            // pctShow
            this.pctShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctShow.Image = Image.FromFile(path + "5.png");
            this.pctShow.Location = new System.Drawing.Point(502, 37);
            this.pctShow.Name = "pctShow";
            this.pctShow.Size = new System.Drawing.Size(47, 40);
            this.pctShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctShow.TabIndex = 33;
            this.pctShow.TabStop = false;
            this.pctShow.Click += new System.EventHandler(this.pctShow_Click);
             
            // pctHide
            this.pctHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctHide.Image = Image.FromFile(path + "6.png");
            this.pctHide.Location = new System.Drawing.Point(502, 37);
            this.pctHide.Name = "pctHide";
            this.pctHide.Size = new System.Drawing.Size(47, 40);
            this.pctHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctHide.TabIndex = 33;
            this.pctHide.TabStop = false;
            this.pctHide.Click += new System.EventHandler(this.pctHide_Click);
             
            // radioBiling
            this.radioBiling.AutoSize = true;
            this.radioBiling.Checked = true;
            this.radioBiling.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular);
            this.radioBiling.Location = new System.Drawing.Point(19, 128);
            this.radioBiling.ForeColor = Color.Black;
            this.radioBiling.Name = "radioBiling";
            this.radioBiling.Size = new System.Drawing.Size(170, 38);
            this.radioBiling.TabIndex = 32;
            this.radioBiling.TabStop = true;
            this.radioBiling.Text = "Individual";
            this.radioBiling.UseVisualStyleBackColor = true;
             
            // txtAddress
            this.txtAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddress.HintText = "";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtAddress.LineIdleColor = System.Drawing.Color.DimGray;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.LineThickness = 3;
            this.txtAddress.Location = new System.Drawing.Point(19, 561);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(544, 49);
            this.txtAddress.Text = user.getAddress();
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
             
            // txtPhone
            this.txtPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.HintForeColor = System.Drawing.Color.Empty;
            this.txtPhone.HintText = "";
            this.txtPhone.isPassword = false;
            this.txtPhone.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtPhone.LineIdleColor = System.Drawing.Color.DimGray;
            this.txtPhone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.LineThickness = 3;
            this.txtPhone.Location = new System.Drawing.Point(20, 448);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(544, 49);
            this.txtPhone.Text = user.getPhone();
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            
            // pctBlue1
            this.pctBlue1.BackColor = System.Drawing.Color.Transparent;
            this.pctBlue1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctBlue1.Image = Image.FromFile(path + "7.png");
            this.pctBlue1.Location = new System.Drawing.Point(20, 19);
            this.pctBlue1.Name = "pctBlue1";
            this.pctBlue1.Size = new System.Drawing.Size(119, 93);
            this.pctBlue1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBlue1.TabIndex = 0;
            this.pctBlue1.TabStop = false;
             
            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular);
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(15, 522);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(122, 34);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Address";
            
            // lblName
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(14, 189);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 34);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Full Name";
             
            // txtEmail
            this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtEmail.LineIdleColor = System.Drawing.Color.DimGray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(19, 339);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(544, 49);
            this.txtEmail.Text = user.getEmail();
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
             
            // txtName
            this.txtName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtName.LineIdleColor = System.Drawing.Color.DimGray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(19, 228);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(544, 49);
            this.txtName.Text = user.getName();
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
             
            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular);
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(15, 409);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(102, 34);
            this.lblPhone.TabIndex = 23;
            this.lblPhone.Text = "Phone";
             
            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(15, 300);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(88, 34);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            
            // eliBiling
            this.eliBiling.ElipseRadius = 25;
            this.eliBiling.TargetControl = this.BilingAddress;
             
            // Delivery
            this.Delivery.BackColor = System.Drawing.Color.Gainsboro;
            this.Delivery.Controls.Add(this.pctShowDelivery);
            this.Delivery.Controls.Add(this.pctHideDelivery);
            this.Delivery.Controls.Add(this.txtAddressDelivery);
            this.Delivery.Controls.Add(this.lblAddressDelivery);
            this.Delivery.Controls.Add(this.lblDelivery);
            this.Delivery.Controls.Add(this.lbl2);
            this.Delivery.Controls.Add(this.radioAnother);
            this.Delivery.Controls.Add(this.pctBlue2);
            this.Delivery.Controls.Add(this.radioSame);
            this.Delivery.Location = new System.Drawing.Point(45, 306);
            this.Delivery.MaximumSize = new System.Drawing.Size(586, 428);
            this.Delivery.MinimumSize = new System.Drawing.Size(586, 122);
            this.Delivery.Name = "Delivery";
            this.Delivery.Size = new System.Drawing.Size(586, 122);
            this.Delivery.TabIndex = 22;
             
            // pctShowDelivery
            this.pctShowDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctShowDelivery.Image = Image.FromFile(path + "5.png");
            this.pctShowDelivery.Location = new System.Drawing.Point(502, 39);
            this.pctShowDelivery.Name = "pctShowDelivery";
            this.pctShowDelivery.Size = new System.Drawing.Size(47, 40);
            this.pctShowDelivery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctShowDelivery.TabIndex = 33;
            this.pctShowDelivery.TabStop = false;
            this.pctShowDelivery.Click += new System.EventHandler(this.pctShowDelivery_Click);
             
            // pctHideDelivery
            this.pctHideDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctHideDelivery.Image = Image.FromFile(path + "6.png");
            this.pctHideDelivery.Location = new System.Drawing.Point(502, 39);
            this.pctHideDelivery.Name = "pctHideDelivery";
            this.pctHideDelivery.Size = new System.Drawing.Size(47, 40);
            this.pctHideDelivery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctHideDelivery.TabIndex = 33;
            this.pctHideDelivery.TabStop = false;
            this.pctHideDelivery.Click += new System.EventHandler(this.pctHideDelivery_Click);
             
            // txtAddressDelivery
            this.txtAddressDelivery.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAddressDelivery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddressDelivery.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtAddressDelivery.ForeColor = System.Drawing.Color.Black;
            this.txtAddressDelivery.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddressDelivery.HintText = "";
            this.txtAddressDelivery.isPassword = false;
            this.txtAddressDelivery.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtAddressDelivery.LineIdleColor = System.Drawing.Color.DimGray;
            this.txtAddressDelivery.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddressDelivery.LineThickness = 3;
            this.txtAddressDelivery.Location = new System.Drawing.Point(23, 339);
            this.txtAddressDelivery.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddressDelivery.Name = "txtAddressDelivery";
            this.txtAddressDelivery.Size = new System.Drawing.Size(544, 49);
            this.txtAddressDelivery.TabIndex = 29;
            this.txtAddressDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            
            // lblAddressDelivery
            this.lblAddressDelivery.AutoSize = true;
            this.lblAddressDelivery.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressDelivery.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular);
            this.lblAddressDelivery.ForeColor = System.Drawing.Color.Black;
            this.lblAddressDelivery.Location = new System.Drawing.Point(19, 300);
            this.lblAddressDelivery.Name = "lblAddressDelivery";
            this.lblAddressDelivery.Size = new System.Drawing.Size(122, 34);
            this.lblAddressDelivery.TabIndex = 28;
            this.lblAddressDelivery.Text = "Address";
             
            // pctBlue2
            this.pctBlue2.BackColor = System.Drawing.Color.Transparent;
            this.pctBlue2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctBlue2.Image = Image.FromFile(path + "7.png");
            this.pctBlue2.Location = new System.Drawing.Point(21, 16);
            this.pctBlue2.Name = "pctBlue2";
            this.pctBlue2.Size = new System.Drawing.Size(119, 93);
            this.pctBlue2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBlue2.TabIndex = 0;
            this.pctBlue2.TabStop = false;
             
            // eliDelivery
            this.eliDelivery.ElipseRadius = 25;
            this.eliDelivery.TargetControl = this.Delivery;
             
            // pctDesign
            this.pctDesign.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctDesign.Location = new System.Drawing.Point(45, 95);
            this.pctDesign.Name = "pctDesign";
            this.pctDesign.Size = new System.Drawing.Size(290, 2);
            this.pctDesign.TabIndex = 8;
            this.pctDesign.TabStop = false;
             
            // pct3
            this.pct3.BackColor = System.Drawing.Color.Transparent;
            this.pct3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct3.Image = Image.FromFile(path + "7.png");
            this.pct3.Location = new System.Drawing.Point(21, 15);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(119, 93);
            this.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct3.TabIndex = 0;
            this.pct3.TabStop = false;
             
            // Payment
            this.Payment.BackColor = System.Drawing.Color.Gainsboro;
            this.Payment.Controls.Add(this.pctShowPay);
            this.Payment.Controls.Add(this.radioButton1);
            this.Payment.Controls.Add(this.pctHidePay);
            this.Payment.Controls.Add(this.lblPay);
            this.Payment.Controls.Add(this.lbl3);
            this.Payment.Controls.Add(this.pct3);
            this.Payment.Location = new System.Drawing.Point(45, 448);
            this.Payment.MaximumSize = new System.Drawing.Size(586, 236);
            this.Payment.MinimumSize = new System.Drawing.Size(586, 122);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(586, 122);
            this.Payment.TabIndex = 23;
             
            // pctShowPay
            this.pctShowPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctShowPay.Image = Image.FromFile(path + "5.png");
            this.pctShowPay.Location = new System.Drawing.Point(502, 47);
            this.pctShowPay.Name = "pctShowPay";
            this.pctShowPay.Size = new System.Drawing.Size(47, 40);
            this.pctShowPay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctShowPay.TabIndex = 33;
            this.pctShowPay.TabStop = false;
            this.pctShowPay.Click += new System.EventHandler(this.pctShowPay_Click);
            
            // radioButton1
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular);
            this.radioButton1.ForeColor = System.Drawing.Color.DimGray;
            this.radioButton1.Location = new System.Drawing.Point(20, 153);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(317, 38);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Payment on delivery";
            this.radioButton1.UseVisualStyleBackColor = true;
            
            // pctHidePay
            this.pctHidePay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctHidePay.Image = Image.FromFile(path + "6.png");
            this.pctHidePay.Location = new System.Drawing.Point(502, 48);
            this.pctHidePay.Name = "pctHidePay";
            this.pctHidePay.Size = new System.Drawing.Size(47, 40);
            this.pctHidePay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctHidePay.TabIndex = 33;
            this.pctHidePay.TabStop = false;
            this.pctHidePay.Click += new System.EventHandler(this.pctHidePay_Click);
             
            // eliPay
            this.eliPay.ElipseRadius = 25;
            this.eliPay.TargetControl = this.Payment;
            
            // eliBtn
            this.eliBtn.ElipseRadius = 25;
            this.eliBtn.TargetControl = this.btnSend;
             
            // timer1
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
             
            // timer2
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
             
            // timer3
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            
            // label1
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(274, 664);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
             
            // eliOrder
            this.eliOrder.ElipseRadius = 30;
            this.eliOrder.TargetControl = this.SendOrder;


            int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height + 20;
            this.Delivery.Location = new Point(this.Delivery.Location.X, y);
            int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
            this.Payment.Location = new Point(this.Payment.Location.X, y2);
            int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 150;
            this.label1.Location = new Point(this.label1.Location.X, y3);
            label1.Location = new Point(1,this.BilingAddress.Location.Y + this.Delivery.Location.Y + this.Payment.Location.Y + y3);
        }

        public void btnSend_Click( object sender, EventArgs e)
        {

            for (int i = 0; i < orderDetalis.Count; i++)
            {
                int id = orderComandSerice.generareIdOrder();
                int idUser = user.getId();
                int idProduct = orderDetalis[i].getIdProduct();
                int quantities = orderDetalis[i].getQuantities();
                string address = "";
                string phone = txtPhone.Text;
                if (radioSame.Checked) address = txtAddress.Text;
                if (radioAnother.Checked) address = txtAddressDelivery.Text;
                if (address == "")
                {
                    MessageBox.Show("You have not selected an address!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string t = id.ToString() + "|" + idUser.ToString() + "|" + idProduct.ToString() +
                    "|" + quantities.ToString() + "|" + address + "|" + phone.ToString();

                }

                MessageBox.Show($"The order {id.ToString()} has been placed!!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                orderDetailsComandService.deleteCard(orderDetalis[i]);
            }

            orderDetalis.Clear();
            orderDetailsComandService.save(orderDetalis);
            orderDetailsQueryService.save(orderDetalis);
            this.form.removePnl("PnlHome");
                this.form.Controls.Add(new PnlHome(form,user));
        }

        private void pctShow_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pctShow.Visible = false;
            pctHide.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pctShow.Enabled = false;
            pctHide.Enabled = false;
            if (sidebar)
            {

                BilingAddress.Height -= 10;

                int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height + 20;
                this.Delivery.Location = new Point(this.Delivery.Location.X, y);
                int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
                this.Payment.Location = new Point(this.Payment.Location.X, y2);
                int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 50;
                this.label1.Location = new Point(this.label1.Location.X, y3);
                

                if (BilingAddress.Height == BilingAddress.MinimumSize.Height)
                {
                    sidebar = false;
                    timer1.Stop();

                    pctShow.Enabled = true;
                    pctHide.Enabled = true;
                }

            }
            else
            {
                BilingAddress.Height += 10;

                int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height + 20;
                this.Delivery.Location = new Point(this.Delivery.Location.X, y);
                int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
                this.Payment.Location = new Point(this.Payment.Location.X, y2);
                int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 50;
                this.label1.Location = new Point(this.label1.Location.X, y3);
               

                if (BilingAddress.Height == BilingAddress.MaximumSize.Height)
                {
                    sidebar = true;
                    timer1.Stop();

                    pctShow.Enabled = true;
                    pctHide.Enabled = true;
                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pctShowDelivery.Enabled = false;
            pctHideDelivery.Enabled = false;

            if (sidebar2)
            {

                Delivery.Height -= 10;

                int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height + 20;
                this.Delivery.Location = new Point(this.Delivery.Location.X, y);
                int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
                this.Payment.Location = new Point(this.Payment.Location.X, y2);
                int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 50;
                this.label1.Location = new Point(this.label1.Location.X, y3);
               

                if (Delivery.Height == Delivery.MinimumSize.Height)
                {
                    sidebar2 = false;
                    timer2.Stop();
                    pctShowDelivery.Enabled = true;
                    pctHideDelivery.Enabled = true;

                }

            }
            else
            {
                Delivery.Height += 10;

                int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height + 20;
                this.Delivery.Location = new Point(this.Delivery.Location.X, y);
                int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
                this.Payment.Location = new Point(this.Payment.Location.X, y2);
                int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 50;
                this.label1.Location = new Point(this.label1.Location.X, y3);
               

                if (Delivery.Height == Delivery.MaximumSize.Height)
                {
                    sidebar2 = true;
                    timer2.Stop();
                    pctShowDelivery.Enabled = true;
                    pctHideDelivery.Enabled = true;

                }
            }
        }

        private void pctShowDelivery_Click(object sender, EventArgs e)
        {

            timer2.Start();
            pctShowDelivery.Visible = false;
            pctHideDelivery.Visible = true;
        }

        private void pctHide_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pctShow.Visible = true;
            pctHide.Visible = false;
        }

        private void pctHideDelivery_Click(object sender, EventArgs e)
        {

            timer2.Start();
            pctShowDelivery.Visible = true;
            pctHideDelivery.Visible = false;
        }

        private void pctShowPay_Click(object sender, EventArgs e)
        {
            timer3.Start();
            pctHidePay.Visible = true;
            pctShowPay.Visible = false;

        }

        private void pctHidePay_Click(object sender, EventArgs e)
        {
            timer3.Start();
            pctHidePay.Visible = false;
            pctShowPay.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pctShowPay.Enabled = false;
            pctHidePay.Enabled = false;

            if (sidebar3)
            {

                Payment.Height -= 10;

                int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height + 20;
                this.Delivery.Location = new Point(this.Delivery.Location.X, y);
                int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
                this.Payment.Location = new Point(this.Payment.Location.X, y2);
                int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 50;
                this.label1.Location = new Point(this.label1.Location.X, y3);
               

                if (Payment.Height == Payment.MinimumSize.Height)
                {
                    sidebar3 = false;
                    timer3.Stop();
                    pctShowPay.Enabled = true;
                    pctHidePay.Enabled = true;

                }

            }
            else
            {
                Payment.Height += 10;

                int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height + 20;
                this.Delivery.Location = new Point(this.Delivery.Location.X, y);
                int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
                this.Payment.Location = new Point(this.Payment.Location.X, y2);
                int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 50;
                this.label1.Location = new Point(this.label1.Location.X, y3);

                if (Payment.Height == Payment.MaximumSize.Height)
                {
                    sidebar3 = true;
                    timer3.Stop();
                    pctShowPay.Enabled = true;
                    pctHidePay.Enabled = true;

                }
            }
        }

    }
}
