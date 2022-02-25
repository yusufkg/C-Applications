using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. sayı: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayı: ");
            double sayi2 = double.Parse(Console.ReadLine());

            Console.Write("İşlem (+, -, *, /)");
            string islem = Console.ReadLine(); // 

            double sonuc =;

            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine(sayi1 + " " + islem + " " + sayi2 + " = " + sonuc);
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    //Console.WriteLine(sayi1 + " " + islem + " " + sayi2 + " = " + sonuc);
                    Console.WriteLine("{0} {1} {2} = {3}" , sayi1, islem, sayi2 , sonuc);
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    //Console.WriteLine(sayi1 + " " + islem + " " + sayi2 + " = " + sonuc);
                    Console.WriteLine($"{sayi1} {islem} {sayi2} = {sonuc}");
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine(sayi1 + " " + islem + " " + sayi2 + " = " + sonuc);
                    break;
                default:
                    Console.WriteLine("Lütfen +, -, * veya / giriniz!");
                    break;
            }
        }
    }
}
