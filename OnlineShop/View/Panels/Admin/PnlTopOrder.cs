using OnlineShop.Orders.Service;
using OnlineShop.Orders.Service.interafaces;
using OnlineShop.OrdersDetails.Service;
using OnlineShop.OrdersDetails.Service.interfaces;
using OnlineShop.Products.Service;
using OnlineShop.Products.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OnlineShop.View.Panels.Admin
{
    public class PnlTopOrder : Panel
    {
        Form1 form;


        private Chart chart;
        private ChartArea chartArea;
        private Series series;
        private List<string> listNume;
        private int[] listFrecventa;
        private Legend legend;

        IProductComandService productComandService;
        IProductQueryService queryComandService;

        IOrderComandSerice ordersComandService;
        IOrderQueryService ordersQueryService;

        private System.Windows.Forms.PictureBox pctDesign1;
        private System.Windows.Forms.Label lblProd;

        private PnlSlideBarAdmin pnlSlideBarAdmin;

        public PnlTopOrder(Form1 form1) {

            form = form1;

            productComandService = ProductComandServiceSingleton.Instance;
            queryComandService = ProductQueryServiceSingleton.Instance;

            ordersComandService = OrderComandServiceSingleton.Instance;
            ordersQueryService = OrderQueryServiceSingleton.Instance;

            //PnlTopOrder
            this.Size = new System.Drawing.Size(1797, 981);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PnlTopOrder";

            chart = new Chart();
            chartArea = new ChartArea();
            series = new Series();
            listNume = new List<string>();
            listFrecventa = new int[5];
            pctDesign1 = new System.Windows.Forms.PictureBox();
            lblProd = new Label();
            legend = new Legend();
            pnlSlideBarAdmin = new PnlSlideBarAdmin(form);

            listFrecventa = ordersComandService.frecventaMaxi();

            listNume = productComandService.numeTop(ordersComandService.frecventa());

            if(listFrecventa.Length > 5 )
            {
                listFrecventa = listFrecventa.Take(5).ToArray();
                listNume = listNume.Take(5).ToList();
            }
/*
            for(int i = 0; i < listNume.Count; i++)
            {
                MessageBox.Show(listNume[i] + " apare de " + listFrecventa[i].ToString());
            }*/

            this.Controls.Add(pnlSlideBarAdmin);
            this.Controls.Add(chart);
            this.Controls.Add(lblProd);
            this.Controls.Add(pctDesign1);

            createChart();
            styleOne();

            // pctDesign1
            this.pctDesign1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctDesign1.Location = new System.Drawing.Point(160, 100);
            this.pctDesign1.Name = "pctDesign1";
            this.pctDesign1.Size = new System.Drawing.Size(285, 2);
             
            // lblProd
            this.lblProd.AutoSize = true;
            this.lblProd.BackColor = System.Drawing.Color.Transparent;
            this.lblProd.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProd.Location = new System.Drawing.Point(170, 45);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(244, 51);
            this.lblProd.Text = "Top Orders";



        }

        private void createChart()
        {

            this.chart.Location = new System.Drawing.Point(462, 120);
            this.chart.Size = new System.Drawing.Size(1243, 741);
            this.chart.Legends.Add(legend);
            this.chart.Name = "chart";
            this.chart.Text = "chart";
            this.chart.Series.Add(series);
            this.chart.ChartAreas.Add(chartArea);

            this.chartArea.Name = "ChartArea";
            this.legend.Name = "Legend";
            this.series.ChartType = SeriesChartType.Column;

            for (int i = 0; i < listNume.Count; i++)
            {
                DataPoint datapoint = new DataPoint(0, listFrecventa[i]);
                datapoint.Label = listFrecventa[i].ToString();
                datapoint.LegendText = listNume[i];
                series.Points.Add(datapoint);
            }
        }

        private void styleOne()
        {

            this.series.Points.Clear();

            for (int i = 0; i < listNume.Count; i++)
            {
                DataPoint dataPoint = new DataPoint(0, listFrecventa[i]);
                dataPoint.Label = listNume[i];
                this.series.Points.Add(dataPoint);
            }
            this.series.Name = "Products";

        }

    }
}
