using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaApp
{
    public partial class YardimForm : Form
    {
        public YardimForm()
        {
            InitializeComponent();
        }

        private void lbSaglikBakanligi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser1.Navigate("https://saglik.gov.tr/");
            webBrowser1.Visible = true;

            //Process.Start("chrome.exe", "https://saglik.gov.tr/");
        }
    }
}
