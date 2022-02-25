using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaApp
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YardimForm form = new YardimForm();
            form.Show();
        }

        private void belirtiTespitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BelirtiTespitForm form = new BelirtiTespitForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void yüzdeTespitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YüzdeTespitForm form = new YüzdeTespitForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            HosgeldinForm form = new HosgeldinForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
