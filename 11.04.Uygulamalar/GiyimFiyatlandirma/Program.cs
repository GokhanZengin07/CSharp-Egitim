using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiyimFiyatlandirma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            S: 25TL
            M: 30TL
            L: 35TL
            XL: 40TL
            
            || �F KONTROL�NDE YADA ANLAMINA GEL�R.
            && �F KONTROL�NDE VE ANLAMINA GEL�R.
            */

            string beden;
            Console.WriteLine("L�tfen beden bilgisi giriniz: (�rn: S yada M yada L yada XL)");
            beden = Console.ReadLine();
            beden = beden.ToUpper();

            /*Console.WriteLine("L�tfen kelime yada harf yaz�n�z: ");
            string kelime = Console.ReadLine();
            Console.WriteLine("Yazd���n�z kelimenin k���k harfli hali: {0}",kelime.ToLower());
            Console.ReadLine();*/

            //Burada bana k���k harf gelme ihtimali 0
            if (beden == "S")
                Console.WriteLine("�r�n fiyat�: 25TL");
            else if (beden == "M")
                Console.WriteLine("�r�n fiyat�: 30TL");
            else if (beden == "L")
                Console.WriteLine("�r�n fiyat�: 35TL");
            else if (beden == "XL")
                Console.WriteLine("�r�n fiyat�: 40TL");
            else
                Console.WriteLine("�stenilen kriterlerde bir giri� yapmad�n�z. L�tfen S - M - L - XL giri�lerinden birini yap�n�z.");

            Console.ReadKey();




        }
    }
}
