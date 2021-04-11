using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            P�N kodu kontrol� isteniyor.
            P�N kodu 4 haneden olu�mak zorunda.
            Do�ru P�N kodu: 1453
            E�er P�N kodu yanl�� ise yanl�� uyar�s� verilsin.
            */

            //Console.WriteLine("L�tfen kelime giriniz: ");
            //string kelime = Console.ReadLine();
            //Console.WriteLine("Giridi�iniz {0} kelimesi {1} karakterden olu�maktad�r.", kelime, kelime.Length);
            //Console.ReadLine();

            int pinKodu = 0; //Varsay�lan: 1453
            Console.WriteLine("L�tfen 4 haneli PIN kodunuzu giriniz: ");
            pinKodu = int.Parse(Console.ReadLine());

            //Gelen veri numerik bir veri mi ve 4 karakterli bir veri mi?
            if (Enumerable.Range(1000,9999).Contains(pinKodu))
            {
                //PIN kodu kontrol� yap�l�yor.
                if (pinKodu == 1453)
                {
                    Console.WriteLine("PIN kodunuz do�ru!");
                }
                else
                {
                    Console.WriteLine("PIN kodunuz yanl��!");
                }
            }
            else
            {
                Console.WriteLine("PIN kodu 4 hane olmak zorundad�r.");
            }

            Console.ReadKey();

        }
    }
}
