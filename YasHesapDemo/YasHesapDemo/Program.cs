using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasHesapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Doğum tarihi (gg.aa.yyyy): ");
            DateTime dogumTarihi = DateTime.Parse(Console.ReadLine(), new CultureInfo("tr"));
            DateTime simdikiTarih = DateTime.Today;
            TimeSpan fark = simdikiTarih.Subtract(dogumTarihi);
            int yas = (int)fark.TotalDays / (365 * 24 + 6);
            Console.WriteLine($" {yas} yaşındasınız.");
            Console.ReadLine();
        }
    }
}
