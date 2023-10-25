using Bunifu.Framework.UI;
using OnlineShop.Users.Models;
using OnlineShop.Users.Service;
using OnlineShop.Users.Service.interfaces;
using OnlineShop.View.Panels.Admin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZBobb;

namespace OnlineShop.Panels
{
    public class PnlLogin : Panel
    {

        Form1 form;

        PictureBox pctBackground;
        PictureBox pctTitle;
        PictureBox pctBackEmail;
        PictureBox pctEmail;
        PictureBox pctBackPass;
        PictureBox pctPass;
        BunifuElipse eliPctBack;
        BunifuElipse eliPctBackEmail;
        BunifuElipse eliPctBackPass;
        Label lblTitle;
        PictureBox pctClose;
        Button btnLogin;
        BunifuElipse eliBtn;

        AlphaBlendTextBox txtEmail;
        AlphaBlendTextBox txtPass;

        Label lblDesc;
        LinkLabel linkDesc;

        PictureBox pctError;
        Label lblError;
        BunifuElipse eliError;

        private IUserQueryService userQueryService;

        PictureBox pctSee;
        PictureBox pctInvi;

        public PnlLogin(Form1 form) {
        
            this.form = form;

            string path = Application.StartupPath + @"\Images\";

            this.form.Size = new Size(1797, 981);

            userQueryService = new UserQueryservice();

            //PnlLogin
            this.Name = "PnlLogin";
            this.Size = new System.Drawing.Size(1797, 981);
            this.Font = new System.Drawing.Font("Century Gothic", 12, System.Drawing.FontStyle.Regular);

            pctBackground = new PictureBox();
            pctTitle = new PictureBox();
            pctBackEmail = new PictureBox();
            pctEmail = new PictureBox();
            pctBackPass = new PictureBox();
            pctPass = new PictureBox();
            eliPctBack = new BunifuElipse();
            eliPctBackEmail = new BunifuElipse();
            eliPctBackPass = new BunifuElipse();
            lblTitle = new Label();
            txtEmail = new AlphaBlendTextBox();
            txtPass = new AlphaBlendTextBox();
            pctClose = new PictureBox();
            btnLogin = new Button();
            eliBtn = new BunifuElipse();
            lblDesc = new Label();
            linkDesc = new LinkLabel();
            pctError = new PictureBox();
            lblError = new Label();
            eliError = new BunifuElipse();
            pctSee = new PictureBox();
            pctInvi = new PictureBox(); 

            this.Controls.Add(txtEmail);
            this.Controls.Add(pctInvi);
            this.Controls.Add(pctSee);
            this.Controls.Add(txtPass);
            this.Controls.Add(pctPass);
            this.Controls.Add(pctTitle);
            this.Controls.Add(pctEmail);
            this.Controls.Add(pctBackground);
            this.Controls.Add(pctBackEmail);
            this.Controls.Add(pctBackPass);
            this.Controls.Add(lblTitle);
            this.Controls.Add(pctClose);
            this.Controls.Add(btnLogin);
            this.Controls.Add(linkDesc);
            this.Controls.Add(lblDesc);
            this.Controls.Add(pctError);
            this.pctError.Controls.Add(lblError);

            //PctBackground
            this.pctBackground.Location = new System.Drawing.Point(-96, -218);
            this.pctBackground.Size = new System.Drawing.Size(1153, 1510);
            this.pctBackground.BackColor = System.Drawing.Color.FromArgb(17, 17, 31);

            //eliPctBack
            eliPctBack.TargetControl = this.pctBackground;
            eliPctBack.ElipseRadius = 1000;

            //Pcttile
            this.pctTitle.Location = new System.Drawing.Point(80, 319);
            this.pctTitle.Size = new System.Drawing.Size(804, 343);
            this.pctTitle.Image = Image.FromFile(path + "logo.png");
            this.pctTitle.SizeMode = PictureBoxSizeMode.Zoom;

            //PctBackEmail
            this.pctBackEmail.Location = new System.Drawing.Point(1192, 319);
            this.pctBackEmail.Size = new System.Drawing.Size(534, 123);
            this.pctBackEmail.BackColor = Color.PapayaWhip;

            //eliPctBack
            eliPctBackEmail.TargetControl = this.pctBackEmail;
            eliPctBackEmail.ElipseRadius = 81;

            //PctBackPass
            this.pctBackPass.Location = new System.Drawing.Point(1192, 512);
            this.pctBackPass.Size = new System.Drawing.Size(534, 123);
            this.pctBackPass.BackColor = Color.PapayaWhip;

            //eliPctBackPass
            this.eliPctBackPass.TargetControl = this.pctBackPass;
            this.eliPctBackPass.ElipseRadius = 81;

            //lblTile
            this.lblTitle.Location = new System.Drawing.Point(1367, 182);
            this.lblTitle.Size = new System.Drawing.Size(195, 77);
            this.lblTitle.Text = "Login";
            this.lblTitle.Font = new Font("Century Gothic", 37);

            //txtEmail
            this.txtEmail.Location = new System.Drawing.Point(1333, 363);
            this.txtEmail.Size = new System.Drawing.Size(330, 37);
            this.txtEmail.Text = "E-mail Address";
            this.txtEmail.ForeColor = Color.Gray;
            this.txtEmail.BackAlpha = 60;
            this.txtEmail.BackColor = Color.FromArgb(255, 239, 213);
            this.txtEmail.Font = new Font("Century Gothic", 16);
            this.txtEmail.TextAlign = HorizontalAlignment.Center;
            this.txtEmail.BorderStyle = BorderStyle.None;
            this.txtEmail.Enter += new EventHandler(txtemail_Enter);
            this.txtEmail.Leave += new EventHandler(txtemail_Leave);

            //txtPass
            this.txtPass.Location = new System.Drawing.Point(1333, 555);
            this.txtPass.Size = new System.Drawing.Size(330, 37);
            this.txtPass.Text = "Type Your Password";
            this.txtPass.ForeColor = Color.Gray;
            this.txtPass.BackAlpha = 60;
            this.txtPass.BackColor = Color.FromArgb(255, 239, 213);
            this.txtPass.Font = new Font("Century Gothic", 16);
            this.txtPass.TextAlign = HorizontalAlignment.Center;
            this.txtPass.BorderStyle = BorderStyle.None;
            this.txtPass.Enter += new EventHandler(txtpass_Enter);
            this.txtPass.Leave += new EventHandler(txtpass_Leave);

            //pctEmail
            this.pctEmail.Location = new System.Drawing.Point(1254, 363);
            this.pctEmail.Size = new System.Drawing.Size(40, 37);
            this.pctEmail.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctEmail.BackColor = Color.PapayaWhip;
            this.pctEmail.Image = Image.FromFile(path + "email.png");

            //pctPass
            this.pctPass.Location = new System.Drawing.Point(1254, 555);
            this.pctPass.Size = new System.Drawing.Size(40, 37);
            this.pctPass.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctPass.BackColor = Color.PapayaWhip;
            this.pctPass.Image = Image.FromFile(path + "pass.png");

            //pctSee
            this.pctSee.Location = new System.Drawing.Point(1650, 555);
            this.pctSee.Size = new System.Drawing.Size(40, 37);
            this.pctSee.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctSee.BackColor = Color.PapayaWhip;
            this.pctSee.Image = Image.FromFile(path + "see.png");
            this.pctSee.Click += new EventHandler(pctSee_Click);

            //pctInvi
            this.pctInvi.Location = new System.Drawing.Point(1650, 555);
            this.pctInvi.Size = new System.Drawing.Size(40, 37);
            this.pctInvi.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctInvi.BackColor = Color.PapayaWhip;
            this.pctInvi.Image = Image.FromFile(path + "invisible.png");
            this.pctInvi.Click += new EventHandler(pctInvi_Click);
            this.pctInvi.Visible = false;

            //pctClose
            this.pctClose.Location = new System.Drawing.Point(1745, 12);
            this.pctClose.Size = new System.Drawing.Size(40, 37);
            this.pctClose.SizeMode = PictureBoxSizeMode.Zoom;
            this.pctClose.BackColor = Color.Transparent;
            this.pctClose.Cursor = Cursors.Hand;
            this.pctClose.Image = Image.FromFile(path + "close.png");
            this.pctClose.Click += new EventHandler(pctClose_Click);

            //btnLogin
            this.btnLogin.Location = new System.Drawing.Point(1274, 724);
            this.btnLogin.Size = new Size(403, 70);
            this.btnLogin.Text = "Login";
            this.btnLogin.Font = new Font("Century Gothic", 23, FontStyle.Bold);
            this.btnLogin.BackColor = Color.SandyBrown;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.Cursor = Cursors.Hand;
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.Click += new EventHandler(btnLogin_Click);

            //lblDesc
            this.lblDesc.Text = "New User? ";
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new Point(1445, 812);
            this.lblDesc.ForeColor = SystemColors.ControlDarkDark;
            this.lblDesc.Font = new Font("Century Gothic", 14,FontStyle.Bold);

            //linkDEsc
            this.linkDesc.Text = "Registred Here";
            this.linkDesc.AutoSize = true;
            this.linkDesc.Location = new Point(1570, 812);
            this.linkDesc.LinkBehavior = LinkBehavior.HoverUnderline;
            this.linkDesc.ForeColor = Color.Gray;
            this.linkDesc.LinkColor = Color.FromArgb(255, 128, 0);
            this.linkDesc.Font = new Font("Century Gothic", 14,FontStyle.Bold);
            this.linkDesc.Click += new EventHandler(link_Click);

            //eliBtn
            eliBtn.TargetControl = this.btnLogin;
            eliBtn.ElipseRadius = 56;

            //Pcterror
            this.pctError.Location = new System.Drawing.Point(1229, 660);
            this.pctError.Size = new System.Drawing.Size(471, 52);
            this.pctError.BackColor = System.Drawing.Color.FromArgb(248,113,113);
            this.pctError.Visible = false;

            //eliError
            eliError.TargetControl = this.pctError;
            eliError.ElipseRadius = 35;

            //lblError
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(39, 6);
            this.lblError.Text = "Invalid Email or password.";
            this.lblError.ForeColor = Color.White;
            this.lblError.BackColor = Color.Transparent;
            this.lblError.Font = new Font("Century Gothic", 18, FontStyle.Bold);

        }

