using OnlineShop.Models;
using OnlineShop.Products.Service;
using OnlineShop.Products.Service.interfaces;
using OnlineShop.Properties;
using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Panels
{
    public class PnlHome : Panel
    {

        private Bunifu.Framework.UI.BunifuElipse eliPnl;
        private Bunifu.Framework.UI.BunifuGradientPanel grandTop;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.PictureBox pctMini;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.PictureBox pctCart;
        private System.Windows.Forms.Label lblCountCart;
        private System.Windows.Forms.PictureBox pctRedCart;
        private System.Windows.Forms.Label lblCountFav;
        private System.Windows.Forms.Label lblFav;
        private System.Windows.Forms.PictureBox pctFavRed;
        private System.Windows.Forms.PictureBox pctFavorite;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.PictureBox pctAccount;
        private System.Windows.Forms.Button btnTV;
        private System.Windows.Forms.Button btnToys;
        private System.Windows.Forms.Button btnGarden;
        private System.Windows.Forms.Button btnElectro;
        private System.Windows.Forms.Button btnIT;
        private System.Windows.Forms.Label lblCateg;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pctMenu;
        private System.Windows.Forms.PictureBox pctDesign;
        private System.Windows.Forms.PictureBox pctIT;
        private System.Windows.Forms.PictureBox pctTV;
        private System.Windows.Forms.PictureBox pctToys;
        private System.Windows.Forms.PictureBox pctElectro;
        private System.Windows.Forms.PictureBox pctGarden;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Label lblSignOut;
        private System.Windows.Forms.Timer timeSlideMenu;

        Form1 form;
        User user;
        string path;
        bool sidebar;

        PnlCards pnlCards;
        IProductQueryService productQueryService;
        List<Product> list;

        int ct = 0;

        public PnlHome(Form1 form1, User user1)
        {

            this.form = form1;
            this.user = user1;

            path = Application.StartupPath.Remove(44) + @"Images\";
            productQueryService = new ProductQueryService();


            list = productQueryService.getProductWithCateg("it");
            ct = 4;
            pnlCards = new PnlCards(ct, form, list, user);
            //pnlCards.Name = "PnlCards";

            this.pnlCards.cmbSort.SelectedIndexChanged += new EventHandler(cmbSort_SelectedIndexChanged);


            //PnlHome
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1797, 981);
            this.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "PnlHome";

            this.eliPnl = new Bunifu.Framework.UI.BunifuElipse();
            this.lblCateg = new System.Windows.Forms.Label();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.pctDesign = new System.Windows.Forms.PictureBox();
            this.btnIT = new System.Windows.Forms.Button();
            this.pctIT = new System.Windows.Forms.PictureBox();
            this.btnTV = new System.Windows.Forms.Button();
            this.pctTV = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblSignOut = new System.Windows.Forms.Label();
            this.btnToys = new System.Windows.Forms.Button();
            this.pctToys = new System.Windows.Forms.PictureBox();
            this.btnElectro = new System.Windows.Forms.Button();
            this.pctElectro = new System.Windows.Forms.PictureBox();
            this.btnGarden = new System.Windows.Forms.Button();
            this.pctGarden = new System.Windows.Forms.PictureBox();
            this.pctMenu = new System.Windows.Forms.PictureBox();
            this.grandTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblFav = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.pctFavRed = new System.Windows.Forms.PictureBox();
            this.lblCountFav = new System.Windows.Forms.Label();
            this.pctRedCart = new System.Windows.Forms.PictureBox();
            this.lblCountCart = new System.Windows.Forms.Label();
            this.pctAccount = new System.Windows.Forms.PictureBox();
            this.pctFavorite = new System.Windows.Forms.PictureBox();
            this.pctCart = new System.Windows.Forms.PictureBox();
            this.pctMini = new System.Windows.Forms.PictureBox();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.timeSlideMenu = new System.Windows.Forms.Timer();

            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.grandTop);

            // eliPnl
            this.eliPnl.ElipseRadius = 20;
            this.eliPnl.TargetControl = this;
             
            // lblCateg
            this.lblCateg.AutoSize = true;
            this.lblCateg.BackColor = System.Drawing.Color.Transparent;
            this.lblCateg.Font = new System.Drawing.Font("Century Gothic", 13.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateg.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCateg.Location = new System.Drawing.Point(132, 134);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(135, 27);
            this.lblCateg.TabIndex = 1;
            this.lblCateg.Text = "Categories";
             
            // pnlSideBar
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(39)))));
            this.pnlSideBar.Controls.Add(this.pctExit);
            this.pnlSideBar.Controls.Add(this.pctDesign);
            this.pnlSideBar.Controls.Add(this.btnIT);
            this.pnlSideBar.Controls.Add(this.btnTV);
            this.pnlSideBar.Controls.Add(this.lblMenu);
            this.pnlSideBar.Controls.Add(this.lblSignOut);
            this.pnlSideBar.Controls.Add(this.lblCateg);
            this.pnlSideBar.Controls.Add(this.btnToys);
            this.pnlSideBar.Controls.Add(this.btnElectro);
            this.pnlSideBar.Controls.Add(this.btnGarden);
            this.pnlSideBar.Controls.Add(this.pctMenu);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 126);
            this.pnlSideBar.MaximumSize = new System.Drawing.Size(398, 855);
            this.pnlSideBar.MinimumSize = new System.Drawing.Size(105, 855);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(105, 855);
            this.pnlSideBar.TabIndex = 4;
             
            // pctExit
            this.pctExit.BackColor = System.Drawing.Color.Transparent;
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = Image.FromFile(path + "exit.png");
            this.pctExit.Location = new System.Drawing.Point(24, 789);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(54, 54);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctExit.TabIndex = 0;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
             
            // pctDesign
            this.pctDesign.BackColor = System.Drawing.Color.White;
            this.pctDesign.Location = new System.Drawing.Point(106, 78);
            this.pctDesign.Name = "pctDesign";
            this.pctDesign.Size = new System.Drawing.Size(347, 1);

            // btnIT
            this.btnIT.BackColor = System.Drawing.Color.Transparent;
            this.btnIT.Controls.Add(this.pctIT);
            this.btnIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIT.FlatAppearance.BorderSize = 0;
            this.btnIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIT.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIT.ForeColor = System.Drawing.Color.White;
            this.btnIT.Image = Image.FromFile(path + "dreapta.png");
            this.btnIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIT.Location = new System.Drawing.Point(12, 175);
            this.btnIT.Name = "btnIT";
            this.btnIT.Size = new System.Drawing.Size(386, 60);
            this.btnIT.TabIndex = 2;
            this.btnIT.Text = "            IT, Mobile, Gaming";
            this.btnIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIT.UseVisualStyleBackColor = false;
            this.btnIT.Click += new EventHandler(btnIT_Click); 

            // pctIT
            this.pctIT.BackColor = System.Drawing.Color.Transparent;
            this.pctIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctIT.Image = Image.FromFile(path + "it.png");
            this.pctIT.Location = new System.Drawing.Point(12, 3);
            this.pctIT.Name = "pctIT";
            this.pctIT.Size = new System.Drawing.Size(54, 54);
            this.pctIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctIT.Click += new EventHandler(btnIT_Click);

            // btnTV
            this.btnTV.BackColor = System.Drawing.Color.Transparent;
            this.btnTV.Controls.Add(this.pctTV);
            this.btnTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTV.FlatAppearance.BorderSize = 0;
            this.btnTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTV.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTV.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTV.Image = Image.FromFile(path + "dreapta.png");
            this.btnTV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTV.Location = new System.Drawing.Point(12, 491);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(386, 60);
            this.btnTV.TabIndex = 2;
            this.btnTV.Text = "            TV, Audio-Video, Foto";
            this.btnTV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTV.UseVisualStyleBackColor = false;
            this.btnTV.Click += new EventHandler(btnTV_Cick); 

            // pctTV
            this.pctTV.BackColor = System.Drawing.Color.Transparent;
            this.pctTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctTV.Image = Image.FromFile(path + "tv.png");
            this.pctTV.Location = new System.Drawing.Point(12, 3);
            this.pctTV.Name = "pctTV";
            this.pctTV.Size = new System.Drawing.Size(54, 54);
            this.pctTV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctTV.TabIndex = 0;
            this.pctTV.TabStop = false;
            this.pctTV.Click += new EventHandler(btnTV_Cick);

            // lblMenu
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMenu.Location = new System.Drawing.Point(123, 29);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(112, 40);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
             
            // lblSignOut
            this.lblSignOut.AutoSize = true;
            this.lblSignOut.BackColor = System.Drawing.Color.Transparent;
            this.lblSignOut.Font = new System.Drawing.Font("Century Gothic", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignOut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignOut.Location = new System.Drawing.Point(111, 801);
            this.lblSignOut.Name = "lblSignOut";
            this.lblSignOut.Size = new System.Drawing.Size(124, 33);
            this.lblSignOut.Cursor = Cursors.Hand;
            this.lblSignOut.Text = "Sign Out";
            this.lblSignOut.Click += new EventHandler(pctExit_Click);
             
            // btnToys
            this.btnToys.BackColor = System.Drawing.Color.Transparent;
            this.btnToys.Controls.Add(this.pctToys);
            this.btnToys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToys.FlatAppearance.BorderSize = 0;
            this.btnToys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToys.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToys.ForeColor = System.Drawing.SystemColors.Control;
            this.btnToys.Image = Image.FromFile(path + "dreapta.png");
            this.btnToys.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToys.Location = new System.Drawing.Point(12, 412);
            this.btnToys.Name = "btnToys";
            this.btnToys.Size = new System.Drawing.Size(386, 60);
            this.btnToys.TabIndex = 2;
            this.btnToys.Text = "            Children, Toys";
            this.btnToys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToys.UseVisualStyleBackColor = false;
            this.btnToys.Click += new EventHandler(btnToys_Click);

            // pctToys
            this.pctToys.BackColor = System.Drawing.Color.Transparent;
            this.pctToys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctToys.Image = Image.FromFile(path + "toy.png");
            this.pctToys.Location = new System.Drawing.Point(12, 3);
            this.pctToys.Name = "pctToys";
            this.pctToys.Size = new System.Drawing.Size(54, 54);
            this.pctToys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctToys.TabIndex = 0;
            this.pctToys.TabStop = false;
            this.pctToys.Click += new EventHandler(btnToys_Click);

            // btnElectro
            this.btnElectro.BackColor = System.Drawing.Color.Transparent;
            this.btnElectro.Controls.Add(this.pctElectro);
            this.btnElectro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElectro.FlatAppearance.BorderSize = 0;
            this.btnElectro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElectro.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElectro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnElectro.Image = Image.FromFile(path + "dreapta.png");
            this.btnElectro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnElectro.Location = new System.Drawing.Point(12, 254);
            this.btnElectro.Name = "btnElectro";
            this.btnElectro.Size = new System.Drawing.Size(386, 60);
            this.btnElectro.TabIndex = 2;
            this.btnElectro.Text = "            Electronics";
            this.btnElectro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElectro.UseVisualStyleBackColor = false;
            this.btnElectro.Click += new EventHandler(btnElectro_Click); 

            // pctElectro
            this.pctElectro.BackColor = System.Drawing.Color.Transparent;
            this.pctElectro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctElectro.Image = Image.FromFile(path + "electro.png");
            this.pctElectro.Location = new System.Drawing.Point(12, 3);
            this.pctElectro.Name = "pctElectro";
            this.pctElectro.Size = new System.Drawing.Size(54, 54);
            this.pctElectro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctElectro.TabIndex = 0;
            this.pctElectro.TabStop = false;
            this.pctElectro.Click += new EventHandler(btnElectro_Click);

            // btnGarden
            this.btnGarden.BackColor = System.Drawing.Color.Transparent;
            this.btnGarden.Controls.Add(this.pctGarden);
            this.btnGarden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGarden.FlatAppearance.BorderSize = 0;
            this.btnGarden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGarden.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGarden.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGarden.Image = Image.FromFile(path + "dreapta.png");
            this.btnGarden.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGarden.Location = new System.Drawing.Point(12, 333);
            this.btnGarden.Name = "btnGarden";
            this.btnGarden.Size = new System.Drawing.Size(386, 60);
            this.btnGarden.TabIndex = 2;
            this.btnGarden.Text = "            House, Garden";
            this.btnGarden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGarden.UseVisualStyleBackColor = false;
            this.btnGarden.Click += new EventHandler(btnGarden_Click); 

            // pctGarden
            this.pctGarden.BackColor = System.Drawing.Color.Transparent;
            this.pctGarden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGarden.Image = Image.FromFile(path + "garden.png");
            this.pctGarden.Location = new System.Drawing.Point(12, 3);
            this.pctGarden.Name = "pctGarden";
            this.pctGarden.Size = new System.Drawing.Size(54, 54);
            this.pctGarden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctGarden.TabIndex = 0;
            this.pctGarden.TabStop = false;
            this.pctGarden.Click += new EventHandler(btnGarden_Click);

            // pctMenu
            this.pctMenu.BackColor = System.Drawing.Color.Transparent;
            this.pctMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMenu.Image = Image.FromFile(path + "menu.png");
            this.pctMenu.Location = new System.Drawing.Point(24, 34);
            this.pctMenu.Name = "pctMenu";
            this.pctMenu.Size = new System.Drawing.Size(62, 45);
            this.pctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMenu.TabIndex = 0;
            this.pctMenu.TabStop = false;
            this.pctMenu.Click += new System.EventHandler(this.pctMenu_Click);
             
            // grandTop
            this.grandTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grandTop.Controls.Add(this.lblAccount);
            this.grandTop.Controls.Add(this.lblFav);
            this.grandTop.Controls.Add(this.lblCart);
            this.grandTop.Controls.Add(this.pctFavRed);
            this.grandTop.Controls.Add(this.pctRedCart);
            this.grandTop.Controls.Add(this.pctAccount);
            this.grandTop.Controls.Add(this.pctFavorite);
            this.grandTop.Controls.Add(this.pctCart);
            this.grandTop.Controls.Add(this.pctMini);
            this.grandTop.Controls.Add(this.pctClose);
            this.grandTop.Controls.Add(this.pctLogo);
            this.grandTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grandTop.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.grandTop.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.grandTop.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.grandTop.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(60)))));
            this.grandTop.Location = new System.Drawing.Point(0, 0);
            this.grandTop.Name = "grandTop";
            this.grandTop.Quality = 10;
            this.grandTop.Size = new System.Drawing.Size(1797, 126);
            this.grandTop.TabIndex = 0;
             
            // lblAccount
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccount.Location = new System.Drawing.Point(1104, 44);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(178, 34);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "My account";
            this.lblAccount.Click += new System.EventHandler(this.pctAccount_Click);

            // lblFav
            this.lblFav.AutoSize = true;
            this.lblFav.BackColor = System.Drawing.Color.Transparent;
            this.lblFav.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFav.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFav.Location = new System.Drawing.Point(1373, 44);
            this.lblFav.Name = "lblFav";
            this.lblFav.Size = new System.Drawing.Size(134, 34);
            this.lblFav.TabIndex = 1;
            this.lblFav.Text = "Favorites";
            this.lblFav.Click += new System.EventHandler(this.pctFav_Click);
            this.lblFav.Cursor = System.Windows.Forms.Cursors.Hand;

            // lblCart
            this.lblCart.AutoSize = true;
            this.lblCart.BackColor = System.Drawing.Color.Transparent;
            this.lblCart.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCart.Location = new System.Drawing.Point(1594, 44);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(72, 34);
            this.lblCart.TabIndex = 1;
            this.lblCart.Text = "Cart";
            this.lblCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCart.Click += new System.EventHandler(this.pctCart_Click);

            // pctFavRed
            this.pctFavRed.BackColor = System.Drawing.Color.Transparent;
            this.pctFavRed.Controls.Add(this.lblCountFav);
            this.pctFavRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctFavRed.Image = Image.FromFile(path + "circle.png");
            this.pctFavRed.Location = new System.Drawing.Point(1349, 22);
            this.pctFavRed.Name = "pctFavRed";
            this.pctFavRed.Size = new System.Drawing.Size(27, 27);
            this.pctFavRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
             
            // lblCountFav
            this.lblCountFav.AutoSize = true;
            this.lblCountFav.BackColor = System.Drawing.Color.Transparent;
            this.lblCountFav.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountFav.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCountFav.Location = new System.Drawing.Point(4, 4);
            this.lblCountFav.Name = "lblCountFav";
            this.lblCountFav.Size = new System.Drawing.Size(18, 19);
            this.lblCountFav.TabIndex = 1;
            this.lblCountFav.Text = "0";
             
            // pctRedCart
            this.pctRedCart.BackColor = System.Drawing.Color.Transparent;
            this.pctRedCart.Controls.Add(this.lblCountCart);
            this.pctRedCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctRedCart.Image = Image.FromFile(path + "circle.png");
            this.pctRedCart.Location = new System.Drawing.Point(1570, 22);
            this.pctRedCart.Name = "pctRedCart";
            this.pctRedCart.Size = new System.Drawing.Size(27, 27);
            this.pctRedCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
             
            // lblCountCart
            this.lblCountCart.AutoSize = true;
            this.lblCountCart.BackColor = System.Drawing.Color.Transparent;
            this.lblCountCart.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCart.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCountCart.Location = new System.Drawing.Point(4, 4);
            this.lblCountCart.Name = "lblCountCart";
            this.lblCountCart.Size = new System.Drawing.Size(18, 19);
            this.lblCountCart.TabIndex = 1;
            this.lblCountCart.Text = "0";
             
            // pctAccount
            this.pctAccount.BackColor = System.Drawing.Color.Transparent;
            this.pctAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctAccount.Image = Image.FromFile(path + "account.png");
            this.pctAccount.Location = new System.Drawing.Point(1024, 32);
            this.pctAccount.Name = "pctAccount";
            this.pctAccount.Size = new System.Drawing.Size(81, 58);
            this.pctAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAccount.TabIndex = 0;
            this.pctAccount.TabStop = false;
            this.pctAccount.Click += new System.EventHandler(this.pctAccount_Click);
             
            // pctFavorite
            this.pctFavorite.BackColor = System.Drawing.Color.Transparent;
            this.pctFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctFavorite.Image = Image.FromFile(path + "heart.png");
            this.pctFavorite.Location = new System.Drawing.Point(1293, 32);
            this.pctFavorite.Name = "pctFavorite";
            this.pctFavorite.Size = new System.Drawing.Size(81, 58);
            this.pctFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFavorite.TabIndex = 0;
            this.pctFavorite.TabStop = false;
            this.pctFavorite.Click += new System.EventHandler(this.pctFav_Click);
             
            // pctCart
            this.pctCart.BackColor = System.Drawing.Color.Transparent;
            this.pctCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCart.Image = Image.FromFile(path + "cart.png");
            this.pctCart.Location = new System.Drawing.Point(1514, 32);
            this.pctCart.Name = "pctCart";
            this.pctCart.Size = new System.Drawing.Size(81, 58);
            this.pctCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCart.TabIndex = 0;
            this.pctCart.TabStop = false;
            this.pctCart.Click += new System.EventHandler(this.pctCart_Click);
             
            // pctMini
            this.pctMini.BackColor = System.Drawing.Color.Transparent;
            this.pctMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMini.Image = Image.FromFile(path + "mini.png");
            this.pctMini.Location = new System.Drawing.Point(1688, 42);
            this.pctMini.Name = "pctMini";
            this.pctMini.Size = new System.Drawing.Size(30, 43);
            this.pctMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMini.TabIndex = 0;
            this.pctMini.TabStop = false;
            this.pctMini.Click += new System.EventHandler(this.pctMini_Click);
             
            // pctClose
            this.pctClose.BackColor = System.Drawing.Color.Transparent;
            this.pctClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctClose.Image = Image.FromFile(path + "close1.png");
            this.pctClose.Location = new System.Drawing.Point(1736, 42);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(40, 43);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClose.TabIndex = 0;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.pctClose_Click);
             
            // pctLogo
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = Image.FromFile(path + "logoG.gif");
            this.pctLogo.Location = new System.Drawing.Point(-66, -112);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(480, 352);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
             
            // timeSlideMenu
            this.timeSlideMenu.Interval = 1;
            this.timeSlideMenu.Tick += new System.EventHandler(this.timeSlideMenu_Tick);

            pnlCards.Dock = DockStyle.Fill;/*
            this.pnlSideBar.Dock = DockStyle.Fill; // Poziționați pnlSideBar pentru a umple spațiul disponibil
            this.grandTop.Dock = DockStyle.Fill;*/
            //pnlCards.BackColor = Color.Red;
        }
        PnlCards pnlc = null;
        public void removePnlFromHome(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);

        }


        private void pctClose_Click(object sender, EventArgs e)
        {
            this.form.Close();
        }

        private void pctMini_Click(object sender, EventArgs e)
        {
            this.form.WindowState = FormWindowState.Minimized;
        }

        private void pctCart_Click(object sender, EventArgs e)
        {

        }

        private void pctFav_Click(object sender, EventArgs e)
        {

        }

        private void pctAccount_Click(object sender, EventArgs e)
        {

        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            this.form.removePnl("PnlHome");
            user = null;
            this.form.Controls.Add(new PnlLogin(form));
        }

        private void timeSlideMenu_Tick(object sender, EventArgs e)
        {

            if (sidebar)
            {
                if (pnlc != null)
                {
                Point newLocation = pnlc.Location;
                newLocation.X -= 10;
                pnlc.Location = newLocation;
                }
                pnlSideBar.Width -= 10;
                if (pnlSideBar.Width == pnlSideBar.MinimumSize.Width)
                {
                    sidebar = false;
                    timeSlideMenu.Stop();

                }

            }
            else
            {
                if (pnlc != null){

                Point newLocation = pnlc.Location;
                newLocation.X += 10;
                pnlc.Location = newLocation;
                }
                pnlSideBar.Width += 10;
                if (pnlSideBar.Width == pnlSideBar.MaximumSize.Width)
                {
                    sidebar = true;
                    timeSlideMenu.Stop();

                }
            }

        }
       
        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            PnlCards pnl = GetPnlCards();
            string name = pnl.cmbSort.SelectedItem.ToString();
            //MessageBox.Show(name);
            if (name == "Price: High to Low")
            {
                List<Product> descrescator = new List<Product>();
                descrescator = pnl.products.OrderByDescending(p => p.getPrice()).ToList();
                this.removePnlFromHome("PnlCards");
                pnlSideBar.Width = pnlSideBar.MinimumSize.Width;
                 pnlc = new PnlCards(ct, form, descrescator, user);
                this.Controls.Add(pnlc);
                this.pnlc.cmbSort.SelectedIndexChanged += new EventHandler(cmbSort_SelectedIndexChanged);

            }
            else if (name == "Price: Low to High")
            {
                List<Product> crescator = new List<Product>();
                crescator = pnl.products.OrderBy(p => p.getPrice()).ToList();
                this.removePnlFromHome("PnlCards");
                pnlSideBar.Width = pnlSideBar.MinimumSize.Width;

                pnlc = new PnlCards(ct, form, crescator, user);
                this.Controls.Add(pnlc);
                // pnl.Dock = DockStyle.Fill;
                //pnl.Location = new Point(105, 126);
                this.pnlc.cmbSort.SelectedIndexChanged += new EventHandler(cmbSort_SelectedIndexChanged);

            }


        }

        public PnlCards GetPnlCards()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel && control.Name == "PnlCards")
                {
                    return (PnlCards)control;
                }
            }

            return null; 
        }

        private void pctMenu_Click(object sender, EventArgs e)
        {
            timeSlideMenu.Start();
           
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            PnlCards pnl = GetPnlCards();

            List<Product> getIt = new List<Product>();
            getIt = productQueryService.getProductWithCateg("it");
            this.removePnlFromHome("PnlCards");
            pnlSideBar.Width = pnlSideBar.MinimumSize.Width;
            pnlc = new PnlCards(ct, form, getIt, user);
            this.Controls.Add(pnlc);
            this.pnlc.cmbSort.SelectedIndexChanged += new EventHandler(cmbSort_SelectedIndexChanged);


        }

        private void btnTV_Cick(object sender, EventArgs e)
        {
            PnlCards pnl = GetPnlCards();

            List<Product> getIt = new List<Product>();
            getIt = productQueryService.getProductWithCateg("tv");
            this.removePnlFromHome("PnlCards");
            pnlSideBar.Width = pnlSideBar.MinimumSize.Width;
            pnlc = new PnlCards(ct, form, getIt, user);
            this.Controls.Add(pnlc);
            this.pnlc.cmbSort.SelectedIndexChanged += new EventHandler(cmbSort_SelectedIndexChanged);


        }

        private void btnToys_Click(object sender, EventArgs e)
        {
            PnlCards pnl = GetPnlCards();

            List<Product> getIt = new List<Product>();
            getIt = productQueryService.getProductWithCateg("toy");
            this.removePnlFromHome("PnlCards");
            pnlSideBar.Width = pnlSideBar.MinimumSize.Width;
            pnlc = new PnlCards(ct, form, getIt, user);
            this.Controls.Add(pnlc);
            this.pnlc.cmbSort.SelectedIndexChanged += new EventHandler(cmbSort_SelectedIndexChanged);


        }

        private void btnElectro_Click(object sender, EventArgs e)
        {
            PnlCards pnl = GetPnlCards();

            List<Product> getIt = new List<Product>();
            getIt = productQueryService.getProductWithCateg("electro");
            this.removePnlFromHome("PnlCards");
            pnlSideBar.Width = pnlSideBar.MinimumSize.Width;
            pnlc = new PnlCards(ct, form, getIt, user);
            this.Controls.Add(pnlc);
            this.pnlc.cmbSort.SelectedIndexChanged += new EventHandler(cmbSort_SelectedIndexChanged);


        }

        private void btnGarden_Click(object sender, EventArgs e)
        {
            PnlCards pnl = GetPnlCards();

            List<Product> getIt = new List<Product>();
            getIt = productQueryService.getProductWithCateg("garden");
            this.removePnlFromHome("PnlCards");
            pnlSideBar.Width = pnlSideBar.MinimumSize.Width;
            pnlc = new PnlCards(ct, form, getIt, user);
            this.Controls.Add(pnlc);
            this.pnlc.cmbSort.SelectedIndexChanged += new EventHandler(cmbSort_SelectedIndexChanged);


        }
    }
}
