using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errays
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Çağıl";
            string student2 = "Leo";
            string student3 = "Angel";

            string[] students = new string[3];
            students[0] = "Çağıl";
            students[1] = "Leo";
            students[2] = "Angel";
            //students[3] = "Muhittin";

            int[] numbers = new int[4]
            {
                1,2,3,4
            };

            //int[] numbers = new[] ÜSTTEKİNİN AYNISI AMA UZUNLUK BELİRTMEDİĞİN İÇİN HATA YAPMA RİSKİ VAR.
            //{
            //    1,2,3,4
            //};
            decimal[] decimals = new decimal[] { 1.1m, 2.2m };
            char[] characters = { 'A', 'b', 'i' };

            Console.WriteLine(students[0]); // Çağıl

            // Console.WriteLine(students);
            foreach (string student in students) //foreach (var item in collection)

            {
                Console.WriteLine(student);
            }
            for (int i = 0; i < students.Length; i = i + 1)
            {
                Console.WriteLine(students[i]);
            }

            #region Multi Dimensional Arrays: Çok Boyutlu Diziler
            string[,] bolgelerVeSehirler = new string[3, 2];

            bolgelerVeSehirler[0, 0] = "Marmara";
            bolgelerVeSehirler[0, 1] = "İstanbul";
            bolgelerVeSehirler[1, 0] = "İç Anadolu";
            bolgelerVeSehirler[1, 1] = "Ankara";
            bolgelerVeSehirler[2, 0] = "Akdeniz";
            bolgelerVeSehirler[2, 1] = "Adana";
            //foreach (var bolgeVeSehir in bolgelerVeSehirler)
            //{
            //    Console.WriteLine(bolgeVeSehir);
            //}

            BolgeSehirYazdir(bolgelerVeSehirler);
            bolgelerVeSehirler = new string[2, 3] // 2: 1.boyut , 3: 2. boyut (Ama index olarak göndermemiz gerektiği için 0,1 olarak yazmamız lazım.)
            {
                { "Marmara" , "İç Anadolu", "Akdeniz" },
                { "İstanbul", "Ankara" , "Adana" }
            };


            #endregion

            Console.ReadLine();

        }

        private static void BolgeSehirYazdir(string[,] bolgelerVeSehirler)
        {
            for (int satir = 0; satir < 3; satir = satir + 1) // Bu satırları kalem veya excel üzerinde yazarak okuyabilmek verimli olur.
            {
                for (int sutun = 0; sutun < 2; sutun = sutun + 1)
                {
                    Console.Write(bolgelerVeSehirler[satir, sutun] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
