using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaApp
{
    public partial class YüzdeTespitForm : Form
    {
        public YüzdeTespitForm()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            tbAdSoyad.Text = "";
            cbAtes.Checked = false;
            cbBogazAgrisi.Checked = false;
            cbOksuruk.Checked = false;
            lbSonuc.Items.Clear();
            gbRapor.Visible = false;
           
        }
        //ateşin yüzdesi %70, oksuruk: %20, boğaz ağrısı: %10
        // hem ateş hem öksürükse %90
        // hepsi seçiliyse %100
        private void button1_Click(object sender, EventArgs e)
        {
            int yuzde = 0;
            if (cbAtes.Checked)
                yuzde += 70;
            if (cbOksuruk.Checked)
                yuzde += 20;
            if (cbBogazAgrisi.Checked)
                yuzde += 10;
            lbSonuc.Items.Add("Sayın " + tbAdSoyad.Text + ", %" + yuzde + " ihtimalle koronasınız."); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            rtbRapor.Text = "";
            if (lbSonuc.Items.Count > 0) // elinde bir koleksiyon varsa onu count ile kontrol et.
            {
                foreach (var item in lbSonuc.Items)
                {
                    rtbRapor.Text += item + "\r\n";
                }
            }
            gbRapor.Visible = true;
        }
    }
}
