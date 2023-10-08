using OnlineShop.Models;
using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.Panels
{
    public class PnlCards : Panel
    {

        Form1 form;
        List<Product> products;
        User user;
        int nrCollom;
        public PnlCards(int ct1, Form1 form1, List<Product> products1, User user1)
        {

            form = form1;
            products = products1;
            user = user1;

            this.Name = "PnlCards";
            this.Size = new System.Drawing.Size(1692, 855);
            this.AutoScroll = true;
            nrCollom = ct1;
            
            createCard(nrCollom);
        }

        public void createCard(int nr)
        {
            this.Controls.Clear();

            int x = 53, y = 170, ct = 0;

            foreach (Product p in products)
            {

                ct++;
                PnlCard pnlCard = new PnlCard(form, p, user);
                pnlCard.Location = new System.Drawing.Point(x, y);
                this.Controls.Add(pnlCard);
                x += 400;

                if(ct%nr == 0)
                {
                    x = 55;
                    y += 485;
                }
                if(y>this.Height)
                {
                    this.AutoScroll = true;
                }

            }


        }

    }
}
