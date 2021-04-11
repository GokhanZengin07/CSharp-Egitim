using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanPrimHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir �irkette pazarlamac� olarak �al��anlara yapt�klar� sat��a g�re prim verilmektedir. Pazarlamac�, ne kadar �ok sat�� yaparsa o kadar prim kazanacakt�r. Sat��lara g�re prim y�zdeleri ��yledir;

            * 2.000 TL�den k���k sat��lar i�in prim yok. - 0
            * 2.000 TL ile 5.000 TL aras� (2.000 d�hil, 5.000 d�hil de�il) sat���n %5�si prim,
            * 5000 TL ile 7.000 TL aras� (5.000 d�hil, 7.000 d�hil de�il) sat���n %10�u prim,
            * 7.000 TL ve �st� %15 prim kazanmaktad�r.

            Buna g�re girilen sat�� miktar�na g�re pazarlamac�n�n ne kadar prim kazanaca��n� hesaplayan program� yaz�n�z.
            */

            double satis;
            double prim = 0;
            string tarih = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
            int primOrani = 0;

            Console.WriteLine("Ayl�k toplam sat�� tutar�n�z� giriniz: (�rn:2000)");
            satis = double.Parse(Console.ReadLine());

            if (satis < 2000) { 
                prim = 0;
                primOrani = 0;
            }
            else if (satis >= 2000 && satis < 5000) {
                primOrani = 5;
                prim = satis * primOrani / 100;
            }
            else if (satis >= 5000 && satis < 7000) {
                primOrani = 10;
                prim = satis * primOrani / 100;
            }
            else if (satis >= 7000) { 
                primOrani = 15;
                prim = satis * primOrani / 100;
            }
            else
                Console.WriteLine("L�tfen bilgilerinizi kontrol ediniz.");

            Console.WriteLine("{0} tarihi itibariyle bu ayki prim hakedi�iniz: {1} TL Prim hakedi� oran�n�z: %{2}", tarih, prim, primOrani);
            Console.ReadKey();

        }
    }
}
