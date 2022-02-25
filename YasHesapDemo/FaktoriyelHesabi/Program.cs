using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faktoriyel:
            //Bir sayının sürekli 1 azaltılarak arka arkaya yapılan çarpım faktoriyeldir.
            //Örneğin 5 faktoriyel 5! şeklinde gösterilir ve 5! = 5 * 4 * 3 * 2 * 1 olarak hesaplanır.
            //Basit bir faktoriyel hesaplama konsol uygulaması yazınız:
            //1) Kullanıcıdan tek seferlik pozitif bir tam sayı alınır.
            //2) Kullanıcının girdiği sayının faktoriyeli hesaplanarak ekrana yazdırılır.

            Console.Write("Pozitif tam sayı: ");
            int sayi = int.Parse(Console.ReadLine());
            int sonuc;
            while (sayi != 0)
            {
                if (sayi > 0)
                {
                    sonuc = FaktoriyelHesapla(sayi);
                    Console.WriteLine($"{sayi} 'nın faktoriyeli: {sonuc}");
                }
                else
                {
                    Console.WriteLine("Pozitif tam sayı girin!");
                }
                Console.Write("Pozitif tam sayı (0: çıkış): ");
                sayi = int.Parse(Console.ReadLine());
            }

        }

        static int FaktoriyelHesapla(int sayi)
        {
            int sonuc = sayi;
            for (int i = sayi-1; i >= 2; i--)
            {
                sonuc = sonuc * i;
            }
            return sonuc;
        }
    }
}
