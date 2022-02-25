using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. başla
            2.Kullanıcının adı sorulur.
            3.kullanıcıdan adının girilmesi istenir.
            4.kullanıcının yaşı sorulur.
            5.kullanıcının yaşının girilmesi istenir.
            6.kullanıcının eğitim durumu sorulur.
            7.kullanıcının eğitim durumunun girilmesi istenir.
            8.kullanıcının sağlık durumu sorulur
            9.kullanıcıdan sağlık durumu girilmesi istenir.
            10.eğer yaşı 18 veya daha büyükse(yas >= 18) ve eğitim durumu lise ve üstü ise ve sağlık durumu psikopat değilse
            10.1 kullanıcıya adı ile birlikte ehliyet alabileceği belirtilir.
            10.2 10.madde değil durumunda
            10.3 kullanıcıya adı ile birlikte ehliyet alamayacağı belirtilir.
            11.bitiş
            */

            Console.Write("Adınız: ");
            string ad = Console.ReadLine();
            Console.Write("Yaşınız: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Eğitim durumu: (ilkokul: i, ortaokul: o, lise: l, üniversite: ü): ");
            string egitim = Console.ReadLine(); //charda ASCII tablosunu kullanma şansı var. string daha güvenli
            Console.Write("Renk körü müsün? (evet: e, hayır: h)");
            string renkKoruMu = Console.ReadLine();
            //if (yas >= 18)
            //{
            //    if (egitim == "1" || egitim == "ü")
            //    {
            //        if (renkKoruMu == "h")
            //        {
            //            Console.WriteLine("Sayın" + ad + ", ehliyet alabilirsiniz.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sayın " + ad + ", ehliyet alamazsınız. Renk körüsünüz");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayın " + ad + ", ehliyet alamazsınız. İlkokul veya ortaokul mezunusunuz");
            //    }
               
            //}
            //else
            //{
            //    Console.WriteLine("Sayın " + ad + ", ehliyet alamazsınız. 18 Yaşından küçüksünüz.");
            //}
            if (yas >= 18 && (egitim == "l" || egitim == "ü") && renkKoruMu == "h") //operator değişiyorsa (&&,||) paranteze alınılmalı
            {
                Console.WriteLine("Sayın " + ad + ", ehliyet alabilirsiniz.");
            }
            else // yas < 18 || (egitim != "1" && egitim != "ü") || renkKoruMu != "h"
            {
                Console.WriteLine("Sayın " + ad + ", ehliyet alamazsınız.");
            }
            Console.ReadLine();
        }
    }
}
