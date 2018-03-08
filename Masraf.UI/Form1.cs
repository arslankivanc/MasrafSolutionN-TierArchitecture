using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masraf.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yöneticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void birimYöneticisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void çalışanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void muhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuhasebeYetkiliGiris form = new MuhasebeYetkiliGiris();
            form.MdiParent = this;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void yetkiliGirisİçinTıklayınızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YetkiliGiris form = new YetkiliGiris();
            form.MdiParent = this;
            form.Show();
        }
    }
}
