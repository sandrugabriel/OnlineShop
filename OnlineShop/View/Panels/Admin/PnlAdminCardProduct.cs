using Bunifu.Framework.UI;
using OnlineShop.Models;
using OnlineShop.Products.Service;
using OnlineShop.Products.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        RichTextBox txtTile;
        Label lblPRP;
        Label lblPrice;
        Button btnRemove;
        Button btnEdit;
        Button btnSave;
        Label lblUp;
        PictureBox pctUP;

        BunifuElipse eliBtn;
        BunifuElipse eliImage;

        IProductComandService productComandService;
        IProductQueryService productQueryService;

        List<Product> products;

        OpenFileDialog openFileDialog1;

        string imageName;

        NumericUpDown numericPrice;

        public PnlAdminCardProduct(Form1 form1,Product product1) {
        
            this.form = form1;
            this.product = product1;

            productComandService = ProductComandServiceSingleton.Instance;
            productQueryService = ProductQueryServiceSingleton.Instance;

            products = productQueryService.getAll();

            this.Name = "PnlAdminCardProduct";
            this.Size = new System.Drawing.Size(334, 445);
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            //this.Click += new EventHandler(all_Click);

            pctImage = new PictureBox();
            txtTile = new RichTextBox();
            lblPRP = new Label();
            lblPrice = new Label();
            btnRemove = new Button();
            eliBtn = new BunifuElipse();
            eliImage = new BunifuElipse();
            btnEdit = new Button();
            lblUp = new Label();    
            pctUP = new PictureBox();
            btnSave = new Button();
            numericPrice = new NumericUpDown();

            this.Controls.Add(numericPrice);
            this.Controls.Add(pctImage);
            this.Controls.Add(txtTile);
            this.Controls.Add(lblPRP);
            this.Controls.Add(lblPrice);
            this.Controls.Add(btnRemove);
            this.Controls.Add(btnEdit);
           // this.Controls.Add(lblUp);
           // this.Controls.Add(pctUP);
            this.Controls.Add(btnSave);

            this.eliBtn.TargetControl = this;
            this.eliBtn.ElipseRadius = 45;

            this.eliImage.TargetControl = pctImage;
            this.eliImage.ElipseRadius = 45;

            //pctUP
            this.pctUP.Location = new Point(220, 320);
            this.pctUP.Size = new Size(40,40);
            this.pctUP.Image = Image.FromFile(Application.StartupPath + @"/Images/up.png");
            this.pctUP.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctUP.Click += new EventHandler(pctUP_Click);
            this.pctUP.Cursor = Cursors.Hand;
            this.pctUP.Visible = false;

            //lblUP
            this.lblUp.Location = new Point(205, 360);
            this.lblUp.AutoSize = true;
            this.lblUp.Font = new Font("Century Gothic", 11);
            this.lblUp.Text = "Upload";
            this.lblUp.Visible = false;

            //pctImage
            this.pctImage.Location = new System.Drawing.Point(6, 5);
            this.pctImage.Size = new System.Drawing.Size(321, 225);
            this.pctImage.Image = Image.FromFile(Application.StartupPath + $@"/Images/Products/{product.getPathImage()}");
            this.pctImage.SizeMode = PictureBoxSizeMode.Zoom;

            //txtTile
            this.txtTile.Size = new System.Drawing.Size(333, 75);
            this.txtTile.Location = new Point(1, 244);
            this.txtTile.Text = product.getName();
            //this.txtTile.ScrollBars = RichTextBoxScrollBars.None;
            this.txtTile.Font = new Font("Century Gothic", 13);
            this.txtTile.ReadOnly = true;
            this.txtTile.BorderStyle = BorderStyle.None;
            this.txtTile.BackColor = SystemColors.ControlLight;

            //numeric
            this.numericPrice.Location = new Point(9, 353);
            this.numericPrice.Size = new Size(109, 30);
            this.numericPrice.Maximum = 100000;
            this.numericPrice.Minimum = 0;
            this.numericPrice.BorderStyle = BorderStyle.None;
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Value = ((decimal)product.getPrice());
            this.numericPrice.Font = new Font("Century Gothic", 13, FontStyle.Bold);
            this.numericPrice.ForeColor = Color.Red;
            this.numericPrice.ReadOnly = true;
            this.numericPrice.Visible = false;

            //lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Size = new System.Drawing.Size(333, 75);
            this.lblPrice.Location = new Point(9, 353);
            this.lblPrice.Text = product.getPrice()+ "  Lei";
            this.lblPrice.ForeColor = Color.Red;
            this.lblPrice.Font = new Font("Century Gothic", 14,FontStyle.Bold);
           // this.lblPrice.Click += new EventHandler(all_Click);

            //lblPRP
            this.lblPRP.AutoSize = true;
            this.lblPRP.Size = new System.Drawing.Size(333, 75);
            this.lblPRP.Location = new Point(5, 326);
            this.lblPRP.Text = "PRP: "+(product.getPrice() * 1.5).ToString("F2") + " Lei";
            this.lblPRP.ForeColor = SystemColors.ControlDarkDark;
           // this.lblPRP.Click += new EventHandler(all_Click);
            this.lblPRP.Font = new Font("Century Gothic", 10);

            //teste antrenament

            //btnRemove
            this.btnRemove.Location = new Point(0, 398);
            this.btnRemove.Size = new System.Drawing.Size(170, 47);
            this.btnRemove.Text = "Remove";
            this.btnRemove.Image = Image.FromFile(Application.StartupPath + @"/Images/remove.png");
            this.btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = FlatStyle.Flat;
            this.btnRemove.ForeColor = Color.White;
            this.btnRemove.BackColor = Color.Orange;
            this.btnRemove.Click += new EventHandler(btnRemove_Click);
            this.btnRemove.Cursor = Cursors.Hand;

            //btnEdit
            this.btnEdit.Location = new Point(170, 398);
            this.btnEdit.Size = new System.Drawing.Size(170, 47);
            this.btnEdit.Text = "Edit";
           // this.btnEdit.Image = Image.FromFile(Application.StartupPath + @"/Images/remove.png");
            this.btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.ForeColor = Color.White;
            this.btnEdit.BackColor = Color.DarkOrange;
            this.btnEdit.Click += new EventHandler(btnEdit_Click);
            this.btnEdit.Cursor = Cursors.Hand;

            //btnSave
            this.btnSave.Location = new Point(170, 398);
            this.btnSave.Size = new System.Drawing.Size(170, 47);
            this.btnSave.Text = "Save";
            // this.btnEdit.Image = Image.FromFile(Application.StartupPath + @"/Images/remove.png");
            this.btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.ForeColor = Color.White;
            this.btnSave.BackColor = Color.DarkOrange;
            this.btnSave.Click += new EventHandler(btnSave_Click);
            this.btnSave.Cursor = Cursors.Hand;

            this.openFileDialog1 = new OpenFileDialog();
            imageName = product.getPathImage();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.pctImage.Click += new EventHandler(pctUP_Click);

            numericPrice.Visible = true;
            pctUP.Visible = true;
            lblUp.Visible = true;
            numericPrice.ReadOnly = false;
            txtTile.ReadOnly = false;
            this.btnEdit.Visible = false;
            this.btnSave.Visible = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            productComandService.save(products);
            productQueryService.save(products);

            numericPrice.ReadOnly = true;
            txtTile.ReadOnly = true;
            this.btnEdit.Visible = true;
            this.btnSave.Visible = false;
            numericPrice.Visible = false;
            pctUP.Visible = false;
            lblUp.Visible = false;
            productComandService.setAll(product.getId(),txtTile.Text,((double)numericPrice.Value),product.getStock(),imageName,product.getDescriere());
            productComandService.update();

            this.lblPrice.Text = product.getPrice() + "  Lei";
            this.lblPRP.Text = "PRP: " + (product.getPrice() * 1.5).ToString("F2") + " Lei";

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

        private void pctUP_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = Application.StartupPath + @"/Images/Products";
            openFileDialog1.Filter = "Imagini PNG|*.png";
            openFileDialog1.Title = "Selectați o imagine PNG";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                string destinationPath = Path.Combine(Application.StartupPath, "Images/Products", Path.GetFileName(selectedFilePath));
                File.Copy(selectedFilePath, destinationPath);
                imageName = Path.GetFileName(selectedFilePath);
                pctImage.Image = Image.FromFile(destinationPath);
            }
        }

    }
}
