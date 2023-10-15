namespace OnlineShop.View.Mockups
{
    partial class MockupCartCard
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
            this.lblTile = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.eliThis = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.eliImage = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.quantity = new Guna.UI.WinForms.GunaNumeric();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrice.Location = new System.Drawing.Point(1034, 21);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(140, 37);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "3.199 Lei";
            // 
            // lblTile
            // 
            this.lblTile.BackColor = System.Drawing.Color.Transparent;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.lblTile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTile.Location = new System.Drawing.Point(444, 32);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(433, 132);
            this.lblTile.TabIndex = 1;
            this.lblTile.Text = "Laptop Acer Aspire 5 A515-57 \r\ncu procesor Intel® Core™ \r\ni7-1255U";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRemove.Image = global::OnlineShop.Properties.Resources.trash_can__3_;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(1022, 124);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 36);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "    Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // pctImage
            // 
            this.pctImage.BackColor = System.Drawing.Color.White;
            this.pctImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pctImage.Image = global::OnlineShop.Properties.Resources.Screenshot_2023_09_26_225259;
            this.pctImage.Location = new System.Drawing.Point(10, 8);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(365, 188);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImage.TabIndex = 0;
            this.pctImage.TabStop = false;
            // 
            // eliThis
            // 
            this.eliThis.ElipseRadius = 25;
            this.eliThis.TargetControl = this;
            // 
            // eliImage
            // 
            this.eliImage.ElipseRadius = 25;
            this.eliImage.TargetControl = this.pctImage;
            // 
            // quantity
            // 
            this.quantity.BaseColor = System.Drawing.Color.White;
            this.quantity.BorderColor = System.Drawing.Color.Silver;
            this.quantity.BorderSize = 0;
            this.quantity.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.quantity.ButtonForeColor = System.Drawing.Color.White;
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.Color.Black;
            this.quantity.Location = new System.Drawing.Point(1055, 78);
            this.quantity.Maximum = ((long)(9999999));
            this.quantity.Minimum = ((long)(0));
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(92, 30);
            this.quantity.TabIndex = 3;
            this.quantity.Text = "gunaNumeric1";
            this.quantity.Value = ((long)(0));
            this.quantity.Click += new System.EventHandler(this.quantity_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(906, 115);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 36);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MockupCartCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1186, 208);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pctImage);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTile);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MockupCartCard";
            this.Text = "MockupCartCard";
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTile;
        private Bunifu.Framework.UI.BunifuElipse eliThis;
        private Bunifu.Framework.UI.BunifuElipse eliImage;
        private Guna.UI.WinForms.GunaNumeric quantity;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}