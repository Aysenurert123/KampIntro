using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya alması";

            string[] meyveler = new string[] { "Elma", "Karpuz" };
            //Urun.urun1;
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            // foreach içindeki urun alias(takma isim)
            //type-safe -- tip güvenli
            // var da yazılsa olur Urun yerine
            foreach (Urun urun in urunler)
            {
                //<li>urun adi</li>
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");

            }
            Console.WriteLine("--------------Metotlar--------------");
            //instance -  örnek
            //encapsulation - kapsülleme - düzene sokar

            sepetManager sepetmanager = new sepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetmanager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}
//Dont Repeat Yourself - DRY - Clean Code - Best Practice