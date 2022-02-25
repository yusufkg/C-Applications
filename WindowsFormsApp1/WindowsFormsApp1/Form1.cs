using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Araba araba;

        public Form1()
        {
            InitializeComponent();
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            araba = new Araba()
            {
                Id = 1,
                Marka = tbMarka.Text,
                Model = tbModel.Text,
                KapiSayisi = (KapiSayisi)ddlKapiSayisi.SelectedIndex,
                BeygirGucu = Convert.ToInt32(nudHp.Value),
                ArabaTuru = (ArabaTuru)ddlArabaTuru.SelectedIndex,
                MaksimumHiz = Convert.ToDouble(tbMaksimumHiz.Text),
                Cekis = (Cekis)ddlCekis.SelectedIndex,
                Hizlanma = Convert.ToDouble(tbHizlanma.Text),
                Agirlik = Convert.ToDouble(tbAgirlik.Text),
                MotorHacmi = Convert.ToDouble(tbMotorHacmi.Text),
            };
            MessageBox.Show("Arabanız Oluşturuldu. (Keşke her araba bu kadar kolay oluşturulsa.)");

        }

        private void bGoster_Click(object sender, EventArgs e)
        {
            string result = "";
            result += "Id: " + araba.Id + "\r\n";
            result += "Marka: " + araba.Marka + "\r\n";
            result += "Model: " + araba.Model + "\r\n";
            result += "Kapı Sayısı: " + araba.KapiSayisi + "\n";
            result += "Beygir Gücü: " + araba.BeygirGucu + "\n";
            result += "Araba Türü: " + araba.BeygirGucu + "\n";
            result += "Maksimum Hız: " + araba.MaksimumHiz + "\n";
            result += "Çekiş Gücü: " + araba.Cekis + "\n";
            result += "0'dan 100'e Kaç Saniye: " + araba.Hizlanma + "\n";
            result += "Ağırlık (kg): " + araba.Agirlik + "\n";
            result += "Motor Hacmi (cm3): " + araba.MotorHacmi + "\n";

            MessageBox.Show(result);
        }
    }
}
