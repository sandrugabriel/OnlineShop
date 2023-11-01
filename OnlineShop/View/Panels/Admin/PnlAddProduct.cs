using OnlineShop.Models;
using OnlineShop.Products.Service;
using OnlineShop.Products.Service.interfaces;
using Siticone.Desktop.UI.WinForms.Suite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OnlineShop.View.Panels.Admin
{
    public class PnlAddProduct : Panel
    {
        Form1 form;

        private System.Windows.Forms.RichTextBox txtTile;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.PictureBox pctDesign1;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.NumericUpDown numericStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pctUpload;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.PictureBox pctBack;
        private Bunifu.Framework.UI.BunifuElipse eliSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCateg;
        private System.Windows.Forms.ComboBox cmbCateg;

        private OpenFileDialog openFileDialog1;

        string imageName = null;

        IProductComandService productComandService;
        IProductQueryService productQueryService;

        List<Product> products;

        public PnlAddProduct(Form1 form1) {

            form = form1;

            productComandService = ProductComandServiceSingleton.Instance;
            productQueryService = ProductQueryServiceSingleton.Instance;

            products = productQueryService.getAll();

            //PnlAddProduct
            this.Size = new System.Drawing.Size(1797, 981);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlAddProduct";

            this.txtTile = new System.Windows.Forms.RichTextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.pctDesign1 = new System.Windows.Forms.PictureBox();
            this.lblTile = new System.Windows.Forms.Label();
            this.numericStock = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.lblP = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pctUpload = new System.Windows.Forms.PictureBox();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.pctBack = new System.Windows.Forms.PictureBox();
            this.eliSave = new Bunifu.Framework.UI.BunifuElipse();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCateg = new System.Windows.Forms.Label();
            this.cmbCateg = new System.Windows.Forms.ComboBox();

            this.Controls.Add(this.cmbCateg);
            this.Controls.Add(this.txtTile);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.pctDesign1);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.numericStock);
            this.Controls.Add(this.lblCateg);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pctUpload);
            this.Controls.Add(this.pctImage);
            this.Controls.Add(this.pctBack);

            // txtTile
            this.txtTile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTile.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular);
            this.txtTile.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTile.Location = new System.Drawing.Point(907, 152);
            this.txtTile.Name = "txtTile";
            this.txtTile.Size = new System.Drawing.Size(812, 122);
            this.txtTile.TabIndex = 36;
            this.txtTile.Text = "NameProduct";

            // txtDescription
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(136, 589);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1377, 369);
            this.txtDescription.TabIndex = 37;
            this.txtDescription.Text = "Enter the description";

            // pctDesign1
            this.pctDesign1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctDesign1.Location = new System.Drawing.Point(137, 577);
            this.pctDesign1.Name = "pctDesign1";
            this.pctDesign1.Size = new System.Drawing.Size(603, 2);
            this.pctDesign1.TabIndex = 35;
            this.pctDesign1.TabStop = false;

            // lblTile
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular);
            this.lblTile.ForeColor = System.Drawing.Color.Black;
            this.lblTile.Location = new System.Drawing.Point(147, 532);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(560, 44);
            this.lblTile.TabIndex = 34;
            this.lblTile.Text = "Description and Specifications";

            // numericStock
            this.numericStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericStock.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.numericStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericStock.Location = new System.Drawing.Point(1442, 337);
            this.numericStock.Maximum = new decimal(new int[] {
1000000,
0,
0,
0});
            this.numericStock.Name = "numericStock";
            this.numericStock.Size = new System.Drawing.Size(143, 55);
            this.numericStock.TabIndex = 32;
            this.numericStock.Value = new decimal(new int[] {
1,
0,
0,
0});

            // lblStock
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular);
            this.lblStock.ForeColor = System.Drawing.Color.DimGray;
            this.lblStock.Location = new System.Drawing.Point(1434, 290);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(125, 44);
            this.lblStock.TabIndex = 28;
            this.lblStock.Text = "Stock:";

            // numericPrice
            this.numericPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.numericPrice.ForeColor = System.Drawing.Color.Red;
            this.numericPrice.Location = new System.Drawing.Point(545, 388);
            this.numericPrice.Maximum = new decimal(new int[] {
1000000,
0,
0,
0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(189, 55);
            this.numericPrice.TabIndex = 33;
            this.numericPrice.Value = new decimal(new int[] {
319999,
0,
0,
131072});
             
            // lblP
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular);
            this.lblP.ForeColor = System.Drawing.Color.DimGray;
            this.lblP.Location = new System.Drawing.Point(537, 341);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(118, 44);
            this.lblP.TabIndex = 29;
            this.lblP.Text = "Price:";
             
            // lblUp
            this.lblUp.AutoSize = true;
            this.lblUp.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular);
            this.lblUp.ForeColor = System.Drawing.Color.DimGray;
            this.lblUp.Location = new System.Drawing.Point(530, 254);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(111, 33);
            this.lblUp.TabIndex = 30;
            this.lblUp.Text = "Upload";
             
            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(734, 390);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 49);
            this.lblPrice.TabIndex = 31;
            this.lblPrice.Text = " Lei";
             
            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.Wheat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1350, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(369, 86);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.Cursor = Cursors.Hand;
            this.btnSave.Click += new EventHandler(btnSave_Click);
             
            // pctUpload
            this.pctUpload.Image = global::OnlineShop.Properties.Resources.camera__1_1;
            this.pctUpload.Location = new System.Drawing.Point(545, 176);
            this.pctUpload.Name = "pctUpload";
            this.pctUpload.Size = new System.Drawing.Size(85, 75);
            this.pctUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUpload.Cursor = Cursors.Hand;
            this.pctUpload.Click += new EventHandler(pctUpload_Click);
             
            // pctImage
            this.pctImage.Location = new System.Drawing.Point(162, 152);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(340, 328);
            this.pctImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctImage.BackColor = Color.Gray;
            this.pctImage.Image = Image.FromFile(Application.StartupPath + @"/Images/AddProduct.png");
             
            // pctBack
            this.pctBack.Image = global::OnlineShop.Properties.Resources.back;
            this.pctBack.Location = new System.Drawing.Point(30, 30);
            this.pctBack.Name = "pctBack";
            this.pctBack.Size = new System.Drawing.Size(40, 40);
            this.pctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBack.Click += new EventHandler(pctBack_Click);
            
            // eliSave
            this.eliSave.ElipseRadius = 35;
            this.eliSave.TargetControl = this.btnSave;
             
            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular);
            this.lblName.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(899, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(139, 44);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name:";
             
            // lblCateg
            this.lblCateg.AutoSize = true;
            this.lblCateg.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular);
            this.lblCateg.ForeColor = System.Drawing.Color.DimGray;
            this.lblCateg.Location = new System.Drawing.Point(955, 341);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(198, 44);
            this.lblCateg.TabIndex = 28;
            this.lblCateg.Text = "Category:";
             
            // cmbCateg
            this.cmbCateg.FormattingEnabled = true;
            this.cmbCateg.Items.AddRange(new object[] {
"it",
"toy",
"garden",
"electro",
"tv"});
            this.cmbCateg.Location = new System.Drawing.Point(907, 402);
            this.cmbCateg.Name = "cmbCateg";
            this.cmbCateg.Size = new System.Drawing.Size(286, 35);
            this.cmbCateg.TabIndex = 38;
            this.cmbCateg.Text = "it";

            openFileDialog1 = new OpenFileDialog();
        }

        private void pctUpload_Click(object sender, System.EventArgs e)
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

        private void pctBack_Click(object sender, System.EventArgs e)
        {

            this.form.Controls.Clear();
            this.form.removePnl("PnlAddProduct");
            this.form.Controls.Add(new PnlEditProducts(form));

        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            productComandService.save(products);
            productQueryService.save(products);


            int id = productComandService.generareIdProduct();
            string name = txtTile.Text;
            double price = ((double)numericPrice.Value);
            int stock = ((int)numericStock.Value);
            string categ = cmbCateg.Text;

            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + $@"/descriere/{id.ToString()}.txt");
            streamWriter.Write(txtDescription.Text);
            streamWriter.Close();

            string t = id.ToString()+"|"+name + "|" +price.ToString("F2") + "|" +stock.ToString() + "|" + imageName + "|" +categ + "|" +id.ToString()+".txt";

            productComandService.saveFisier(t);

            Product product = new Product(t);
            products.Add(product);

            productComandService.save(products);
            productQueryService.save(products);

            this.form.Controls.Clear();
            this.form.removePnl("PnlAddProduct");
            this.form.Controls.Add(new PnlEditProducts(form));

        }

    }
}
