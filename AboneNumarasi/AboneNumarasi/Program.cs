using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboneNumarasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //A123456-7 -> A: Abone Tipi (A: Bireysel, B: Kurumsal), 123456: Bina Numarası, 7: Daire Numarası
            string aboneNo = "A123456-7";

            //1. Yöntem:
            if (aboneNo.StartsWith("A"))
                    Console.WriteLine("Bireysel Abone");
            else
                Console.WriteLine("Kurumsal Abone");
            //2. Yöntem:
            if (aboneNo.Substring(0,1) == "A")
                Console.WriteLine("Bireysel Abone");
            else
                Console.WriteLine("Kurumsal Abone");
            //3. Yöntem:
            if (aboneNo[0] == 'A')
                Console.WriteLine("Bireysel Abone");
            else
                Console.WriteLine("Kurumsal Abone");
            Console.WriteLine();

            string aboneTipi = aboneNo.Substring(0, 1);
            string binaNo = aboneNo.Substring(1, 6);
            string daireNo = aboneNo.Substring(8);

            Console.WriteLine("Abone No:" + aboneNo +
                "\nAbone Tipi: " + aboneTipi +
                "\nBina No: " + binaNo +
                "\nDaire No: " + daireNo);

            Console.ReadLine();
        }
    }
}
