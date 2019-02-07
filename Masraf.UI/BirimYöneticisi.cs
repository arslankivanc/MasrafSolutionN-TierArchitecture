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
    public partial class BirimYöneticisi : Form
    {
        public BirimYöneticisi()
        {
            InitializeComponent();
        }
        MasrafTakipEntities ndata = new MasrafTakipEntities();
        MasrafRepository mRepo = new MasrafRepository();
        KisiRepo kRepo = new KisiRepo();
        private void BirimYöneticisi_Load(object sender, EventArgs e)
        {
            txt_Baslik.Focus();
            comboBox1.DataSource = kRepo.SelecAll().Select(a => new
            {
                MasrafSahibi = a.İsim + "  " + a.Soyisim,
                a.pid
            }).ToList();
            comboBox1.DisplayMember = "MasrafSahibi";
            comboBox1.ValueMember = "pid";
            dataGridView1.DataSource = mRepo.SelecAllBirimYön();
        }
        public void Veriler()
        {
            ndata.SaveChanges();
            dataGridView1.DataSource = mRepo.SelecAllBirimYön();
        }

        Masraflar sec;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }
            else
            {
                sec = (Masraflar)dataGridView1.CurrentRow.DataBoundItem;
                txt_Baslik.Text = sec.Baslik;
                num_tutar.Value = sec.Tutar;
                rich_aciklama.Text = sec.Acıklama;
                date_tarih.Value = Convert.ToDateTime(sec.Tarih);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                int numara = Convert.ToInt32(item.Cells[0].Value);
                mRepo.Delete(numara);
            }
            Veriler();
            MessageBox.Show("Silindi");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            sec.Baslik = txt_Baslik.Text;
            sec.Tutar = num_tutar.Value;
            sec.Acıklama = rich_aciklama.Text;
            sec.Tarih = date_tarih.Value;
            mRepo.Update(sec);

            Veriler();
            Temizle(this);
            MessageBox.Show("Güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Masraflar ekle = new Masraflar();
            ekle.Baslik = txt_Baslik.Text;
            ekle.Tutar = num_tutar.Value;
            ekle.Acıklama = rich_aciklama.Text;
            ekle.MasrafSahibi = label1.Text;
            ekle.Tarih = date_tarih.Value;
            ekle.OnayDurumu = "Bekliyor".ToString();
            ekle.YetkiRol = 2;
            mRepo.Insert(ekle);
            Veriler();
            Temizle(this);
            MessageBox.Show("Kayıt Yapıldı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ndata.SaveChanges();
            dataGridView1.DataSource = mRepo.SelecAllBirimYön();
        }
        public void Temizle(Control ctl)
        {
            foreach (Control item in ctl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item is RichTextBox)
                {
                    ((RichTextBox)item).Text="";
                }
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value =Convert.ToDecimal( 0.00);
                }
                

            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectionLength > 0)
            {
                string masrafismi = comboBox1.Text;
                dataGridView1.DataSource = mRepo.selectMasrafID(masrafismi).Where(f => f.YetkiRol == 2 || f.YetkiRol ==3).Select(f => new
                {
                    f.Baslik,
                    f.Tutar,
                    f.Acıklama,
                    f.Tarih,
                    f.OnayDurumu,
                    f.MasrafSahibi,
                    f.masrafid
                }).ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
            Veriler();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }
            else
            {
                sec = (Masraflar)dataGridView1.CurrentRow.DataBoundItem;
            }
            
        }
    }
}
