using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpRandomLig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label7.Text = c.ToString();
            label9.Text = d.ToString();

            if (Convert.ToInt32(label4.Text)>Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label5.Text)>Convert.ToInt32(label4.Text))
            {
                fbpuan = fbpuan + 3;
                labelgspuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label4.Text)==Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }



            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label9.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label9.Text) > Convert.ToInt32(label7.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label13.Text = a.ToString();
            label18.Text = b.ToString();
            label16.Text = c.ToString();
            label21.Text = d.ToString();

            if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label16.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label16.Text) > Convert.ToInt32(label13.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label13.Text) == Convert.ToInt32(label16.Text))
            {
                gspuan = gspuan + 1;
                bjkpuan = bjkpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }



            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label21.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label18.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label18.Text) == Convert.ToInt32(label21.Text))
            {
                fbpuan = fbpuan + 1;
                tspuan = tspuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label26.Text = a.ToString();
            label28.Text = b.ToString();
            label30.Text = c.ToString();
            label31.Text = d.ToString();

            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label28.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label28.Text) > Convert.ToInt32(label26.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label13.Text) == Convert.ToInt32(label16.Text))
            {
                fbpuan = fbpuan + 1;
                bjkpuan = bjkpuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if (Convert.ToInt32(label30.Text) > Convert.ToInt32(label31.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label31.Text) > Convert.ToInt32(label30.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label30.Text) == Convert.ToInt32(label31.Text))
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }
        }
    }
}
