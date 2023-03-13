using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesandVariables
{
    //enum Gunler
    //{
    //    Pazartesi=1,
    //    Salı=2,
    //    Çarşamba=3,
    //    Perşembe=4,
    //    Cuma=5,
    //    Cumartesi=6,
    //    Pazar=7
    //}

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            number1 = 17;//~-2milyar -- ~2milyar
            number2 = 12;
            Console.WriteLine("number1: " + number1 + " number2:" + number2);
            //Console.ReadLine();
            Console.WriteLine("number1: {0}, number2: {1}", number1, number2);
            //Console.ReadLine();
            Console.WriteLine(int.MinValue + " " + int.MaxValue);
            //Console.ReadLine();

            long sayi1 = 123456;//-9kentrilyon -- ~9kentrilyon
            Console.WriteLine("Sayı 1: " + sayi1);
            //Console.ReadLine();
            short s1 = -546;//~-32000--~32000
            Console.WriteLine("sayi1:" + s1);
            //Console.ReadLine();

            bool durum ;
            durum = true;
            durum = false;
            Console.WriteLine("Durum: "+ durum);
            //Console.ReadLine();

            uint uSayi1=450000000;
            Console.WriteLine("Durum: " + uSayi1);
            //Console.ReadLine();

            ulong uSayi2 = 0;
            Console.WriteLine("Durum: " + uSayi2);
            //Console.ReadLine();
            
            ushort uSayi3 = 65000;
            Console.WriteLine("Durum: " + uSayi3);
            //Console.ReadLine();

            sbyte uSayi4 = 127;
            Console.WriteLine("Durum: " + uSayi4);
            //Console.ReadLine();

            char karakter;
            karakter = 'A';
            Console.WriteLine("Karakter "+karakter +" - Sayısal "+(int)karakter);
            //Console.ReadLine();

            bool b = true;
            Console.WriteLine(b);
            //Console.ReadLine();

            double d = 1.56;
            Console.WriteLine(d);
            //Console.ReadLine();

            float f1 = -5.254f;
            Console.WriteLine(f1);
            //Console.ReadLine();

            decimal dec1 = 123.456789m;
            Console.WriteLine(dec1);
            //Console.ReadLine();

            Console.WriteLine("Pazartesi");
            string gun1 = "Pazartesi";
            //Console.WriteLine(gun1);
            //Console.ReadLine();

            Console.WriteLine(Gunler.Pazartesi+" "+(int) Gunler.Pazartesi);
            Console.ReadLine();

            var adSoyad ="Yusuf Kenan GİRGİN";
            Console.WriteLine("Yusuf Kenan GİRGİN");
            string ad1= "Yusuf Kenan GİRGİN";
            Console.WriteLine(ad1);
            Console.ReadLine();

            ad1 = "Abidik";
            Console.ReadLine();

        }
    }

}