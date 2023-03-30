using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktoriyel_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i;
        int faktoriyel = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 1; i < 7; i++)
            {
                faktoriyel = faktoriyel * i;
                listBox1.Items.Add(faktoriyel);
                label1.Text = faktoriyel.ToString();
            }
        }
    }
}
