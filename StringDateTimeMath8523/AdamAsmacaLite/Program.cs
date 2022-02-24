using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmacaLite
{
    class Program
    {
        /*
        ***** -> çağıl
        ç -> ç****
        z -> ç****
        ğ -> ç*ğ**
        */ 
         
        static void Main(string[] args)
        {
            string[] kelimeler = new string[1]
            {
                "çağıl"
            };
            Random rasgele = new Random();
            int rasgeleIndex = rasgele.Next(0, kelimeler.Length);

            string kelime = kelimeler[rasgeleIndex];

            string sonuc = "";
            for (int i = 0; i < kelime.Length; i++)
            {
                sonuc += "*";
            }
            Console.WriteLine(sonuc);
            char[] sonucHarfler = new char[sonuc.Length];
            for (int i = 0; i < sonucHarfler.Length; i++)
            {
                sonucHarfler[i] = sonuc[i];
            }

            int hak = kelime.Length;
            bool bildimMi = false;

            do
            {
                Console.Write("Harf giriniz: ");
                string harf = Console.ReadLine();

                if (harf == kelime)
                {
                    bildimMi = true;
                    break;
                }

                int index = kelime.IndexOf(harf);
                if (index >= 0)
                {
                    // 1. yol:
                    sonucHarfler[index] = kelime[index];
                }
                else
                {
                    hak--;
                }

                sonuc = "";
                foreach (char sonucHarf in sonucHarfler)
                {
                    sonuc += sonucHarf;
                }
                Console.WriteLine(sonuc);
                if (!sonuc.Contains("*"))
                {
                   bildimMi = true;
                }
            }
            while (hak > 0 && !bildimMi);
            if (!bildimMi)
                Console.WriteLine("Bilemediniz, tekrar deneyiniz.");
            else
                Console.WriteLine("Tebrikler bildiniz.");

            Console.ReadLine();
        }
    }
}
