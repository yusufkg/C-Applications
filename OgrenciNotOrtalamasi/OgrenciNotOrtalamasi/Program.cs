using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotOrtalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad;
            string soyad;
            double vize1;
            double  vize2;
            double  final;
            double ortalama;
            const double vizeCarpan = 0.2; // Değerin değişmemesini istiyorsan başıan const yazıyorsun.
            const double finalCarpan = 0.6;
            

            Console.Write("Adınız: ");
            ad = Console.ReadLine();

            Console.Write("Soyadınız: ");
            soyad = Console.ReadLine();

            Console.Write("1. Vize: ");
            vize1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" 2. Vize: ");
            vize2 = Double.Parse(Console.ReadLine());

            Console.Write("Final: ");
            final = Convert.ToDouble(Console.ReadLine());

            ortalama = (vize1 + vize2) * vizeCarpan + final * finalCarpan;

            Console.WriteLine("Sayın " + ad + " " + soyad + ", ortalamanız: " + ortalama);

            if (ortalama >= 60)
                Console.WriteLine("Tebrikler " + ad + " " + soyad + " dersi başarıyla tamamladınız.");
            else
                Console.WriteLine("Wasted");


            Console.ReadLine();

            
        }

    }
}
