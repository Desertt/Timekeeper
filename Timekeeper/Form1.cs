using System;
using System.Windows.Forms;

namespace Timekeeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saat = 0, dakika = 0, saniye = 0;  //saat dakika ve saniye değişkenlerimizi tanımladık.

        private void buttonclear_Click(object sender, EventArgs e) //Button temizle Click Eventi ile 
        {
            timer1.Enabled = false; //Mevctuta timer'ın özlell,iği pasif ediliyor.Değişkenler 0'a çekiliyor.
            saat = 0;
            dakika = 0;
            saniye = 0;
            label_Watch.Text = Convert.ToString("0:0:0");  //Lable'ı  ("0:0:0") formatına çektik.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Watch.Text = ((Convert.ToString(saniye) + ":") + (Convert.ToString(dakika) + ":") + (Convert.ToString(saat) + " "));
            /*Label'a değer yazdırmak için değişkenleri string'e çevirdik*/
            if (saniye == 59) //her 59.saniyeye gelindiğinde /*saniye 0,dakika 1 artacak -- */
            {
                saniye = 0;
                dakika = dakika + 1;
                if (dakika == 60) /*eğer dakika 60 ise  saniye 0,dakika 0 , saat 1 artacak*/
                {
                    saniye = 0;
                    dakika = 0;
                    saat = saat + 1;

                }

            }
            saniye = saniye + 1; //saniye her daim 1 artacak-Burada timer'ın Interval değeri 1000ms=1 sn  olarak seçildi.

        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; //burada timer devre dışı
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; //timer çalışsın
        }
    }
}