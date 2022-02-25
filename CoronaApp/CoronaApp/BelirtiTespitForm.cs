using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaApp
{
    public partial class BelirtiTespitForm : Form
    {
        string[] sehirler = new string[3]
        {
            "Ankara",
            "İstanbul",
            "İzmir"
        };

        public BelirtiTespitForm()
        {
            InitializeComponent();
        }

        private void BelirtiTespitForm_Load(object sender, EventArgs e)
        {
            /*
             * foreach (string sehir in sehirler)
            {
                ddlSehir.Items.Add(sehir);
            } 
            */
            ddlSehir.Items.AddRange(sehirler);
            ddlSehir.SelectedIndex = 0;
            dtpTarih.Value = DateTime.Now;
        }

        private void bTespit_Click(object sender, EventArgs e)
        {
            TespitEt();
        }

        private void TespitEt()
        {
            if (rbKadin.Checked)
            {
                tbSonuc.Text = "Bayan ";
            }
            else
            {
                tbSonuc.Text = "Bay ";
            }
            //tbSonuc.Text = tbSonuc.Text + tbAd.Text + " " + tbSoyad.Text;
            tbSonuc.Text += tbAd.Text + " " + tbSoyad.Text + "\r\n";
            tbSonuc.Text += "Şehriniz: " + ddlSehir.Text + "\r\n";
            tbSonuc.Text += "Yaşınız: " + nudYas.Value + "\r\n";
            //tbSonuc.Text += "Test tarihi: " + dtpTarih.Value.ToShortDateString(); 
            tbSonuc.Text += "Test tarihi: " + dtpTarih.Value.ToString("dd.MM.yyyy", new CultureInfo("tr")) + "\r\n";
            //ateş varsa corona 
            //ateş yok boğaz ağrısı ve öksürük varsa yine corona
            if (cbAtes.Checked)
            {
                tbSonuc.Text += "Coronalandınız.";
            }
            else if (cbBogazAgrisi.Checked && cbOksuruk.Checked)
            {
                tbSonuc.Text += "Coronalandınız.";
            }
            else
            {
                tbSonuc.Text += "Değilsiniz büyük ihtimal";
            }
        }

        private void cbAtes_CheckedChanged(object sender, EventArgs e)
        {
            TespitEt();
        }

        private void cbOksuruk_CheckedChanged(object sender, EventArgs e)
        {
            TespitEt();
        }

        private void cbBogazAgrisi_CheckedChanged(object sender, EventArgs e)
        {
            TespitEt();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbAd.Text = "";
            tbSoyad.Clear();
            ddlSehir.SelectedIndex = 0;
            nudYas.Value = 50;
            rbKadin.Checked = true;
            dtpTarih.Value = DateTime.Now;
            cbAtes.Checked = false;
            cbBogazAgrisi.Checked = false;
            cbOksuruk.Checked = false;
            tbSonuc.Text = "";
        }
    }
}
