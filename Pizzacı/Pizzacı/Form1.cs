using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzacı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "C# dersi başladı";
            label1.Text = "deneme merhaba dünya";
            //    comboBox1.Items.Add("İstanbul");
            //    comboBox1.Items.Add("Ankara");
            listBox1.Items.Add("İstanbul");
            listBox1.Items.Add("Bursa");
            listBox1.Items.Add("Ankara");
        }
    }
}
