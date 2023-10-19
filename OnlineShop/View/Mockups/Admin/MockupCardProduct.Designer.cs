namespace OnlineShop.View.Mockups.Admin
{
    partial class MockupCardProduct
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPRP = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pctImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(12, 355);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(110, 28);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "3.199 Lei";
            // 
            // lblPRP
            // 
            this.lblPRP.AutoSize = true;
            this.lblPRP.BackColor = System.Drawing.Color.Transparent;
            this.lblPRP.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblPRP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPRP.Location = new System.Drawing.Point(13, 335);
            this.lblPRP.Name = "lblPRP";
            this.lblPRP.Size = new System.Drawing.Size(100, 20);
            this.lblPRP.TabIndex = 1;
            this.lblPRP.Text = "PRP: 4000 Lei";
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.BackColor = System.Drawing.Color.Transparent;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.lblTile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTile.Location = new System.Drawing.Point(1, 244);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(333, 75);
            this.lblTile.TabIndex = 1;
            this.lblTile.Text = "Laptop Acer Aspire 5 A515-57 \r\ncu procesor Intel® Core™ \r\ni7-1255U";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Orange;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Image = global::OnlineShop.Properties.Resources.trash_can__1_1;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(0, 398);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(334, 47);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // pctImage
            // 
            this.pctImage.BackColor = System.Drawing.Color.White;
            this.pctImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pctImage.Image = global::OnlineShop.Properties.Resources.Screenshot_2023_09_26_225259;
            this.pctImage.Location = new System.Drawing.Point(6, 5);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(321, 225);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImage.TabIndex = 0;
            this.pctImage.TabStop = false;
            // 
            // MockupCardProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 445);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pctImage);
            this.Controls.Add(this.lblPRP);
            this.Controls.Add(this.lblTile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MockupCardProduct";
            this.Text = "MockupCardProduct";
            this.Load += new System.EventHandler(this.MockupCardProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPRP;
        private System.Windows.Forms.Label lblTile;
    }
}