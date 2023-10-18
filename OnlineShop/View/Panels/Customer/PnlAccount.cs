using OnlineShop.Users.Models;
using OnlineShop.Users.Service;
using OnlineShop.Users.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace OnlineShop.Panels
{
    public class PnlAccount : Panel
    {
        Form1 form;
        User user;

        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPass;
        private System.Windows.Forms.Label lblPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnSave;
        private Bunifu.Framework.UI.BunifuElipse eliBtn;
        public Panel panel1;
        public PictureBox pctBack;

        IUserComandService userComandService;

        public PnlAccount(Form1 form1, User user1)
        {

            this.form = form1;
            this.user = user1;

            userComandService = UserComandServiceSingleton.Instance;

            //PnlAccount
            this.AutoSize = true;
            this.Size = new System.Drawing.Size(1797, 981);
            this.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PnlAccount";

            this.pctBack = new PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.eliBtn = new Bunifu.Framework.UI.BunifuElipse();

            this.panel1.Controls.Add(this.pctBack);
            this.Controls.Add(this.panel1);

            //pctBack
            this.pctBack.Location = new System.Drawing.Point(150,100);
            this.pctBack.Size = new System.Drawing.Size(35, 35);
            this.pctBack.Image = Image.FromFile(Application.StartupPath + @"\Images\left.png");
            this.pctBack.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctBack.Cursor = Cursors.Hand;
            this.pctBack.BackColor = Color.Transparent;

            // panel1
            this.panel1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Images\3.png");
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(460, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 964);

            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblTile);
             
            // txtAddress
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddress.HintText = "";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.AliceBlue;
            this.txtAddress.LineIdleColor = System.Drawing.Color.White;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.txtAddress.LineThickness = 3;
            this.txtAddress.Location = new System.Drawing.Point(162, 636);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(544, 49);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.Text = user.getAddress();
            
            // txtPhone
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.HintForeColor = System.Drawing.Color.Empty;
            this.txtPhone.HintText = "";
            this.txtPhone.isPassword = false;
            this.txtPhone.LineFocusedColor = System.Drawing.Color.AliceBlue;
            this.txtPhone.LineIdleColor = System.Drawing.Color.White;
            this.txtPhone.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.txtPhone.LineThickness = 3;
            this.txtPhone.Location = new System.Drawing.Point(163, 528);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(544, 49);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.Text = user.getPhone();
             
            // txtPass
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.HintForeColor = System.Drawing.Color.Empty;
            this.txtPass.HintText = "";
            this.txtPass.isPassword = true;
            this.txtPass.LineFocusedColor = System.Drawing.Color.AliceBlue;
            this.txtPass.LineIdleColor = System.Drawing.Color.White;
            this.txtPass.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.txtPass.LineThickness = 3;
            this.txtPass.Location = new System.Drawing.Point(162, 425);
            this.txtPass.Margin = new System.Windows.Forms.Padding(5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(544, 49);
            this.txtPass.TabIndex = 4;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.Text = user.getPassword(); 

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(158, 597);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(122, 34);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            
            // txtEmail
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.AliceBlue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.White;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(162, 322);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(544, 49);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Text = user.getEmail(); 

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(158, 489);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(102, 34);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone";
             
            // lblPass
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(157, 386);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(142, 34);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password";
             
            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(158, 283);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(88, 34);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
             
            // txtName
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.White;
            this.txtName.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(162, 211);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(544, 49);
            this.txtName.TabIndex = 4;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.Text = user.getName();

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(157, 172);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 34);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Full Name";
             
            // lblTile
            this.lblTile.AutoSize = true;
            this.lblTile.BackColor = System.Drawing.Color.Transparent;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTile.Location = new System.Drawing.Point(346, 102);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(163, 40);
            this.lblTile.TabIndex = 0;
            this.lblTile.Text = "SETTINGS";
            
            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(218, 785);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(427, 57);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Settings";
            this.btnSave.Click += new EventHandler(btnSave_Click); ;
             
            // eliBtn
            this.eliBtn.ElipseRadius = 25;
            this.eliBtn.TargetControl = this.btnSave;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.setName(txtName.Text);
            user.setEmail(txtEmail.Text);
            user.setAddress(txtAddress.Text);
            user.setPhone(txtPhone.Text);
            user.setPassword(txtPass.Text);

            userComandService.setAll(user.getId(), txtName.Text, txtEmail.Text, txtPass.Text, txtAddress.Text, txtPhone.Text);
            userComandService.update();

        }

    }
}
