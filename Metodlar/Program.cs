using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "amasya elmasi";

            string[] metveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = " karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakir karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe -- tip guvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("..............  ");
            }

            Console.WriteLine("---------Metodlar-----------");
            //instance - ornek
            //encapusulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yesil", 12, 9);
            sepetManager.Ekle2("elma", "yesil", 12, 16);
            sepetManager.Ekle2("karpuz", "amed", 12, 6);
        }
    }
}


//Dont repeat yourself - DRY Clean Code - Best  Pratice
