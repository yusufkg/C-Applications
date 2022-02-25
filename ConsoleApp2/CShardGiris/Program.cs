using System;

namespace CShardGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Cano!");

            int sayi1;  //declaration
            sayi1 = 7; //assignment, set etmek.
            sayi1 = 15;
            //Console.WriteLine("Sayı 1: 15"); // saçma.
            //Console.WriteLine("Sayı 1: " + 15); // saçma 2 demişşş.
            Console.WriteLine("Sayı 1: " + sayi1);

            int sayi2 = 25;
            //Int32 sayi2 = 25;
            uint usayi2 = 123;

            Console.WriteLine(int.MaxValue + " - " + int.MinValue);

            Console.WriteLine("Max : {0} - Min {1}" , int.MaxValue, int.MinValue);
            Console.WriteLine($"Max : {int.MaxValue} - Min {int.MinValue}");

            long sayi3 = -123;
            //Int64 sayi3 = -123; 
            Console.WriteLine("Sayı 3: " + sayi3);

            short sayi4 = 32000;
            ushort usayi4 = 65000;
            //Int16 sayi4 = 32000;
            Console.WriteLine("sayi 4: "+ sayi4);

            byte sayi5 = 0;
            sbyte ssayi5 = 10;
            //Byte sayi5 = 0;

            Console.WriteLine("Sıfır: " + sayi5);

            bool durum = true;
            durum = false;
            Console.WriteLine($"Durum: {durum}");
            Console.WriteLine($"Yagiztembelmidir: {durum}");

            char karakter = 'Z';
            Console.WriteLine("Karakter: " + karakter + " ASCII: " + (int)karakter); //casting

            double ondalik1 = -1.25;
            Console.WriteLine("Ondalık 1: " + ondalik1 + " (Max: " + double.MaxValue + ")");
            // float ve decimal da var.

            #region Reference Types
            string adSoyad = "Çağıl Alsaç";
            //string adSoyad = "Çağıl Alsaç";  // string bir karakter dizisidir. Özel bir veri tipidir.
            Console.WriteLine(" Adı soyadı: " + adSoyad);
            #endregion 

            var sayi99 = 99; //assignment işlemi yaparken var kullanabilirsin.

            #region Escape Sequences (Escape Characters)
            string sehir = "\"Ankara\"";
            Console.WriteLine(sehir);

            /*
                \": Çift tırnak
                \n: new line (alt satır)
                \r: carriage return (satır başı) -- \n\r
                \\: slash: C:\Program Files\Rockstar Games\GTA V
                \t: tab
            */

            Console.WriteLine("Çağıl\nAlsaç");

            string dosyaYolu = "C:\\Program Files\\Rockstar Games\\GTA V";
            dosyaYolu = @"D:\Cagil\GTA V";
            Console.WriteLine(dosyaYolu);

            #endregion


            Console.ReadLine();

        }
    }
    enum Gunler
    {
        Pazartesi =1,
        Sali,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
}
