using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolunebilmeUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullan�c�dan bir say� alal�m.
            Bu say� 1'den 9'a kadar hangi say�lara b�l�nebilir?
            Program bize bunun yan�t�n� versin.
            */

            int sayi;
            string egitim = "C# E�itimi";
            Console.Write("L�tfen bir say� giriniz: ");
            sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Girmi� oldu�unuz say�: {0}",sayi);

            if (sayi % 2 == 0)
                Console.WriteLine("{0} say�s� 2'ye b�l�nebilir. E�itim: {1}", sayi, egitim);
            else
                Console.WriteLine("{0} say�s� 2'ye b�l�nemez. E�itim: {1}", sayi, egitim);

            if (sayi % 3 == 0)
                Console.WriteLine("{0} say�s� 3'e b�l�nebilir. E�itim: {1}", sayi, egitim);
            else
                Console.WriteLine("{0} say�s� 3'e b�l�nemez. E�itim: {1}", sayi,egitim);

            Console.ReadLine();



        }
    }
}
