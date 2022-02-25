using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TlDovizHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.başla
            2. Kullanıcıdan TL cinsinden para girilmesi istenir
            3. Kullanıcı para girer
            4. Kullanıcıdan para birimi girilmesi istenir (Dolar: d, Euro: e, Pound: p)
            5.1 Eğer para birimi dolar ise;
            5.2 Kullanıcının girdiği parayı tanımlı olan dolar kuruna böl
            5.3 Eğer para birimi euro ise;
            5.4 Kullanıcının girdiği parayı tanımlı olan eruro kuruna böl
            5.5 Eğer para birimi pound ise;
            5.6 Kullanıcının girdiği parayı tanımlı olan pound kuruna böl
            5.7 Eğer para birimi dolar, euro ve pound değilse
            5.8 Kullanıcıdan doğru tanımlı para birimi girilmesi istenir.
            6. Hesaplama sonucu ekrana yazdır
            7. Bitir.
            */
            double tl;
            string paraBirimi;
            double dolar = 10;
            double euro = 11.4;
            double pound = 13;
            string tarih = "13.11.2021";
            double sonuc;

            Console.Write("TL cinsinden para giriniz: ");
            tl = Convert.ToDouble(Console.ReadLine());

            Console.Write("Para birimi giriniz: (dolar: d, euro: e, pound: p)");
            paraBirimi = Console.ReadLine();

            //if (paraBirimi != "d" && paraBirimi != "e" && paraBirimi != "p")
            if (!(paraBirimi == "d" || paraBirimi == "e" || paraBirimi == "p"))
            {
                Console.WriteLine("Doğru giriş yap!");
            }
            else // paraBirimi == "d" || paraBirimi == "e" || paraBirimi == "p"
            {

                if (paraBirimi == "d")
                    sonuc = tl / dolar;
                else if (paraBirimi == "e")
                    sonuc = tl / euro;
                else
                    sonuc = tl / pound;
                Console.WriteLine("Tarih: " + tarih + "\nDöviz Sonucu: " + sonuc);
            }
            Console.ReadLine();

        }
    }
}
