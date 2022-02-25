using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.ReadLine();

            int number1; 
            number1 = 99;
            number1 = 999;

            //Console.WriteLine(99);
            Console.WriteLine(number1);

            Console.WriteLine("Number 1: " + number1); // Number 1: 999
            Console.WriteLine("Number 1: {0}", number1);

            int number2 = 888;

            Console.WriteLine("Sayı 1 = " +number1 + ", sayı 2 = " + number2);
            // Sayı 1 = 999 , Sayı 2 = 888
            Console.WriteLine("Sayı 1 = {0}, sayı 2 = {1}" , number1, number2);

            Console.WriteLine(int.MinValue + " ... " + int.MaxValue);

            //Console.ReadLine();

            long sayi1 = 500; // ~-9 kentilyon - ~9 kentilyon
            Console.WriteLine("Sayı 1: " + sayi1);

            short s1 = -546; //~-32000 ~32000
            Console.WriteLine("s1: " + s1);

            byte b1 = 192; // 0 - 2555
            Console.WriteLine(b1);

            bool // boolean: true (1), false (0)
            durum = true;
            durum = false; //durum
            Console.WriteLine(durum);
            //Console.ReadLine();

            uint uSayi1 = 123;
            ulong uSayi2 = 0;
            ushort uSayi3 = 65000;
            sbyte sSayi4 = 127;  //bu veri tipleri genelde kullanılmıyor.

            char Karakter;
            Karakter = 'A';

            Console.WriteLine("A karakter: " + Karakter + " - Sayısal: " + (int) Karakter);
            //Console.ReadLine();

            Console.WriteLine("Pazartesi");
            string gun1 = "Pazartesi";
            Console.WriteLine(gun1);

            Console.WriteLine(Gunler.Pazartesi + " - " + (int)Gunler.Pazartesi);

            var adSoyad = "Çağıl Alsaç";
            string ad1;
            ad1 = "Abidik";

            var ad2 = "Gubidik";

            Console.ReadLine();


        }
    }

}
