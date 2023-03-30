using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void esareinBedeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "deneme";
            listBox1.Items.Add("Esaretin Bedeli");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void amelieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "deneme";
            listBox1.Items.Add("Amelie");
            listBox2.Items.Add(toolStripComboBox1.Text);

        }
    }
}
