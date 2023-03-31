using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dakika = 0;
        int saniye = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   int salise = Convert.ToInt32(label6.Text);
            salise++;
            timer1.Interval = 100;
            if (salise==10)
            {

                salise = 0;
                label6.Text = salise.ToString();
                saniye++;
                label1.Text = saniye.ToString();
                timer1.Interval = 1000;
            }
        }
    }
}
