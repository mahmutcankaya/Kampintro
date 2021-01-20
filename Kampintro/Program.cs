using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip guvenligi
            // do not repead yoursef - kendini tekrarlama
            //deger tutucu, alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis butonn");
            }
            else
            {
                Console.WriteLine("degismedi butonu");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanici Ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
