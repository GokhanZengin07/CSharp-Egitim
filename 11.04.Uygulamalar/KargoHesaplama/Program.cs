using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir kargo fiyat� hesaplama mod�l� isteniyor.
            Algoritma detaylar�:
            0.1gr  ile 1000gr aras� 20TL (1000gr dahil olmas�n)
            1000gr ile 2000gr aras� 30TL
            2000gr ile 3000gr aras� 40TL
            3000gr �zeri de 100TL AMA 20kg'a kadar.        
            20.000gr �zeri de ta��namaz.
            */

            double agirlik;
            Console.Write("L�tfen kargonunun a��rl���n� giriniz: (GR)");
            agirlik = double.Parse(Console.ReadLine());

            if (agirlik.ToString() == "") 
                Console.WriteLine("Kargo a��rl��� bo� olamaz!");

            if (agirlik == 0)
                Console.WriteLine("Kargo a�r�l��� s�f�r (0) olamaz!");

            if (agirlik < 0.1)
                Console.WriteLine("Kargo a��rl��� minimum 0.1gr olmak zorundad�r!");
       
            if (agirlik >= 0.1 && agirlik < 1000)
                Console.WriteLine("Hesaplanan kargo tutar�: 20TL");

            if (agirlik >= 1000 && agirlik < 2000)
                Console.WriteLine("Hesaplanan kargo tutar�: 30TL");

            if (agirlik >= 2000 && agirlik < 3000)
                Console.WriteLine("Hesaplanan kargo tutar�: 40TL");

            if (agirlik >= 3000 && agirlik<20000)
                Console.WriteLine("Hesaplanan kargo tutar�: 100TL");

            if (agirlik > 20000)
                Console.WriteLine("Sisteme 20kg'dan fazla a��rl��a sahip kargo kabul edilememektedir.");


            Console.ReadKey();

        }
    }
}
