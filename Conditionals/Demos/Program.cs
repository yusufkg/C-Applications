using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
        //    byte sayi = 200;
        //    if (sayi >= 0 && sayi <= 100)
        //    {
        //        Console.WriteLine("Sayı 0 ile 100 arasındadır. ");
        //    }
        //    else if (sayi >= 100 && sayi <= 200)
        //    {
        //        Console.WriteLine("Sayı 100 ile 200 arasındadır.");
        //    }
        //    else // sayi > 200 || sayi < 0
        //    {
        //        Console.WriteLine("Sayı 200'den büyüktür. ");
        //    }


        //    if (!(sayi >= 0 && sayi <= 200)) //if (sayi < 0 || sayi > 200)
        //    {
        //        Console.WriteLine("Sayı 200'den büyüktür veya 0'dan küçüktür.");
        //    }
        //    else if (sayi > 100 && sayi <= 200)
        //    {
        //        Console.WriteLine("Sayı 100 ile 200 arasındadır.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Sayı 0 ile 100 arasındadır.");
        //    }

            Console.Write("Sayı gir: ");
            string giris = Console.ReadLine();
            int sayi = Convert.ToInt32(giris);

            if (sayi > 0)
                Console.WriteLine("Pozitif");
            else if (sayi < 0)
                Console.WriteLine("Negatif");
            else
                Console.WriteLine("Nötr");

            Console.Write("Sayı gir: ");
            giris = Console.ReadLine();
            sayi = Convert.ToInt32(giris);

            if (sayi > 0)
                Console.WriteLine("Pozitif");
            else if (sayi < 0)
                Console.WriteLine("Negatif");
            else
                Console.WriteLine("Nötr");

            Console.ReadLine();
        }

    }
}
