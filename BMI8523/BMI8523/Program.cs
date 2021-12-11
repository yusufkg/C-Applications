using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI8523
{
    class Program
    {
        static void Main(string[] args)
        {
            BaslikYaz();
            double boy= Giris("Boy(m): ");
            double kilo= Giris ("Kilo(cm):");
            double bmi = EndeksHesapla(boy, kilo);
            Console.WriteLine($"Endeks:{bmi}");
            HesapSonucunuYazdir(bmi);
            Console.ReadLine();
        }

        static void HesapSonucunuYazdir(double bmi)
        {
            Console.WriteLine("BMİ:");
            if (bmi<18)
            {
                Console.Write("Zayıf");
            }
            else if (bmi>=18&&bmi<25)
            {
                Console.Write("Normal");
            }
            else if (bmi>=25&&bmi<30)
            {
                Console.Write("Kilolu");
            }
            else
            {
                Console.Write("Obez");
            }
        }

        static double EndeksHesapla(double boy, double kilo)
        {
            return kilo / (boy * boy);
        }

        static void BaslikYaz()
        {
            Console.WriteLine("***BMI Calculator***");
        }
        static double Giris(string yazi)
        {
            Console.Write(yazi);
            double giris = Convert.ToDouble(Console.ReadLine());
            return giris;
        }
    }
}
