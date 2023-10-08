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
    public partial class MockupHome : Form
    {
        bool sideBar;

        public MockupHome()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeSlideMenu_Tick(object sender, EventArgs e)
        {

            if (sideBar)
            {

                pnlSideBar.Width -= 10;
                if (pnlSideBar.Width == pnlSideBar.MinimumSize.Width)
                {

                    sideBar = false;
                    timeSlideMenu.Stop();

                }

            }
            else
            {
                pnlSideBar.Width += 10;
                if (pnlSideBar.Width == pnlSideBar.MaximumSize.Width)
                {

                    sideBar = true;
                    timeSlideMenu.Stop();

                }
            }
        }

        private void pctMenu_Click(object sender, EventArgs e)
        {
            timeSlideMenu.Start();
        }
    }
}
