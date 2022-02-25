using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbutOOP
{
    public partial class Form1 : Form
    {
        Zar zar = new Zar();

        string path = Application.StartupPath.Replace(@"bin\Debug", "Files");
        //C:\Users\bogachan.bakkaloglu\source\repos\BarbutOOP\BarbutOOP\bin\Debug
        //C:\Users\bogachan.bakkaloglu\source\repos\BarbutOOP\BarbutOOP\Files 'a çevirdik.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lZar1.Text = "";
            lZar2.Text = "";
        }

        private void bZarAt_Click(object sender, EventArgs e)
        {
            Oyna();

        }

        private void Oyna()
        {
            lZar1.Text = zar.ZarAt();
            int sayi1 = zar.Sayi;
            lZar2.Text = zar.ZarAt();
            int sayi2 = zar.Sayi;
            pbZar1.ImageLocation = path + "\\" + sayi1 + ".png";
            pbZar2.ImageLocation = path + "\\" + sayi2 + ".png";

            if (sayi1 > sayi2)
            {
                lbSonuc.Items.Add("1. zar kazandı.");
            }
            else if (sayi2 > sayi1)
            {
                lbSonuc.Items.Add("2. zar kazandı.");
            }
            else
            {
                //lbSonuc.Items.Add("Berabere.");
                Oyna();
            }
        }
    }
}
