﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam = sayi1 + sayi2;
            label4.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, sonuc;
            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);
            
            sonuc = a * b;
            label7.Text = sonuc.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
