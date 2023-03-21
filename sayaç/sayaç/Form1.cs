using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayaç
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            sayı = sayı + 1;
            label1.Text = sayı.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayı = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayı = sayı + 3;
            label2.Text = sayı.ToString();
        }
    }
}
