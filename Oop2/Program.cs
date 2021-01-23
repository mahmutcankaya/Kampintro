using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //mahmut
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "mahmut";
            musteri1.SoyAdi = "kaya";
            musteri1.TcNo = "156565656";

            //kodlama.io 
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "78787";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "y187367826";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


        }
    }
}
