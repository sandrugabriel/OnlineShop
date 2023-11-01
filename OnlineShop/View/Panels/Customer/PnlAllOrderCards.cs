using OnlineShop.Models;
using OnlineShop.Orders.Service;
using OnlineShop.Orders.Service.interafaces;
using OnlineShop.Products.Service;
using OnlineShop.Products.Service.interfaces;
using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop.View.Panels.Customer
{
    public class PnlAllOrderCards : Panel
    {

        Form1 form;
        List<Order> orders;

        IOrderQueryService orderQueryService;
        IProductComandService productComandService;

        public PnlAllOrderCards(Form1 form1, List<Order> orders1)
        {
            this.form = form1;
            this.orders = orders1;
            this.Name = "PnlAllOrders";
            this.Size = new System.Drawing.Size(1245, 532);
            //  this.BackColor = System.Drawing.Color.Gray;
            this.Location = new System.Drawing.Point(390, 131);
            orderQueryService = OrderQueryServiceSingleton.Instance;
            productComandService = ProductComandServiceSingleton.Instance;

            createCard();

        }

        public void createCard()
        {
            this.Controls.Clear();

            int x = 15, y = 14, ct = 0;

            foreach (Order order in orders)
            {

                ct++;
                PnlCardPdf pnlCard = new PnlCardPdf(form, productComandService.getById(order.getIdProduct()), order);
                pnlCard.Location = new System.Drawing.Point(x, y);

                this.Controls.Add(pnlCard);
                x += 300;

                if (ct % 1 == 0)
                {
                    x = 15;
                    y += 250;
                }
                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }
            }
        }


    }
}
