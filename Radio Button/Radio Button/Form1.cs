using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı1 = 5;
        int sayı2 = 2;
        int topla, fark, böl, çarp;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            topla = sayı1+ sayı2;
            label1.Text = topla.ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fark = sayı1 - sayı2;
            label1.Text = fark.ToString();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            çarp = sayı1 * sayı2;
            label1.Text = çarp.ToString();
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            böl = sayı1 / sayı2;
            label1.Text = böl.ToString();
        }
    }
}
