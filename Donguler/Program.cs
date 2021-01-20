using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazilim gelistirci yetistirme kampi";
            string kurs2 = "programlamaya baslangic icin temel kurs";
            string kurs3 = "java";
            string kurs4 = "python";
            string kurs5 = "c++";


            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);



            ///array - dizi 

            string[] kurslar = new string[] { "yazilim gelistirci yetistirme kampi", "programlamaya baslangic icin temel kurs", "java", "python", "c#" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu  - footer");
        }
    }
}
