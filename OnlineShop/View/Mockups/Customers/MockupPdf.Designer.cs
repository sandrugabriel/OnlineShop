namespace OnlineShop.View.Mockups.Customers
{
    partial class MockupPdf
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
            this.btnPdf = new System.Windows.Forms.Button();
            this.lblTile = new System.Windows.Forms.Label();
            this.pct = new System.Windows.Forms.PictureBox();
            this.btnPNG = new System.Windows.Forms.Button();
            this.eliPDf = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.eliPNG = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataStart = new System.Windows.Forms.MonthCalendar();
            this.dataEnd = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.Orange;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPdf.Location = new System.Drawing.Point(1177, 684);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(308, 85);
            this.btnPdf.TabIndex = 0;
            this.btnPdf.Text = "Save In PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.Location = new System.Drawing.Point(86, 29);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(136, 44);
            this.lblTile.TabIndex = 1;
            this.lblTile.Text = "Orders";
            // 
            // pct
            // 
            this.pct.BackColor = System.Drawing.Color.Black;
            this.pct.Location = new System.Drawing.Point(73, 71);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(185, 2);
            this.pct.TabIndex = 2;
            this.pct.TabStop = false;
            // 
            // btnPNG
            // 
            this.btnPNG.BackColor = System.Drawing.Color.Orange;
            this.btnPNG.FlatAppearance.BorderSize = 0;
            this.btnPNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPNG.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPNG.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPNG.Location = new System.Drawing.Point(632, 684);
            this.btnPNG.Name = "btnPNG";
            this.btnPNG.Size = new System.Drawing.Size(308, 85);
            this.btnPNG.TabIndex = 0;
            this.btnPNG.Text = "Save In PNG";
            this.btnPNG.UseVisualStyleBackColor = false;
            // 
            // eliPDf
            // 
            this.eliPDf.ElipseRadius = 35;
            this.eliPDf.TargetControl = this.btnPdf;
            // 
            // eliPNG
            // 
            this.eliPNG.ElipseRadius = 35;
            this.eliPNG.TargetControl = this.btnPNG;
            // 
            // dataStart
            // 
            this.dataStart.Location = new System.Drawing.Point(38, 220);
            this.dataStart.Name = "dataStart";
            this.dataStart.TabIndex = 20;
            this.dataStart.TodayDate = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            // 
            // dataEnd
            // 
            this.dataEnd.Location = new System.Drawing.Point(38, 524);
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.TabIndex = 21;
            this.dataEnd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dataEnd_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Data Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Data Start";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1730, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(390, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 532);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(15, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1183, 227);
            this.panel2.TabIndex = 0;
            // 
            // MockupPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1692, 855);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataEnd);
            this.Controls.Add(this.dataStart);
            this.Controls.Add(this.pct);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.btnPNG);
            this.Controls.Add(this.btnPdf);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MockupPdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MockupPdf";
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.Button btnPNG;
        private Bunifu.Framework.UI.BunifuElipse eliPDf;
        private Bunifu.Framework.UI.BunifuElipse eliPNG;
        private System.Windows.Forms.MonthCalendar dataStart;
        private System.Windows.Forms.MonthCalendar dataEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}