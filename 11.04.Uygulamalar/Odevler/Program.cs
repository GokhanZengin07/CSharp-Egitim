using System;

namespace Odev16042021
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            



            Start:
            try
            { 
                
                int sayi1=0;
                int sayi2 = 0;

                while (sayi1 < 1 | sayi1>100)
                {
                    Console.WriteLine("Lutfen sayi 1`i istenilen 1-100 arasinda giriniz");

                    int v = int.Parse(Console.ReadLine());
                    sayi1 = v;

                }

                while (sayi2 < 1 | sayi2 > 100)
                {
                    Console.WriteLine("Lutfen sayi 2`i istenilen 1-100 arasinda giriniz");

                    int x = int.Parse(Console.ReadLine());
                    sayi2 = x;

                }
                
                Console.WriteLine("Sayi1 {0} ve Sayi2 {1}`nin toplami {2}", sayi1, sayi2, sayi1 + sayi2);

            }
                




            catch(System.Exception a)
            {
                Console.WriteLine("Sayi girmediniz lutfen sayi giriniz");
                goto Start;
            }

        }
    }
}
