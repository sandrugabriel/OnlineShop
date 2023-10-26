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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private Bunifu.Framework.UI.BunifuElipse eliPDf;
        private Bunifu.Framework.UI.BunifuElipse eliPNG;
        private System.Windows.Forms.MonthCalendar dataStart;
        private System.Windows.Forms.MonthCalendar dataEnd;
        private Label lbl1;
        private System.Windows.Forms.Label lbl2;

        IProductComandService productComandService;
        IOrderQueryService orderQueryService;


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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPNG = new System.Windows.Forms.Button();
            this.eliPDf = new Bunifu.Framework.UI.BunifuElipse();
            this.eliPNG = new Bunifu.Framework.UI.BunifuElipse();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataStart = new System.Windows.Forms.MonthCalendar();
            this.dataEnd = new System.Windows.Forms.MonthCalendar();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new Label();

            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.dataEnd);
            this.Controls.Add(this.dataStart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pct);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.btnPNG);
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
            this.btnPdf.Location = new System.Drawing.Point(1177, 684);
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

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
   this.colId,
   this.colName,
   this.colQuan,
   this.colDate,
   this.colPrice});
            this.dataGridView1.Location = new System.Drawing.Point(419, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1203, 460);
            this.dataGridView1.TabIndex = 19;

            // btnPNG
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
            this.btnPNG.Click += new EventHandler(btnPNG_Click);

            // eliPDf
            this.eliPDf.ElipseRadius = 35;
            this.eliPDf.TargetControl = this.btnPdf;

            // eliPNG
            this.eliPNG.ElipseRadius = 35;
            this.eliPNG.TargetControl = this.btnPNG;

            // colId
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 200;

            // colName
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 300;

            // colDate
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 250;

            // colQuan
            this.colQuan.HeaderText = "Quantity";
            this.colQuan.MinimumWidth = 6;
            this.colQuan.Name = "colQuan";
            this.colQuan.ReadOnly = true;
            this.colQuan.Width = 200;

            // colPrice
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 200;

            // dataStart
            this.dataStart.Location = new System.Drawing.Point(38, 220);
            this.dataStart.Name = "dataStart";
            this.dataStart.TabIndex = 20;
            this.dataStart.DateChanged += new DateRangeEventHandler(dataStart_DateChanged);

            // dataEnd
            this.dataEnd.Location = new System.Drawing.Point(38, 524);
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.TabIndex = 21;
            this.dataEnd.MinDate = dataStart.MinDate;
            this.dataEnd.DateChanged += new DateRangeEventHandler(dataStart_DateChanged);
        
            foreach(Order order in orders)
            { 
                dataGridView1.Rows.Add(order.getId().ToString(), productComandService.getById(order.getIdProduct()).getName(),
                 order.getquantity().ToString(), order.getDate().ToString("dd/MM/yyyy HH:mm:ss"), (productComandService.getById(order.getIdProduct()).getPrice() * order.getquantity()).ToString("F2"));
            }


        }

        private void dataStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime data1 = dataStart.SelectionStart;
            this.dataEnd.MinDate = dataStart.SelectionStart;
            DateTime data2 = dataEnd.SelectionStart;

            orders.Clear();
            orders = orderQueryService.getMyOrders(user.getId());
            orders = orders.Where(order => order.getDate() >= data1 && order.getDate() <= data2).ToList();

            dataGridView1.Rows.Clear();
            foreach (Order order in orders)
            {
                dataGridView1.Rows.Add(order.getId().ToString(), productComandService.getById(order.getIdProduct()).getName(),
                 order.getquantity().ToString(), order.getDate().ToString("dd/MM/yyyy HH:mm:ss"), (productComandService.getById(order.getIdProduct()).getPrice() * order.getquantity()).ToString("F2"));
            }

        }

        private void btnPNG_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Imagini PNG|*.png";
            saveFileDialog.Title = "Salvează Imaginea";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);

                MessageBox.Show("Imaginea a fost salvată cu succes la " + saveFileDialog.FileName, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
