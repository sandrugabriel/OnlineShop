namespace OnlineShop.View.Mockups.Admin
{
    partial class MockupProductsEdit
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
            this.lblUp = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.lblTile = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.eliSave = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.eliRemove = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pctDesign1 = new System.Windows.Forms.PictureBox();
            this.pctUpload = new System.Windows.Forms.PictureBox();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.pctBack = new System.Windows.Forms.PictureBox();
            this.txtTile = new System.Windows.Forms.RichTextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.numericStock = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDesign1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(734, 382);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 49);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = " Lei";
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUp.ForeColor = System.Drawing.Color.DimGray;
            this.lblUp.Location = new System.Drawing.Point(524, 246);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(111, 33);
            this.lblUp.TabIndex = 16;
            this.lblUp.Text = "Upload";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.Color.DimGray;
            this.lblP.Location = new System.Drawing.Point(531, 333);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(118, 44);
            this.lblP.TabIndex = 16;
            this.lblP.Text = "Price:";
            // 
            // numericPrice
            // 
            this.numericPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPrice.ForeColor = System.Drawing.Color.Red;
            this.numericPrice.Location = new System.Drawing.Point(539, 380);
            this.numericPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(189, 55);
            this.numericPrice.TabIndex = 18;
            this.numericPrice.Value = new decimal(new int[] {
            319999,
            0,
            0,
            131072});
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.ForeColor = System.Drawing.Color.Black;
            this.lblTile.Location = new System.Drawing.Point(141, 524);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(560, 44);
            this.lblTile.TabIndex = 20;
            this.lblTile.Text = "Description and Specifications";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(130, 581);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1377, 388);
            this.txtDescription.TabIndex = 22;
            this.txtDescription.Text = "";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Orange;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(1344, 386);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(369, 86);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Wheat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1344, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(369, 86);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // eliSave
            // 
            this.eliSave.ElipseRadius = 35;
            this.eliSave.TargetControl = this.btnSave;
            // 
            // eliRemove
            // 
            this.eliRemove.ElipseRadius = 35;
            this.eliRemove.TargetControl = this.btnRemove;
            // 
            // pctDesign1
            // 
            this.pctDesign1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctDesign1.Location = new System.Drawing.Point(131, 569);
            this.pctDesign1.Name = "pctDesign1";
            this.pctDesign1.Size = new System.Drawing.Size(603, 2);
            this.pctDesign1.TabIndex = 21;
            this.pctDesign1.TabStop = false;
            // 
            // pctUpload
            // 
            this.pctUpload.Image = global::OnlineShop.Properties.Resources.camera__1_1;
            this.pctUpload.Location = new System.Drawing.Point(539, 168);
            this.pctUpload.Name = "pctUpload";
            this.pctUpload.Size = new System.Drawing.Size(85, 75);
            this.pctUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUpload.TabIndex = 13;
            this.pctUpload.TabStop = false;
            // 
            // pctImage
            // 
            this.pctImage.Location = new System.Drawing.Point(156, 144);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(340, 328);
            this.pctImage.TabIndex = 13;
            this.pctImage.TabStop = false;
            // 
            // pctBack
            // 
            this.pctBack.Image = global::OnlineShop.Properties.Resources.back;
            this.pctBack.Location = new System.Drawing.Point(130, 12);
            this.pctBack.Name = "pctBack";
            this.pctBack.Size = new System.Drawing.Size(64, 63);
            this.pctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBack.TabIndex = 13;
            this.pctBack.TabStop = false;
            // 
            // txtTile
            // 
            this.txtTile.BackColor = System.Drawing.SystemColors.Control;
            this.txtTile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTile.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTile.Location = new System.Drawing.Point(901, 144);
            this.txtTile.Name = "txtTile";
            this.txtTile.Size = new System.Drawing.Size(812, 122);
            this.txtTile.TabIndex = 22;
            this.txtTile.Text = "Laptop asdasdasfasfasfadgfdhb sgregrgrd gdrg drgdgrdgrdg";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.DimGray;
            this.lblStock.Location = new System.Drawing.Point(971, 339);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(125, 44);
            this.lblStock.TabIndex = 16;
            this.lblStock.Text = "Stock:";
            // 
            // numericStock
            // 
            this.numericStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericStock.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericStock.Location = new System.Drawing.Point(979, 386);
            this.numericStock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericStock.Name = "numericStock";
            this.numericStock.Size = new System.Drawing.Size(143, 55);
            this.numericStock.TabIndex = 18;
            this.numericStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MockupProductsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1797, 981);
            this.Controls.Add(this.txtTile);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.pctDesign1);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.numericStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pctUpload);
            this.Controls.Add(this.pctImage);
            this.Controls.Add(this.pctBack);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MockupProductsEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MockupProductsEdit";
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDesign1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctBack;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pctUpload;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.PictureBox pctDesign1;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.RichTextBox txtDescription;
        private Bunifu.Framework.UI.BunifuElipse eliSave;
        private Bunifu.Framework.UI.BunifuElipse eliRemove;
        private System.Windows.Forms.RichTextBox txtTile;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown numericStock;
    }
}