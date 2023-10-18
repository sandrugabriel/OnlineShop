using OnlineShop.Favourites.Models;
using OnlineShop.Favourites.Service;
using OnlineShop.Users.Models;
using OnlineShop.Users.Service;
using OnlineShop.Users.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OnlineShop.Panels
{
    public class PnlSignUp : Panel
    {

        private System.Windows.Forms.LinkLabel linkDesc;
        private System.Windows.Forms.Button btnSignUp;
        private ZBobb.AlphaBlendTextBox txtPass;
        private ZBobb.AlphaBlendTextBox txtEmail;
        private System.Windows.Forms.PictureBox pctPass;
        private System.Windows.Forms.PictureBox pctEmail;
        private System.Windows.Forms.PictureBox pctBackPass;
        private System.Windows.Forms.PictureBox pctBackEmail;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox pctTile;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.Label lblTile;
        private Bunifu.Framework.UI.BunifuElipse eliBack;
        private Bunifu.Framework.UI.BunifuElipse eliPass;
        private Bunifu.Framework.UI.BunifuElipse eliEmail;
        private Bunifu.Framework.UI.BunifuElipse eliBtn;
        private System.Windows.Forms.PictureBox pctBack;
        private System.Windows.Forms.PictureBox pctBackUser;
        private System.Windows.Forms.PictureBox pctName;
        private ZBobb.AlphaBlendTextBox txtName;
        private System.Windows.Forms.PictureBox pctBackRePass;
        private System.Windows.Forms.PictureBox pctPass1;
        private ZBobb.AlphaBlendTextBox txtRePass;
        private Bunifu.Framework.UI.BunifuElipse eliUser;
        private Bunifu.Framework.UI.BunifuElipse eliRePass;
        private System.Windows.Forms.PictureBox pctError;
        private System.Windows.Forms.Label lblError;
        private Bunifu.Framework.UI.BunifuElipse eliError;

        Form1 form;
        int height;

        List<string> errors;
        string path;

        IUserComandService userComandService;
        IUserQueryService queryService;

        public PnlSignUp(Form1 form)
        {
            this.form = form;
            this.form.Size = new System.Drawing.Size(1797, 981);

            errors = new List<string>();
            path = Application.StartupPath + @"\Images\";

            userComandService = new UserComandService();
            queryService = new UserQueryservice();

            //PnlSignUp
            this.Size = new System.Drawing.Size(1797, 981);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlSignUp";

            this.linkDesc = new System.Windows.Forms.LinkLabel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtPass = new ZBobb.AlphaBlendTextBox();
            this.txtEmail = new ZBobb.AlphaBlendTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.eliBack = new Bunifu.Framework.UI.BunifuElipse();
            this.pctBack = new System.Windows.Forms.PictureBox();
            this.eliPass = new Bunifu.Framework.UI.BunifuElipse();
            this.pctBackPass = new System.Windows.Forms.PictureBox();
            this.eliEmail = new Bunifu.Framework.UI.BunifuElipse();
            this.pctBackEmail = new System.Windows.Forms.PictureBox();
            this.eliBtn = new Bunifu.Framework.UI.BunifuElipse();
            this.txtName = new ZBobb.AlphaBlendTextBox();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.pctPass = new System.Windows.Forms.PictureBox();
            this.pctName = new System.Windows.Forms.PictureBox();
            this.pctEmail = new System.Windows.Forms.PictureBox();
            this.pctBackUser = new System.Windows.Forms.PictureBox();
            this.pctTile = new System.Windows.Forms.PictureBox();
            this.pctBackRePass = new System.Windows.Forms.PictureBox();
            this.pctPass1 = new System.Windows.Forms.PictureBox();
            this.txtRePass = new ZBobb.AlphaBlendTextBox();
            this.eliUser = new Bunifu.Framework.UI.BunifuElipse();
            this.eliRePass = new Bunifu.Framework.UI.BunifuElipse();
            this.pctError = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.eliError = new Bunifu.Framework.UI.BunifuElipse();

            this.Controls.Add(this.pctError);
            this.Controls.Add(this.pctClose);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.linkDesc);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtRePass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pctPass1);
            this.Controls.Add(this.pctPass);
            this.Controls.Add(this.pctName);
            this.Controls.Add(this.pctEmail);
            this.Controls.Add(this.pctBackRePass);
            this.Controls.Add(this.pctBackPass);
            this.Controls.Add(this.pctBackUser);
            this.Controls.Add(this.pctBackEmail);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.pctTile);
            this.Controls.Add(this.pctBack);

            // linkDesc
            this.linkDesc.AutoSize = true;
            this.linkDesc.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.linkDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkDesc.LinkColor = System.Drawing.Color.FromArgb(255,128,0);
            this.linkDesc.Location = new System.Drawing.Point(1636, 849);
            this.linkDesc.Name = "linkDesc";
            this.linkDesc.Size = new System.Drawing.Size(65, 27);
            this.linkDesc.TabIndex = 17;
            this.linkDesc.TabStop = true;
            this.linkDesc.Text = "Here";
            this.linkDesc.Click += new EventHandler(linkDesc_Click);
            
            // btnSignUp
            this.btnSignUp.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignUp.Location = new System.Drawing.Point(1245, 763);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(403, 70);
            this.btnSignUp.TabIndex = 16;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new EventHandler(btnSignUp_Click);
             
            // txtPass
            this.txtPass.BackAlpha = 100;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(213)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 18.2F, System.Drawing.FontStyle.Regular);
            this.txtPass.ForeColor = System.Drawing.Color.Gray;
            this.txtPass.Location = new System.Drawing.Point(1324, 512);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(330, 37);
            this.txtPass.TabIndex = 14;
            this.txtPass.Text = "Type Your Password";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.Enter += new EventHandler(txtpass_Enter);
            this.txtPass.Leave += new EventHandler(txtpass_Leave);

            // txtEmail
            this.txtEmail.BackAlpha = 100;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(213)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 18.2F, System.Drawing.FontStyle.Regular);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(1324, 353);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 37);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.Text = "E-mail Address";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.Enter += new EventHandler(txtemail_Enter);
            this.txtEmail.Leave += new EventHandler(txtemail_Leave);

            // lblDesc
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDesc.Location = new System.Drawing.Point(1341, 849);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(289, 27);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.Text = "Do you have an accont?";
             
            // lblTile
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 37F, System.Drawing.FontStyle.Regular);
            this.lblTile.Location = new System.Drawing.Point(1324, 65);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(254, 77);
            this.lblTile.TabIndex = 18;
            this.lblTile.Text = "Sign Up";
            
            // eliBack
            this.eliBack.ElipseRadius = 901;
            this.eliBack.TargetControl = this.pctBack;
             
            // pctBack
            this.pctBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.pctBack.Location = new System.Drawing.Point(-96, -218);
            this.pctBack.Name = "pctBack";
            this.pctBack.Size = new System.Drawing.Size(1153, 1510);
            this.pctBack.TabIndex = 20;
            this.pctBack.TabStop = false;
             
            // eliPass
            this.eliPass.ElipseRadius = 55;
            this.eliPass.TargetControl = this.pctBackPass;
             
            // pctBackPass
            this.pctBackPass.BackColor = System.Drawing.Color.PapayaWhip;
            this.pctBackPass.Location = new System.Drawing.Point(1183, 469);
            this.pctBackPass.Name = "pctBackPass";
            this.pctBackPass.Size = new System.Drawing.Size(534, 123);
            this.pctBackPass.TabIndex = 10;
            this.pctBackPass.TabStop = false;
             
            // eliEmail
            this.eliEmail.ElipseRadius = 55;
            this.eliEmail.TargetControl = this.pctBackEmail;
             
            // pctBackEmail
            this.pctBackEmail.BackColor = System.Drawing.Color.PapayaWhip;
            this.pctBackEmail.Location = new System.Drawing.Point(1183, 318);
            this.pctBackEmail.Name = "pctBackEmail";
            this.pctBackEmail.Size = new System.Drawing.Size(534, 123);
            this.pctBackEmail.TabIndex = 11;
            this.pctBackEmail.TabStop = false;
             
            // eliBtn
            this.eliBtn.ElipseRadius = 55;
            this.eliBtn.TargetControl = this.btnSignUp;
             
            // txtName
            this.txtName.BackAlpha = 100;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(213)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 18.2F, System.Drawing.FontStyle.Regular);
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(1324, 212);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(330, 37);
            this.txtName.TabIndex = 15;
            this.txtName.Text = "Username";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.Enter += new EventHandler(txtname_Enter);
            this.txtName.Leave += new EventHandler(txtname_Leave);

            // pctClose
            this.pctClose.BackColor = System.Drawing.Color.Transparent;
            this.pctClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctClose.Image = Image.FromFile(path + "close.png");
            this.pctClose.Location = new System.Drawing.Point(1745, 12);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(40, 37);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClose.Click += new EventHandler(pctClose_Click);
             
            // pctPass
            this.pctPass.BackColor = System.Drawing.Color.PapayaWhip;
            this.pctPass.Image = Image.FromFile(path + "pass.png");
            this.pctPass.Location = new System.Drawing.Point(1245, 512);
            this.pctPass.Name = "pctPass";
            this.pctPass.Size = new System.Drawing.Size(40, 37);
            this.pctPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPass.TabIndex = 12;
            this.pctPass.TabStop = false;
            
            // pctName
            this.pctName.BackColor = System.Drawing.Color.PapayaWhip;
            this.pctName.Image = Image.FromFile(path + "user.png");
            this.pctName.Location = new System.Drawing.Point(1245, 208);
            this.pctName.Name = "pctName";
            this.pctName.Size = new System.Drawing.Size(40, 46);
            this.pctName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctName.TabIndex = 13;
            this.pctName.TabStop = false;
            
            // pctEmail
            this.pctEmail.BackColor = System.Drawing.Color.PapayaWhip;
            this.pctEmail.Image = Image.FromFile(path + "email.png");
            this.pctEmail.Location = new System.Drawing.Point(1245, 353);
            this.pctEmail.Name = "pctEmail";
            this.pctEmail.Size = new System.Drawing.Size(40, 37);
            this.pctEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEmail.TabIndex = 13;
            this.pctEmail.TabStop = false;
             
            // pctBackUser
            this.pctBackUser.BackColor = System.Drawing.Color.PapayaWhip;
            this.pctBackUser.Location = new System.Drawing.Point(1183, 168);
            this.pctBackUser.Name = "pctBackUser";
            this.pctBackUser.Size = new System.Drawing.Size(534, 123);
            this.pctBackUser.TabIndex = 11;
            this.pctBackUser.TabStop = false;
             
            // pctTile
            this.pctTile.BackColor = System.Drawing.Color.Transparent;
            this.pctTile.Image = Image.FromFile(path + "logo.png");
            this.pctTile.Location = new System.Drawing.Point(80, 319);
            this.pctTile.Name = "pctTile";
            this.pctTile.Size = new System.Drawing.Size(804, 343);
            this.pctTile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctTile.TabIndex = 7;
            this.pctTile.TabStop = false;
             
            // pctBackRePass
            this.pctBackRePass.BackColor = System.Drawing.Color.PapayaWhip;
            this.pctBackRePass.Location = new System.Drawing.Point(1183, 616);
            this.pctBackRePass.Name = "pctBackRePass";
            this.pctBackRePass.Size = new System.Drawing.Size(534, 123);
            this.pctBackRePass.TabIndex = 10;
            this.pctBackRePass.TabStop = false;
             
            // pctPass1
            this.pctPass1.BackColor = System.Drawing.Color.PapayaWhip;
            this.pctPass1.Image = Image.FromFile(path + "pass.png");
            this.pctPass1.Location = new System.Drawing.Point(1245, 659);
            this.pctPass1.Name = "pctPass1";
            this.pctPass1.Size = new System.Drawing.Size(40, 37);
            this.pctPass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPass1.TabIndex = 12;
            this.pctPass1.TabStop = false;
            
            // txtRePass
            this.txtRePass.BackAlpha = 100;
            this.txtRePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(213)))));
            this.txtRePass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRePass.Font = new System.Drawing.Font("Century Gothic", 18.2F, System.Drawing.FontStyle.Regular);
            this.txtRePass.ForeColor = System.Drawing.Color.Gray;
            this.txtRePass.Location = new System.Drawing.Point(1324, 659);
            this.txtRePass.Multiline = true;
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(330, 37);
            this.txtRePass.TabIndex = 14;
            this.txtRePass.Text = "Re-enter password";
            this.txtRePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRePass.Enter += new EventHandler(txtrepass_Enter);
            this.txtRePass.Leave += new EventHandler(txtrepass_Leave);

            // eliUser
            this.eliUser.ElipseRadius = 55;
            this.eliUser.TargetControl = this.pctBackUser;
            
            // eliRePass
            this.eliRePass.ElipseRadius = 55;
            this.eliRePass.TargetControl = this.pctBackRePass;
             
            // pctError
            this.pctError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.pctError.Controls.Add(this.lblError);
            this.pctError.Location = new System.Drawing.Point(1210, 755);
            this.pctError.Name = "pctError";
            this.pctError.Size = new System.Drawing.Size(471, 52);
            this.pctError.Visible = false;
             
            // lblError
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 15, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.SystemColors.Control;
            this.lblError.Location = new System.Drawing.Point(5, 13);
            this.lblError.Name = "lblError";
            this.lblError.TabIndex = 1;
            this.lblError.Text = "";
            height = (int)CreateGraphics().MeasureString(lblError.Text, lblError.Font, lblError.Width).Height;

            // eliError
            this.eliError.ElipseRadius = 35;
            this.eliError.TargetControl = this.pctError;
           

        }

        private void pctClose_Click(object sender, EventArgs e)
        {
            this.form.Close();
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Type Your Password")
            {
                txtPass.Text = "";
                this.txtPass.PasswordChar = '*';
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Type Your Password";
                this.txtPass.PasswordChar = '\0';
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void txtrepass_Enter(object sender, EventArgs e)
        {
            if (txtRePass.Text == "Re-enter password")
            {
                txtRePass.Text = "";
                this.txtRePass.PasswordChar = '*';
                txtRePass.ForeColor = Color.Black;
            }
        }

        private void txtrepass_Leave(object sender, EventArgs e)
        {
            if (txtRePass.Text == "")
            {
                txtRePass.Text = "Re-enter password";
                this.txtRePass.PasswordChar = '\0';
                txtRePass.ForeColor = Color.Gray;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "E-mail Address")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "E-mail Address";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Username")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Username";
                txtName.ForeColor = Color.Gray;
            }
        }

        private void error()
        {
            errors.Clear();

            if (txtName.Text.Equals("Username"))
            {
                errors.Add("Not entered a Username/Email!");

            }

            if (!txtPass.Text.Equals(txtRePass.Text))
            {
                errors.Add("Passwords do not match!");
            }

        }

        FavouriteComandService serviceFav = new FavouriteComandService();

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            error();

            if(errors.Count > 0)
            {

                this.pctError.Visible = true;
                this.pctError.Size = new System.Drawing.Size(471,50*errors.Count);

                string t = "";
                for (int i = 0; i < errors.Count; i++)
                    t += errors[i].ToString() + "\n";
                this.lblError.Text = t;

                this.btnSignUp.Location = new System.Drawing.Point(btnSignUp.Location.X,pctError.Location.Y + 60 * errors.Count);
                this.lblDesc.Location = new System.Drawing.Point(lblDesc.Location.X,btnSignUp.Location.Y + 74);
                this.linkDesc.Location = new System.Drawing.Point(linkDesc.Location.X, btnSignUp.Location.Y + 74);
            }
            else
            {

                int id = userComandService.generareIdUser();
                string name = txtName.Text;
                string email = txtEmail.Text;
                string pass = txtPass.Text;
                string un = " ";

                string text = id.ToString() + "|" + name + "|" + email + "|" + pass + "|" + un + "|" + un + "|" + 0;

                userComandService.saveFisier(text);
                User user = queryService.getById(id);
                string tfav = serviceFav.generareId()+"|"+id.ToString()+"| " ;
                serviceFav.saveFisier(tfav);

                this.form.removePnl("PnlSignUp");
                this.form.Controls.Add(new PnlHome(this.form, user));

            }

        }

        private void linkDesc_Click(object sender, EventArgs e)
        {
            this.form.removePnl("PnlSignUp");
            this.form.Controls.Add(new PnlLogin(form));

        }

    }
}
