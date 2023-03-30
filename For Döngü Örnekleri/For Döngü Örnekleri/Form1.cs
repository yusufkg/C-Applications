using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Döngü_Örnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i= 0;
        int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //0 dan 10 a kadar listboxa yazdır
            //int i;
            //for (i = 0; i < 10; i++)
            //{
            //    listBox1.Items.Add(i);
            //}

            //10 dan 20 ye kadar listboxa ve labela yazdır

            //for (int j = 10; j <= 20; j++)
            //{

            //    listBox1.Items.Add(j);
            //    label1.Text = j.ToString();
            //}

            //Butona her tıkladında 1 arttır i değeri globalde tanımlanmalı
            //i++;
            //label1.Text = i.ToString();

            for (int i = 0; i < 6; i++)
            {
                toplam = toplam + i;
                label1.Text = toplam.ToString();
                listBox1.Items.Add(i);
                listBox2.Items.Add(toplam);
            }


        }
    }
}
