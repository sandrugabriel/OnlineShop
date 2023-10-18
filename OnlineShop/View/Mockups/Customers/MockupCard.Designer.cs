namespace OnlineShop.Mockups
{
    partial class MockupCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPRP = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.pctFav = new System.Windows.Forms.PictureBox();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.eliCard = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctFav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(12, 350);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(110, 28);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "3.199 Lei";
            // 
            // lblPRP
            // 
            this.lblPRP.AutoSize = true;
            this.lblPRP.BackColor = System.Drawing.Color.Transparent;
            this.lblPRP.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblPRP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPRP.Location = new System.Drawing.Point(13, 317);
            this.lblPRP.Name = "lblPRP";
            this.lblPRP.Size = new System.Drawing.Size(100, 20);
            this.lblPRP.TabIndex = 6;
            this.lblPRP.Text = "PRP: 4000 Lei";
            // 
            // lblTile
            // 
            this.lblTile.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lblTile.AutoEllipsis = true;
            this.lblTile.BackColor = System.Drawing.Color.Transparent;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.lblTile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTile.Location = new System.Drawing.Point(4, 227);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(339, 75);
            this.lblTile.TabIndex = 7;
            this.lblTile.Text = "Laptop Acer Aspire 5 A515-57 cu procesor Intel® Core™ i7-1255U";
            // 
            // pctFav
            // 
            this.pctFav.Image = global::OnlineShop.Properties.Resources.heart__2_;
            this.pctFav.Location = new System.Drawing.Point(300, 12);
            this.pctFav.Name = "pctFav";
            this.pctFav.Size = new System.Drawing.Size(24, 28);
            this.pctFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFav.TabIndex = 8;
            this.pctFav.TabStop = false;
            this.pctFav.Click += new System.EventHandler(this.pctFav_Click);
            // 
            // pctImage
            // 
            this.pctImage.BackColor = System.Drawing.Color.White;
            this.pctImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pctImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctImage.Image = global::OnlineShop.Properties.Resources.Screenshot_2023_09_26_225259;
            this.pctImage.Location = new System.Drawing.Point(0, 0);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(336, 215);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImage.TabIndex = 4;
            this.pctImage.TabStop = false;
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.Orange;
            this.btnAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddCart.FlatAppearance.BorderSize = 0;
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddCart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCart.Image = global::OnlineShop.Properties.Resources.shopping_cart__2_;
            this.btnAddCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCart.Location = new System.Drawing.Point(0, 390);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(336, 47);
            this.btnAddCart.TabIndex = 9;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // eliCard
            // 
            this.eliCard.ElipseRadius = 35;
            this.eliCard.TargetControl = this;
            // 
            // MockupCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 437);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.pctFav);
            this.Controls.Add(this.pctImage);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPRP);
            this.Controls.Add(this.lblTile);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MockupCard";
            this.Text = "MockupCard";
            ((System.ComponentModel.ISupportInitialize)(this.pctFav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFav;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPRP;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Button btnAddCart;
        private Bunifu.Framework.UI.BunifuElipse eliCard;
    }
}