namespace OnlineShop.View.Mockups.Customers
{
    partial class MockupCardPdf
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
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctImage
            // 
            this.pctImage.BackColor = System.Drawing.Color.White;
            this.pctImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pctImage.Image = global::OnlineShop.Properties.Resources.Screenshot_2023_09_26_225259;
            this.pctImage.Location = new System.Drawing.Point(7, 7);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(365, 188);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImage.TabIndex = 5;
            this.pctImage.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrice.Location = new System.Drawing.Point(1026, 49);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(140, 37);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "3.199 Lei";
            // 
            // lblTile
            // 
            this.lblTile.BackColor = System.Drawing.Color.Transparent;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.lblTile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTile.Location = new System.Drawing.Point(441, 31);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(433, 132);
            this.lblTile.TabIndex = 7;
            this.lblTile.Text = "Laptop Acer Aspire 5 A515-57 \r\ncu procesor Intel® Core™ \r\ni7-1255U";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(1050, 116);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(86, 32);
            this.numericUpDown1.TabIndex = 8;
            // 
            // MockupCardPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1201, 206);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pctImage);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTile);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MockupCardPdf";
            this.Text = "MockupCardPdf";
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}