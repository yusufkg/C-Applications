using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkHarfBuyukDigerleriKucukDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "çAğIl";
            string sonuc = FirstLetterToUpperOthersToLower(ad);
            Console.WriteLine(sonuc);

            string bogac = BogacMethodu(ad);
            Console.WriteLine(bogac);
            Console.ReadLine();

        }

        static string FirstLetterToUpperOthersToLower(string value) // feneRBahçE -> Fenerbahçe
        { 
            //string charString;
            //string upperCharString;
            string result = "";

            //char[] characters = new char[value.Length];
            //for (int i = 0; i < characters.Length; i++)
            //{
            //    characters[i] = value[i];
            //}
            char[] characters = value.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (i == 0) // f
                {
                    //charString = characters[i].ToString();
                    //upperCharString = charString.ToUpper();
                    //characters[i] = upperCharString[0];
                    characters[i] = characters[i].ToString().ToUpper()[0]; // F
                }
                else
                {
                    characters[i] = characters[i].ToString().ToLower()[0];
                }
            }

            //foreach (char c in characters)
            //{
            //    result = result + c;
            //}
            result = new string(characters);

            return result;
        }

        static string BogacMethodu(string value)
        {
            value = value.ToLower();
            string ilkHarf = value.Substring(0, 1);
            return ilkHarf.ToUpper() + value.Substring(1);
            
        }
    }
}
