using iTextSharp.text;
using iTextSharp.text.pdf;
using OnlineShop.Models;
using OnlineShop.Orders.Service;
using OnlineShop.Orders.Service.interafaces;
using OnlineShop.Products.Service;
using OnlineShop.Products.Service.interfaces;
using OnlineShop.Users.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OnlineShop.View.Panels.Admin;
using System.Diagnostics;

namespace OnlineShop.View.Panels.Customer
{
    public class PnlPdf : Panel
    {
        Form1 form;
        User user;

        List<Order> orders;


        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.PictureBox pct;
        private Bunifu.Framework.UI.BunifuElipse eliPDf;
        private System.Windows.Forms.MonthCalendar dataStart;
        private System.Windows.Forms.MonthCalendar dataEnd;
        private Label lbl1;
        private System.Windows.Forms.Label lbl2;

        IProductComandService productComandService;
        IOrderQueryService orderQueryService;

        PnlAllOrderCards pnlAllOrder;

        public PnlPdf(Form1 form1, User user1)
        {

            form = form1;
            user = user1;

            productComandService = ProductComandServiceSingleton.Instance;
            orderQueryService = OrderQueryServiceSingleton.Instance;

            orders = orderQueryService.getMyOrders(user.getId());
            //MessageBox.Show(orders.Count.ToString());
            //PnlPdf
            this.Size = new System.Drawing.Size(1692, 855);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PnlPdf";
            this.Location = new Point(105, 126);
            this.ForeColor = Color.Black;

            this.btnPdf = new System.Windows.Forms.Button();
            this.lblTile = new System.Windows.Forms.Label();
            this.pct = new System.Windows.Forms.PictureBox();
            this.eliPDf = new Bunifu.Framework.UI.BunifuElipse();
            this.dataStart = new System.Windows.Forms.MonthCalendar();
            this.dataEnd = new System.Windows.Forms.MonthCalendar();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new Label();
            this.pnlAllOrder = new PnlAllOrderCards(form,orders);

            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.dataEnd);
            this.Controls.Add(this.dataStart);
            this.Controls.Add(this.pct);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.btnPdf);

            //lbl1
            this.lbl1.Location = new Point(97, 182);
            this.lbl1.AutoSize = true;
            this.lbl1.Text = "Date Start: ";
            this.lbl1.ForeColor = Color.Black;

            //lbl2
            this.lbl2.Location = new Point(97, 488);
            this.lbl2.AutoSize = true;
            this.lbl2.Text = "Date End: ";
            this.lbl2.ForeColor = Color.Black;

            // btnPdf
            this.btnPdf.BackColor = System.Drawing.Color.Orange;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPdf.Location = new System.Drawing.Point(850, 684);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(308, 85);
            this.btnPdf.TabIndex = 0;
            this.btnPdf.Text = "Save In PDF";
            this.btnPdf.Click += new EventHandler(btnPdf_Clo);

            // lblTile
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.Location = new System.Drawing.Point(85, 29);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(136, 44);
            this.lblTile.TabIndex = 1;
            this.lblTile.Text = "My Orders";
            this.lblTile.ForeColor = Color.Black;

            // pct
            this.pct.BackColor = System.Drawing.Color.Black;
            this.pct.Location = new System.Drawing.Point(73, 71);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(230, 2);


            // eliPDf
            this.eliPDf.ElipseRadius = 35;
            this.eliPDf.TargetControl = this.btnPdf;

            // dataStart
            this.dataStart.Location = new System.Drawing.Point(38, 220);
            this.dataStart.Name = "dataStart";
            DateTime dateTime = new DateTime(2023, 10, 01);
            this.dataStart.TodayDate = dateTime;
            this.dataStart.SelectionStart = dateTime;
            this.dataStart.SelectionEnd = dateTime;
            this.dataStart.DateChanged += new DateRangeEventHandler(dataStart_DateChanged);

            // dataEnd
            this.dataEnd.Location = new System.Drawing.Point(38, 524);
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.TabIndex = 21;
            this.dataEnd.MinDate = dataStart.MinDate;
            this.dataEnd.DateChanged += new DateRangeEventHandler(dataStart_DateChanged);

            this.Controls.Add(pnlAllOrder);
            this.pnlAllOrder.Location = new Point(390, 131);
        }

        private void dataStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime data1 = dataStart.SelectionStart;
            this.dataEnd.MinDate = dataStart.SelectionStart;
            DateTime data2 = dataEnd.SelectionStart;

            orders.Clear();
            orders = orderQueryService.getMyOrders(user.getId());
            orders = orders.Where(order => order.getDate() >= data1 && order.getDate() <= data2).ToList();

            removePnlPdf("PnlAllOrders");
            PnlAllOrderCards pnlAllOrder = new PnlAllOrderCards(form, orders);

            this.Controls.Add(pnlAllOrder);
            this.pnlAllOrder.Location = new Point(390, 131);
        }

        public void removePnlPdf(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);

        }

        private void pctClose_Click(object sender, EventArgs e)
        {
            this.form.Close();
        }

        private void btnPdf_Clo(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fișier PDF (*.pdf)|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document();

                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                document.Open();

                Paragraph title = new Paragraph("My Orders");
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20; 
                document.Add(title);

                PdfPTable tabelComenzi = new PdfPTable(5);

                tabelComenzi.AddCell("ID");
                tabelComenzi.AddCell("Name Product");
                tabelComenzi.AddCell("Quantity");
                tabelComenzi.AddCell("Date Order");
                tabelComenzi.AddCell("Price");

                foreach (var order in orders)
                {
                    tabelComenzi.AddCell(order.getId().ToString());
                    tabelComenzi.AddCell(productComandService.getById(order.getIdProduct()).getName());
                    tabelComenzi.AddCell(order.getquantity().ToString());
                    tabelComenzi.AddCell(order.getDate().ToString("dd/MM/yyyy HH:mm:ss"));
                    tabelComenzi.AddCell((productComandService.getById(order.getIdProduct()).getPrice() * order.getquantity()).ToString("F2"));
                }

                document.Add(tabelComenzi);

                double total = 0;

                foreach (var order in orders)
                {
                   total += productComandService.getById(order.getIdProduct()).getPrice() * order.getquantity();
                }

                Paragraph totalText = new Paragraph("Total: " + total + " Lei         ");
                totalText.Alignment = Element.ALIGN_RIGHT;
                document.Add(totalText);

                document.Close();

                MessageBox.Show("The PDF file has been successfully created at name: " + saveFileDialog.FileName,"Succeced",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }


    }
}
