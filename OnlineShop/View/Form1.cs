using OnlineShop.Models;
using OnlineShop.Panels;
using OnlineShop.Products.Service;
using OnlineShop.Products.Service.interfaces;
using OnlineShop.Users.Models;
using OnlineShop.View.Panels.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class Form1 : Form {

        public int ct = 0, ct1 = 0;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1797, 981);
            User user = new User("1|Gabi|gabi@mail.com|gabi1234|0777777|Sadu, Livezi|17|admin");
          //  Product p = new Product("1|Laptop Gaming Lenovo IdeaPad 3 15IHU6 cu procesor Intel® Core™ i5-11320H pana la 4.50 GHz, 15.6\", Full HD, IPS, 16GB, 512GB SSD, NVIDIA GeForce GTX 1650 4GB, No OS, Shadow Black|3199.99|35|IdeaPad.png|Specificatii\r\nCARACTERISTICI GENERALE\r\n\r\nLine-up\tIdeaPad\r\nAccesorii incluse\tAdaptor 135W\r\nPROCESOR\r\n\r\nProducator procesor\tIntel®\r\nTip procesor\ti5\r\nModel procesor\t11320H\r\nArhitectura\tTiger Lake\r\nNumar nuclee\t4\r\nFrecventa nominala\t3.2 GHz\r\nFrecventa Turbo Boost\t4.5 GHz\r\nCache\t8192 KB\r\nTehnologie procesor\t10 nm\r\nProcesor grafic integrat\tIntel® Iris™ Xe Graphics\r\nAFISARE\r\n\r\nDiagonala display\t15.6 inch\r\nFormat display\tFull HD\r\nTehnologie display\tIPS\r\nRata de refresh\t60 Hz\r\nLuminozitate\t250 nt\r\nFinisaj display\tAnti-Glare\r\nTouchscreen\tNu\r\nRezolutie\t1920 x 1080\r\nMEMORIE\r\n\r\nCapacitate memorie\t16 GB\r\nTip memorie\tDDR4\r\nNumar sloturi\t2\r\nSloturi ocupate\t2\r\nFrecventa\t3200 MHz\r\nCapacitate memorie maxima suportata\t16 GB\r\nHARD DISK\r\n\r\nTip stocare\tSSD\r\nCapacitate SSD\t512 GB\r\nInterfata SSD\tPCI Express\r\nM.2\r\nPLACA VIDEO\r\n\r\nTip placa video\tDedicata\r\nChipset video\tnVidia GeForce GTX\r\nModel placa video\tGTX 1650\r\nCapacitate memorie video\t4096 MB\r\nTip memorie placa video\tGDDR6\r\nTehnologii placa video\tDirectX 12\r\nGeForce Experience\r\nMULTIMEDIA\r\n\r\nUnitate optica\tNu\r\nCamera WEB\tHD\r\nAudio\tDifuzoare stereo\r\nMicrofoane duale\r\nTehnologii audio\tHD Audio\r\nNahimic Audio\r\nPutere difuzoare\t4 W\r\nCONECTIVITATE & PORTURI\r\n\r\nPorturi\t1 x RJ-45\r\n1 x Audio Out/Microfon\r\n1 x HDMI 2.0\r\n2 x USB 3.2 Type A Gen 1\r\n1 x USB 3.2 Type C Gen 1\r\nRetea\t10/100/1000\r\nWireless\t802.11 ax 2x2\r\nVersiune Bluetooth\t5.0\r\nSOFTWARE\r\n\r\nSistem de operare\tNO OS\r\nCARACTERISTICI GENERALE\r\n\r\nPlatforma producator\tIdeaPad 3\r\nTastatura numerica\tDa\r\nGreutate\t2.25 Kg\r\nDimensiuni (W x H x D)\t359.6 x 251.9 x 24.2 mm\r\nLimba tastatura\tTastatura internationala\r\nSecuritate\tTPM 2.0\r\nCamera privacy shutter\r\nAutonomie baterie\t8 h\r\nCaracteristici cheie\tCamera web\r\nTastatura iluminata\r\nTouchpad care accepta gesturi de atingeri multiple\r\nTastatura Chiclet\r\nBaterie 45Wh\r\nDC dimmer\r\nCuloare\tNegru|it\r\n");
            this.Controls.Add(new PnlEditProducts(this));

        }

        public void removePnl(string pnl)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
