using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    public class Oyun
    {

        public Oyuncu BirinciOyuncu { get; set; }

        public Oyuncu IkinciOyuncu { get; set; }

        public void IlkOyuncuZar()
        {
            BirinciOyuncu.Oyna();
        }

        public void IkinciOyuncuZar()
        {
            IkinciOyuncu.Oyna();
        }

      
        public void BahseGir1(int bahis1) 
        {
           BirinciOyuncu.Bahis = bahis1;
           BirinciOyuncu.Bakiye -= bahis1;
            
            if (BirinciOyuncu.Bakiye < 0)
            {
                Console.WriteLine("Yeterli bakiyeniz kalmamıştır.");
            }        }

        public void BahseGir2(int bahis2)
        {
            IkinciOyuncu.Bahis = bahis2;
            IkinciOyuncu.Bakiye -= bahis2;
            if (IkinciOyuncu.Bakiye < 0)
            {
                Console.WriteLine("Yeterli bakiyeniz kalmamıştır.");
            }
           
        }


        public Oyuncu Karsilastir() 
        {
            if (BirinciOyuncu.OyuncununZari.Deger > IkinciOyuncu.OyuncununZari.Deger)
            {
                BirinciOyuncu.Bakiye += BirinciOyuncu.Bahis + IkinciOyuncu.Bahis;
                return BirinciOyuncu;
            }
            else if (BirinciOyuncu.OyuncununZari.Deger < IkinciOyuncu.OyuncununZari.Deger)
            {
                IkinciOyuncu.Bakiye += BirinciOyuncu.Bahis + IkinciOyuncu.Bahis;
                return IkinciOyuncu;
            }
            else
            {
                BirinciOyuncu.Bakiye += BirinciOyuncu.Bahis;
                IkinciOyuncu.Bakiye += IkinciOyuncu.Bahis;
                return null;
            }
        }

        public bool BakiyeKac1() 
        {
            if (BirinciOyuncu.Bakiye == 0)
            {
                return false;
            }
            else 
            {
                return true;
            }

        }

        public bool BakiyeKac2()
        {
            if (IkinciOyuncu.Bakiye == 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
    }
}
