using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimlikNoDogrulama
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static bool KimlikNoKontrolEt(string kimlikNo)
            
        {
            #region Gereksizce uzayan yöntem(saçma sapan bir yöntem)
            //    //11926126682
            //    bool sonuc = true;
            //    if (kimlikNo.Length != 11)
            //    {
            //        sonuc = false;
            //    }
            //    else
            //    {
            //        if (kimlikNo.Substring(0,1) != "0")
            //        {
            //            sonuc = false;
            //        }
            //        else
            //        {
            //            // buradan böyle devam edecekti...
            //        }
            //    }
            #endregion
            //11926126682
            if (kimlikNo.Length != 11)
                return false;
            if (kimlikNo.StartsWith("0"))
                return false;
            double[] haneler = new double[kimlikNo.Length];
            for (int h = 0; h < haneler.Length; h++)
            {
                haneler[h] = Convert.ToDouble(kimlikNo[h].ToString());
            }
            return true;


        }
    }
}
