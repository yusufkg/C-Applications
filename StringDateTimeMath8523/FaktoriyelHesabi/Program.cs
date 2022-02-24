using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelHesabi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pozitif tam sayı (0: çıkış): ");
            int sayi = int.Parse(Console.ReadLine());
            int sonuc;
            while (sayi != 0)
            {
                if (sayi > 0)
                {
                    sonuc = FaktoriyelHesapla(sayi);
                    Console.WriteLine($"{sayi}'nın faktoriyeli: {sonuc}");
                }
                else
                {
                    Console.WriteLine("Pozitif tam sayı girin!");
                }
                Console.Write("Pozitif tam sayı (0: çıkış): ");
                sayi = int.Parse(Console.ReadLine());
            }

            char[] harfler = new char[5]
            {
                'Ç', 'a', 'ğ', 'ı', 'l'
            };
            string isim = "";
            foreach (char harf in harfler)
            {
                //isim = isim + harf;
                isim += harf;
            }
            Console.WriteLine(isim);
            Console.ReadLine();
        }

        static int FaktoriyelHesapla(int sayi) // 5*4*3*2 - 2*3*4*5
        {
            int sonuc = sayi;

            for (int i = sayi - 1; i >= 2; i--)
            {
                //sonuc = sonuc * i;
                sonuc *= i;
            }
            return sonuc;
        }
    }
}
