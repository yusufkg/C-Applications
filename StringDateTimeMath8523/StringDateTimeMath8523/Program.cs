using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDateTimeMath8523
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] isimKarakterler = new char[3]
            {
                'C', 'A', 'N'
            };
            foreach (char c in isimKarakterler)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            string isimString = "CAN";
            Console.WriteLine(isimString);

            string city1 = "Ankara";
            Console.WriteLine(city1[0]); // A

            foreach (char c in city1)
            {
                Console.WriteLine(c);
            }

            string city2 = "İstanbul";
            string result1 = city1 + city2; // concetenate: Ankaraİstanbul
            string result2 = city1 + " " + city2; // Ankara İstanbul

            string result3 = string.Format("{0} {1}", city1, city2); // Ankara İstanbul

            string sentence = "My name is Çağıl Alsaç";
            int length = sentence.Length; // 22
            sentence = sentence.Replace("Çağıl", "Leo"); // My name is Leo Alsaç
            if (sentence.EndsWith("ç"))
                Console.WriteLine("Sentence ends with ç");
            else
                Console.WriteLine("Sentence doesn't end with ç");

            if (sentence.StartsWith("Your name"))
                Console.WriteLine("Sentence starts with \"Your name\""); // "Your name"
            else
                Console.WriteLine("Sentence doesn't start with \"Your name\"");

            // My name is Leo Alsaç
            int indexOfIs = sentence.IndexOf("is"); // 8
            Console.WriteLine(indexOfIs);
            int indexOfCagil = sentence.IndexOf("çağıl"); // -1
            Console.WriteLine(indexOfCagil);

            int indexOfSpace = sentence.IndexOf(" "); // 2
            int lastIndexOfSpace = sentence.LastIndexOf(" "); // 14

            Console.WriteLine(indexOfSpace + " - "  + lastIndexOfSpace);

            // Hello! My name is Leo Alsaç
            //sentence = "Hello! " + sentence;
            sentence = sentence.Insert(0, "Hello! ");

            // Hello! My name is Leo Alsaç
            string subSentence = sentence.Substring(0, 6); // Hello!
            Console.WriteLine(subSentence);
            subSentence = sentence.Substring(18); // Leo Alsaç
            subSentence = sentence.Substring(7, 14); // My name is Leo

            // Hello! My name is Leo Alsaç
            Console.WriteLine("Lower: " + sentence.ToLower());
            Console.WriteLine("Upper: " + sentence.ToUpper());
            Console.WriteLine(sentence.Replace(" ", "_"));

            // Hello! My name is Leo Alsaç
            sentence = sentence.Remove(0, 7); // My name is Leo Alsaç

            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(words[3]); // Leo

            string test1 = "test1";
            string test2 = "test2";
            if (test1 == test2)
                Console.WriteLine("test1 = test2");
            else
                Console.WriteLine("test1 != test2");

            if (test1.Equals(test2))
                Console.WriteLine("test1 = test2");
            else
                Console.WriteLine("test1 != test2");

            string adSoyad = " Çağıl Alsaç "; //  Çağıl Alsaç 
            Console.WriteLine("\"" + adSoyad + "\"");
            Console.WriteLine("\"" + adSoyad.Trim() + "\"");
            Console.WriteLine("\"" + adSoyad.TrimStart() + "\"");
            Console.WriteLine("\"" + adSoyad.TrimEnd() + "\"");
            if (adSoyad.Contains("saç"))
                Console.WriteLine("saç var");
            else
                Console.WriteLine("saç yok");
            Console.WriteLine(adSoyad.Contains("ğ") ? "ğ var" : "ğ yok");

            // escape sequences
            string name = "Çağıl";
            string escapedName = "\"Çağıl\""; // "Çağıl"
            Console.WriteLine(escapedName);
            String surname = "Alsaç";
            escapedName = name + "\n" + surname;
            Console.WriteLine(escapedName);
            escapedName = name + "\t" + surname;
            Console.WriteLine(escapedName);
            string path1 = "C:\\BA\\Console"; // C:\BA\Console
            path1 = @"C:\BA\Console"; // C:\BA\Console
            
            

            DateTime simdi = DateTime.Now;
            Console.WriteLine(simdi);
            Console.WriteLine(simdi.ToShortDateString()); 
            Console.WriteLine(simdi.ToLongDateString()); 
            Console.WriteLine(simdi.ToShortTimeString()); 
            Console.WriteLine(simdi.ToLongTimeString());
            Console.WriteLine(simdi.ToShortDateString() + " " + simdi.ToLongTimeString());
            Console.WriteLine(simdi.Month + "/" + simdi.Day + "/" + simdi.Year + " " + simdi.Hour + ":" + simdi.Minute + ":" + simdi.Second + "." + simdi.Millisecond);

            DateTime tarih = new DateTime(2020, 11, 28, 19, 17, 0);
            Console.WriteLine(tarih);

            tarih = DateTime.Parse("04.12.2021", new CultureInfo("tr")); // en
            Console.WriteLine(tarih);
            tarih = DateTime.Parse("04/13/2021 16:01:25", new CultureInfo("en"));
            string tarihText = tarih.ToString(new CultureInfo("en"));
            Console.WriteLine(tarihText);
            tarihText = tarih.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(tarihText);

            simdi = DateTime.Now;
            Console.WriteLine("Yarın: " + simdi.AddDays(1));
            Console.WriteLine("1 hafta öncesi: " + simdi.AddDays(-7));
            Console.WriteLine("6 ay sonrası: " + simdi.AddMonths(6).ToShortDateString());
            Console.WriteLine("2 sene sonrası: " + simdi.AddYears(2).ToLongDateString());
            Console.WriteLine("12 saat sonrası: " + simdi.AddHours(12));
            Console.WriteLine("Yarım saat öncesi: " + simdi.AddMinutes(-30));

            var tarih1 = DateTime.Parse("01.10.2020");
            var tarih2 = DateTime.Parse("20.10.2020");
            if (tarih2.CompareTo(tarih1) > 0)
                Console.WriteLine("tarih2 > tarih1");
            else if (tarih2.CompareTo(tarih1) < 0)
                Console.WriteLine("tarih2 < tarih1");
            else // tarih2.CompareTo(tarih1) == 0
                Console.WriteLine("tarih2 = tarih1");

            if (tarih2 > tarih1)
                Console.WriteLine("tarih2 > tarih1");
            else if (tarih2 < tarih1)
                Console.WriteLine("tarih2 < tarih1");
            else // tarih2 == tarih1
                Console.WriteLine("tarih2 = tarih1");

            Console.WriteLine(simdi.Date);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(simdi.DayOfWeek + " " + (int)simdi.DayOfWeek);
            Console.WriteLine(simdi.DayOfYear);
            Console.WriteLine(simdi.Ticks);

            Console.WriteLine("PI: " + Math.PI);
            int sayi1 = 10;
            int sayi2 = 20;
            Console.WriteLine("Sonuç: " + (sayi1 - sayi2) + ", Mutlak değer: " + Math.Abs(sayi1 - sayi2));
            double sayi = 2.9;
            Console.WriteLine((int)sayi); // 2
            Console.WriteLine(Math.Floor(sayi)); // 2
            Console.WriteLine(Math.Ceiling(sayi)); // 3
            Console.WriteLine(Math.Pow(2, 4)); // 16
            Console.WriteLine(Math.Min(1, 2) + " - " + Math.Max(1.1, 2.2));
            double sayi4 = 12.34501;
            double sayi5 = 98.76500;
            Console.WriteLine(Math.Round(sayi4));
            Console.WriteLine(Math.Round(sayi5));
            Console.WriteLine(Math.Round(sayi4, 1));
            Console.WriteLine(Math.Round(sayi5, 1));
            Console.WriteLine(Math.Round(sayi4, 2));
            Console.WriteLine(Math.Round(sayi5, 2));
            Console.WriteLine(Math.Sqrt(64)); // 8

            // 8 ^ (1 / 3) = 2
            Console.WriteLine(Math.Pow(8, 1.0 / 3.0));

            Console.ReadLine();
        }
    }
}
