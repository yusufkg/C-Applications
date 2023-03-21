using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random sayıuret = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            int a = sayıuret.Next(1, 7);
            int b = sayıuret.Next(1, 7);
            int alan;
            label1.Text = a.ToString();
            label2.Text = b.ToString();
            alan = a * b;
            label3.Text = alan.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
