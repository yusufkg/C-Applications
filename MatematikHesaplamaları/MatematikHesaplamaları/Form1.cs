﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikHesaplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Diktörgen

            //int birkenar;
            //int alan,çevre;
            //int dikalan, dikçevre;
            //int uzun;

            //birkenar = Convert.ToInt32(textBox1.Text);
            //uzun = Convert.ToInt32(textBox2.Text);

            //alan = birkenar * birkenar;
            //çevre = 4 * birkenar;

            //dikalan = birkenar * uzun;
            //dikçevre = (2 * birkenar) + (2*uzun);

            //label5.Text = alan.ToString();
            //label6.Text = çevre.ToString();

            //label5.Text = dikalan.ToString();
            //label6.Text = çevre.ToString();

            //Kare
            int birkenar, alan, çevre;
            birkenar = Convert.ToInt32(textBox1.Text);
            alan = birkenar * birkenar;
            çevre = birkenar * 4;
            label5.Text = alan.ToString();
            label6.Text = çevre.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            label9.Visible = false;
            textBox2.Visible = false;
            label1.Text = "Kare";
            button5.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Dikdötgen";
            label2.Text = "Kısa kenar";
            panel1.Visible = true;
            button4.Visible = false;
            button5.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int kısa, uzun, alan, çevre;
            kısa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);
            alan = kısa * uzun;
            çevre = (2 * kısa) + (2 * uzun);
            label5.Text = alan.ToString();
            label6.Text = çevre.ToString();
        }
    }
}
