using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arası_Geçiş
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Mavi")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text+" rengi= "+"Mutluluğun ve poziflik";
                button2.BackColor = Color.Blue;
            }
            if (comboBox1.Text == "Sarı")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " rengi= " + "İyimserliğin rengi";
                button2.BackColor = Color.Yellow;
            }
            if (comboBox1.Text == "Yeşil") 
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " rengi= " + "Bereketin rengidir";
                button2.BackColor = Color.Green;
            }
            if (comboBox1.Text == "Siyah")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " rengi= " + "Mutluluğun ve poziflik";
                button2.BackColor = Color.Blue;
            }
            if (comboBox1.Text == "Siyah")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " rengi= " + "Mutluluğun ve poziflik";
                button2.BackColor = Color.Blue;
            }
            if (comboBox1.Text == "Kırmızı")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " rengi= " + "Mutluluğun ve poziflik";
                button2.BackColor = Color.Red;
            }
            if (comboBox1.Text == "Beyaz")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " rengi= " + "Mutluluğun ve poziflik";
                button2.BackColor = Color.White;
            }
        }
    }
}
