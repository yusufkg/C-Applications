﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ornek = "as good as it gets.";
            string deger = "as";
            int index = ornek.IndexOf(deger); // 0
            Console.WriteLine(index);
            int lastIndex = ornek.LastIndexOf(deger); // 8
            string tersineOrnek = TersineCevir(ornek);
            string tersineDeger = TersineCevir(deger); // sa
            int tersineLastIndex = tersineOrnek.IndexOf(tersineDeger); // 9
            Console.WriteLine(tersineLastIndex);

            Console.ReadLine();
        }

        static string TersineCevir(string value)
        {
            string sonuc = "";
            for (int i = value.Length - 1; i >= 0; i--)
            {
                sonuc += value[i];
            }
            return sonuc;
        }
    }
}
