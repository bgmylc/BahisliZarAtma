using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             *  Bu oyunda iki oyuncu vardır
             *  Her oyuncunun bir zarı vardır
             *  Oyuncular zar atar
             *  Zarlar karşılaştırılır
             *  Büyük atan kazanır
             *  
             *  
             *  Nesneler:
             *  -oyun
             *  -oyuncu
             *  -zar
             */


            /*
             * Oyuncuların bakiyeleri var
             * Başlangıç 100 birim
             * Oyuncuların bahisleri var
             * Bahis girdikleri anda para hesaptan düşer
             * Kazanan hepsini alır, kaybeden bahsi kadar kaybeder
             * İflasa kadar oyun devam
             * İflas eden kaybeden
             */
        }

        Oyun zarOyunu = new Oyun();
        private void buttonAd1_Click(object sender, EventArgs e)
        {
            string oyuncuAdi = textBoxOyuncubir.Text;
            zarOyunu.BirinciOyuncu = new Oyuncu(oyuncuAdi);
            zarOyunu.BirinciOyuncu.OyuncununZari = new Zar(); //Instance almazsan nesne OLUŞMAZ 
            zarOyunu.BirinciOyuncu.Bakiye = 100;
            Oyuncu1Ad.Text = zarOyunu.BirinciOyuncu.Ad;
            labelBakiye1.Text = "Bakiye: " + zarOyunu.BirinciOyuncu.Bakiye.ToString();
            buttonBahis1.Enabled = true;


        }

        private void Oyuncu2Add_Click(object sender, EventArgs e)
        {
            string oyuncuAdi2 = textBoxOyuncuIki.Text;
            zarOyunu.IkinciOyuncu = new Oyuncu(oyuncuAdi2);
            zarOyunu.IkinciOyuncu.OyuncununZari = new Zar();
            zarOyunu.IkinciOyuncu.Bakiye = 100;
            Oyuncu2Ad.Text = zarOyunu.IkinciOyuncu.Ad;
            labelBakiye2.Text = "Bakiye: " + zarOyunu.IkinciOyuncu.Bakiye.ToString();
            buttonBahis2.Enabled = true;
        }
        private void buttonBahis1_Click(object sender, EventArgs e)
        {
            int bahis1 = Convert.ToInt32(textBoxBahis1.Text);
            zarOyunu.BahseGir1(bahis1);
            labelBahis1.Text = bahis1.ToString();
            labelBakiye1.Text = "Bakiye: " + zarOyunu.BirinciOyuncu.Bakiye.ToString();

        }

        private void buttonBahis2_Click(object sender, EventArgs e)
        {
            int bahis2 = Convert.ToInt32(textBoxBahis2.Text);
            zarOyunu.BahseGir2(bahis2);
            labelBahis2.Text = bahis2.ToString();
            labelBakiye2.Text = "Bakiye: " + zarOyunu.IkinciOyuncu.Bakiye.ToString();

        }
        private void buttonOyuncuBir_Click(object sender, EventArgs e)
        {
            zarOyunu.IlkOyuncuZar();
            label1Zar.Text = zarOyunu.BirinciOyuncu.OyuncununZari.Deger.ToString();
            buttonOyuncu2.Enabled = true;

        }

        private void buttonOyuncu2_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncuZar();
            label2Zar.Text = zarOyunu.IkinciOyuncu.OyuncununZari.Deger.ToString();
            Oyuncu kazanan = zarOyunu.Karsilastir();
            if (kazanan !=null)
            {
                KazananAd.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak bu eli kazandı. ";
            }
            else
            {
                KazananAd.Text = "Berabere!";
            }
           
            labelBakiye1.Text = "Bakiye: " + zarOyunu.BirinciOyuncu.Bakiye.ToString();
            labelBakiye2.Text = "Bakiye: " + zarOyunu.IkinciOyuncu.Bakiye.ToString();

            bool kalanBakiye1 = zarOyunu.BakiyeKac1();
            bool kalanBakiye2 = zarOyunu.BakiyeKac2();
            if (!kalanBakiye1)
            {
               
                labelKaybeden.Text = $"{zarOyunu.BirinciOyuncu.Ad}, iflas etti!";
            }

            if (!kalanBakiye2)
            {
                labelKaybeden.Text = $"{zarOyunu.IkinciOyuncu.Ad}, iflas etti!";

            }








        }
        
        
        
        }



       
    }
