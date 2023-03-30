using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saat_Dakika_Mod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı;
            int saat, dakika;
            sayı = Convert.ToInt32(textBox1.Text);
            saat = sayı/60;
            label2.Text = saat.ToString();

            dakika = sayı%60;
            label5.Text = dakika.ToString();

        }
    }
}
