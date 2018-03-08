using Masraf.DAL;
using Masraf.PL;
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
    public partial class MuhasebeOnay : Form
    {
        public MuhasebeOnay()
        {
            InitializeComponent();
        }
        MasrafTakipEntities ndata = new MasrafTakipEntities();
        MasrafRepository mRepo = new MasrafRepository();
        KisiRepo kRepo = new KisiRepo();
        private void button2_Click(object sender, EventArgs e)
        {
            ndata.SaveChanges();
            dataGridView1.DataSource = mRepo.SelecAlloff();
        }
        public void Veriler()
        {
            ndata.SaveChanges();
            dataGridView1.DataSource = mRepo.SelecAlloff();
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == null || comboBox2.Text == "")
            {
                return;
            }
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {

                sec.OnayDurumu = comboBox2.Text;
                mRepo.Update(sec);

            }
            
        }
        Masraflar sec;
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }
            else
            {
                sec = (Masraflar)dataGridView1.CurrentRow.DataBoundItem;
            }
            Veriler();
        }

        private void MuhasebeOnay_Load(object sender, EventArgs e)
        {
                 dataGridView1.DataSource = mRepo.SelecAlloff();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
