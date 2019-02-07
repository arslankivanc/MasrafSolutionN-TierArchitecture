using Masraf.DAL;
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
    public partial class YetkiliGiris : Form
    {
        public YetkiliGiris()
        {
            InitializeComponent();
        }
        MasrafTakipEntities mGiris;
        public  string ad="";
        public  string soyad="";

        public bool Giris(string username,string password,string yetki)
        {
            mGiris = new MasrafTakipEntities();
            if (yetki == "Yönetici")
            {
                var user = (from p in mGiris.Kisi
                            join u in mGiris.Kullanıcı on
                            p.pid equals u.personid
                            where p.AktifMi == true &&
                            u.YöneticiRol == 1 &&
                            u.Username == username &&
                            u.Password == password &&
                            u.Aktif == true

                            select p).FirstOrDefault();
                if (user != null)
                {
                    ad = user.İsim;
                    soyad = user.Soyisim;
                    return true;
                }
            }else if(yetki == "BirimYöneticisi")
            {
                var user = (from p in mGiris.Kisi
                            join u in mGiris.Kullanıcı on
                            p.pid equals u.personid
                            where p.AktifMi == true &&
                            u.YöneticiRol == 2 &&
                            u.Username == username &&
                            u.Password == password &&
                            u.Aktif == true

                            select p).FirstOrDefault();
                if (user != null)
                {
                    ad = user.İsim;
                    soyad = user.Soyisim;
                    return true;
                }
            }
            else
            {
                var user = (from p in mGiris.Kisi
                            join u in mGiris.Kullanıcı on
                            p.pid equals u.personid
                            where p.AktifMi == true &&
                            u.YöneticiRol == 3 &&
                            u.Username == username &&
                            u.Password == password &&
                            u.Aktif == true

                            select p).FirstOrDefault();
                if (user != null)
                {
                    ad = user.İsim;
                    soyad = user.Soyisim;
                    return true;
                }
            }

            
            return false;

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            var user_name = textBox1.Text;
            var pass_word = textBox2.Text;
            var yetki = comboBox1.Text.ToString();
            var GirisDurumu = Giris(user_name , pass_word , yetki);
            var errorMes = "";
            var iserror = false;
            if (string.IsNullOrEmpty(user_name))
            {
                errorMes += "Kullanıcı Adı Boş Girilemez! \r\n";
                iserror = true;
            }
            if (string.IsNullOrEmpty(pass_word))
            {
                errorMes += "Parola Boş Girilemez! \r\n";
                iserror = true;
            }
            if (string.IsNullOrEmpty(yetki))
            {
                errorMes += "Yetki Seçmelisiniz \r\n";
                iserror = true;
            }
            if (iserror)
            {
                MessageBox.Show(errorMes ,"Hata" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GirisDurumu && yetki =="Yönetici" )
            {
                this.Close();
                Yönetici form = new Yönetici();
                form.label1.Text = ad + "  " + soyad;
                form.Show();
            }
            else if (GirisDurumu && yetki == "BirimYöneticisi")
            {
                this.Close();
                BirimYöneticisi form = new BirimYöneticisi();
                form.label1.Text = ad + "  " + soyad;
                form.Show();
            }
            else if (GirisDurumu && yetki == "Çalisan")
            {
                this.Close();
                Çalişan form = new Çalişan();
                form.label1.Text = ad + "  " + soyad;
                form.Show();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
