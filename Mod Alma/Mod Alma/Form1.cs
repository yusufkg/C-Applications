using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod_Alma
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
            int sayı2,mod;
            sayı = 60 % 16;
            label1.Text = sayı.ToString();
            sayı2 = Convert.ToInt32(textBox1.Text);
            mod = 100 % 12;
            label2.Text = mod.ToString();
        }
    }
}
