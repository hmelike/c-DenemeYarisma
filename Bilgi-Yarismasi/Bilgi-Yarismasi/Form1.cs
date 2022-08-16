using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, doğru = 0, yanlış = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;



            label7.Text = BtnB.Text;
            if (label4.Text == label7.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox2.Visible = true;
                BtnB.BackColor = Color.Green;
               
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                BtnB.BackColor = Color.Red;
               

            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;



            label7.Text = BtnC.Text;
            if (label4.Text == label7.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox2.Visible = true;
                BtnC.BackColor = Color.Green;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                BtnC.BackColor = Color.Red;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;



            label7.Text = BtnD.Text;
            if (label4.Text == label7.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox2.Visible = true;
                BtnD.BackColor = Color.Green;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                BtnD.BackColor = Color.Red;
            }
          
            
            
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


           
            label7.Text = BtnA.Text;
            if (label4.Text == label7.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox2.Visible = true;
                BtnA.BackColor = Color.Green;
            }

            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                BtnA.BackColor = Color.Red;
            }
           
            

        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            BtnA.BackColor = Color.LightGray;
            BtnB.BackColor = Color.LightGray;
            BtnC.BackColor = Color.LightGray;
            BtnD.BackColor = Color.LightGray;
            soruno++;
            lblsoruno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edildi?";
                BtnA.Text = "1920";
                BtnB.Text = "1922";
                BtnC.Text = "1923";
                BtnD.Text = "1921";
                label4.Text = BtnC.Text;

            }
           

            
            if (soruno == 2)
            {
                richTextBox1.Text = "Deniz seviyesinden yaklaşık 1650 metre yüksekte yüzüyorsanız hangi göldesiniz demektir?";
                BtnA.Text = "Tuz Gölü";
                BtnB.Text = "Van Gölü";
                BtnC.Text = "İznik Gölü";
                BtnD.Text = "Beyşehir Gölü";
                label4.Text = "Van Gölü";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Everest Tepesine tırmanan ilk Türk dağcı kimdir??";
                BtnA.Text = "Osman Şevki Uludağ";
                BtnB.Text = "Nasuh Mahruki";
                BtnC.Text = "Cevdet Sunay";
                BtnD.Text = "Ali Vehbi Türküstün";
                label4.Text = "Nasuh Mahruki";
                
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Tarihte Türk adıyla kurulan ilk devlet hangisidir?";
                BtnA.Text = "Osmanlı";
                BtnB.Text = "Türkeş";
                BtnC.Text = "Anadolu Selçuklu";
                BtnD.Text = "Göktürk";
                label4.Text = "Göktürk";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "2016-17 Süper Lig, ya da resmî adıyla Spor Toto Süper Lig Turgay Şeren Sezonu şampiyonu hangi takımdır?";
                BtnA.Text = "Bursaspor";
                BtnB.Text = "Başakşehir";
                BtnC.Text = "Beşiktaş";
                BtnD.Text = "Trabzonspor";
                label4.Text = "Beşiktaş";
                

            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Akalar tarafından yıkılan truva kenti hangi ilimizdedir?";
                BtnA.Text = "Tekirdağ";
                BtnB.Text = "Çanakkale";
                BtnC.Text = "Edirne";
                BtnD.Text = "Bursa";
                label4.Text = "Çanakkale";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Nobel ödüllerinde 216 madalya ile en fazla ödül dağıtılan alan ?";
                BtnA.Text = "Tıp";
                BtnB.Text = "Fizik";
                BtnC.Text = "Barış";
                BtnD.Text = "Kimya";
                label4.Text = "Tıp";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Altın Palmiye Ödülleri hangi şehrimizde verilmektedir?";
                BtnA.Text = "İstanbul";
                BtnB.Text = "İzmir";
                BtnC.Text = "Antalya";
                BtnD.Text = "Konya";
                label4.Text = "Antalya";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gece gündüz eşitliği (ekinoks) bir yılda kaç kez gerçekleşir?";
                BtnA.Text = "1";
                BtnB.Text = "3";
                BtnC.Text = "2";
                BtnD.Text = "4";
                label4.Text = "2";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Yüz ölçümü bakımından en büyük ülke hangisidir?";
                BtnA.Text = "Almanya";
                BtnB.Text = "Amerika";
                BtnC.Text = "İngiltere";
                BtnD.Text = "Rusya";
                label4.Text = "Rusya";
                BtnSonraki.Text = "Sonuç:";
            }
            if (soruno == 11)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnC.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru:" + doğru + "/" + "Yanlış:" + yanlış);

            }
        }
    }
}
