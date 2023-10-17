using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Mockups
{
    public partial class MockupPayment : Form
    {
        bool sidebar = false;
        bool sidebar2 = false;
        bool sidebar3 = false;

        public MockupPayment()
        {
            InitializeComponent();

           // this.BilingAddress.Size = this.BilingAddress.MaximumSize;
          //  this.Delivery.Size = this.BilingAddress.MaximumSize;
            //this.Payment.Size = this.BilingAddress.MaximumSize;

            int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height +20;
            this.Delivery.Location = new Point(this.Delivery.Location.X,y); 
            int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
            this.Payment.Location = new Point(this.Payment.Location.X,y2);
            int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 50;
            this.label1.Location = new Point(this.label1.Location.X,y3);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void pctShow_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pctShow.Visible = false;
            pctHide.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pctShow.Enabled = false;
            pctHide.Enabled = false;
            if (sidebar)
            {

                BilingAddress.Height -= 10;

                int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height + 20;
                this.Delivery.Location = new Point(this.Delivery.Location.X, y);
                int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
                this.Payment.Location = new Point(this.Payment.Location.X, y2);
                int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 50;
                this.label1.Location = new Point(this.label1.Location.X, y3);

                if (BilingAddress.Height == BilingAddress.MinimumSize.Height)
                {
                    sidebar = false;
                    timer1.Stop();

                    pctShow.Enabled = true;
                    pctHide.Enabled = true;
                }

            }
            else
            {
                BilingAddress.Height += 10;

                int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height + 20;
                this.Delivery.Location = new Point(this.Delivery.Location.X, y);
                int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
                this.Payment.Location = new Point(this.Payment.Location.X, y2);
                int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 50;
                this.label1.Location = new Point(this.label1.Location.X, y3);

                if (BilingAddress.Height == BilingAddress.MaximumSize.Height)
                {
                    sidebar = true;
                    timer1.Stop();

                    pctShow.Enabled = true;
                    pctHide.Enabled = true;
                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pctShowDelivery.Enabled = false;
            pctHideDelivery.Enabled = false;

            if (sidebar2)
            {

                Delivery.Height -= 10;

                int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height + 20;
                this.Delivery.Location = new Point(this.Delivery.Location.X, y);
                int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
                this.Payment.Location = new Point(this.Payment.Location.X, y2);
                int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 50;
                this.label1.Location = new Point(this.label1.Location.X, y3);

                if (Delivery.Height == Delivery.MinimumSize.Height)
                {
                    sidebar2 = false;
                    timer2.Stop();
                    pctShowDelivery.Enabled = true;
                    pctHideDelivery.Enabled = true;

                }

            }
            else
            {
                Delivery.Height += 10;

                int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height + 20;
                this.Delivery.Location = new Point(this.Delivery.Location.X, y);
                int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
                this.Payment.Location = new Point(this.Payment.Location.X, y2);
                int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 50;
                this.label1.Location = new Point(this.label1.Location.X, y3);

                if (Delivery.Height == Delivery.MaximumSize.Height)
                {
                    sidebar2 = true;
                    timer2.Stop();
                    pctShowDelivery.Enabled = true;
                    pctHideDelivery.Enabled = true;

                }
            }
        }

        private void pctShowDelivery_Click(object sender, EventArgs e)
        {

            timer2.Start();
            pctShowDelivery.Visible = false;
            pctHideDelivery.Visible = true;
        }

        private void pctHide_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pctShow.Visible = true;
            pctHide.Visible = false;
        }

        private void pctHideDelivery_Click(object sender, EventArgs e)
        {

            timer2.Start();
            pctShowDelivery.Visible = true;
            pctHideDelivery.Visible = false;
        }

        private void pctShowPay_Click(object sender, EventArgs e)
        {
            timer3.Start();
            pctHidePay.Visible = true;
            pctShowPay.Visible = false;

        }

        private void pctHidePay_Click(object sender, EventArgs e)
        {
            timer3.Start();
            pctHidePay.Visible = false;
            pctShowPay.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pctShowPay.Enabled = false;
            pctHidePay.Enabled = false;

            if (sidebar3)
            {

                Payment.Height -= 10;

                int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height + 20;
                this.Delivery.Location = new Point(this.Delivery.Location.X, y);
                int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
                this.Payment.Location = new Point(this.Payment.Location.X, y2);
                int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 50;
                this.label1.Location = new Point(this.label1.Location.X, y3);

                if (Payment.Height == Payment.MinimumSize.Height)
                {
                    sidebar3 = false;
                    timer3.Stop();
                    pctShowPay.Enabled = true;
                    pctHidePay.Enabled = true;

                }

            }
            else
            {
                Payment.Height += 10;

                int y = this.BilingAddress.Location.Y + this.BilingAddress.Size.Height + 20;
                this.Delivery.Location = new Point(this.Delivery.Location.X, y);
                int y2 = this.Delivery.Location.Y + this.Delivery.Size.Height + 20;
                this.Payment.Location = new Point(this.Payment.Location.X, y2);
                int y3 = this.Payment.Location.Y + this.Payment.Size.Height + 50;
                this.label1.Location = new Point(this.label1.Location.X, y3);

                if (Payment.Height == Payment.MaximumSize.Height)
                {
                    sidebar3 = true;
                    timer3.Stop();
                    pctShowPay.Enabled = true;
                    pctHidePay.Enabled = true;

                }
            }
        }
    }
}