        private void pctClose_Click(object sender, EventArgs e)
        {
            this.form.Close();
        }

        private void link_Click(object sender, EventArgs e)
        {
            this.form.removePnl("PnlLogin");
            this.form.Controls.Add(new PnlSignUp(form));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(userQueryService.getByEmailPass(txtEmail.Text,txtPass.Text) == null)
            {
                // MessageBox.Show("Invalid Email or password!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.pctError.Visible = true;
                this.btnLogin.Location = new System.Drawing.Point(1274, 739);
                this.lblDesc.Location = new Point(1443, 827);
                this.linkDesc.Location = new System.Drawing.Point(1570, 827);
            }
            else
            {
                User user = userQueryService.getByEmailPass(txtEmail.Text, txtPass.Text);
                this.form.removePnl("PnlLogin");

                if(user.getUserRole().Equals("admin"))
                this.form.Controls.Add(new PnlEditProducts(form));
                else
                    this.form.Controls.Add(new PnlHome(form, user));
            }

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

        private void pctSee_Click(object sender, EventArgs e)
        {
            this.txtPass.PasswordChar = '*';
            this.pctSee.Visible = false;
            this.pctInvi.Visible = true;
            this.txtPass.Refresh();
        }

        private void pctInvi_Click(object sender, EventArgs e)
        {

            this.txtPass.PasswordChar = '\0';
            this.pctSee.Visible = true;
            this.pctInvi.Visible = false;
            this.txtPass.Refresh();

        }

    }
}
