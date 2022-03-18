using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PersonellerUygulamasi
{
    public partial class Form1 : Form
    {
        //1
        DBPersonelsEntities2 db = new DBPersonelsEntities2();
        Tbl_Personels tbl_Personels = new Tbl_Personels();//tablolar sınıflara dönüşür

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Listele
            dataGridView1.DataSource = db.Tbl_Personels.ToList();

            #endregion
        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            
            
            tbl_Personels.PersonelAd = txtPerAd.Text;
            tbl_Personels.PersonelSoyad = txtPerSoyad.Text;
   
            try
            {
                if (txtYas.Text == "")
                {
                    tbl_Personels.PerYas = 0;

                }
                else
                {
                    tbl_Personels.PerYas= Convert.ToInt32(txtYas.Text);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Yaş Alanı Boş Bırakılamaz");
            }
            try
            {
                if (txtMaas.Text == "")
                {
                    tbl_Personels.PersonelMaas = 0;
                }

                else
                {
                    tbl_Personels.PersonelMaas = Convert.ToInt32(txtMaas.Text);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Maaş Alanı Boş Bırakılamaz");


            }



            db.Tbl_Personels.Add(tbl_Personels);
            db.SaveChanges();
            MessageBox.Show("Personel Sisteme Kaydedildi!");
            dataGridView1.DataSource=db.Tbl_Personels.ToList();
            txtMaas.Text = "";
            txtPerAd.Text = "";
            txtPerSoyad.Text = "";
            txtYas.Text = "";
            txtSehir.Text = "";

        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {

            int deletE = Convert.ToInt32(txtPerID.Text);
            tbl_Personels=db.Tbl_Personels.First(f=>f.PersonelID==deletE);
            db.Tbl_Personels.Remove(tbl_Personels);
            db.SaveChanges();
            MessageBox.Show("Personel kaydı başarıyla silindi!");
            dataGridView1.DataSource = db.Tbl_Personels.ToList();


        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int guncelId = Convert.ToInt32(txtPerID.Text);
            tbl_Personels=db.Tbl_Personels.First(f=>f.PersonelID == guncelId);
            tbl_Personels.PersonelAd=txtPerAd.Text;
            tbl_Personels.PersonelSoyad=txtPerSoyad.Text;

            try
            {
                if (txtYas.Text=="")
                {
                    tbl_Personels.PerYas = 0;

                }
                else
                {
                    tbl_Personels.PerYas = Convert.ToInt32(txtYas.Text);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme için yaş alanını boş bırakmayınız");
            }

            try
            {
                if (txtMaas.Text == "")
                {
                    tbl_Personels.PersonelMaas = 0;

                }

                else
                {
                    tbl_Personels.PersonelMaas=Convert.ToInt32(txtMaas.Text);   
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme için maaş alanını boş bırakmayınız");
            }

            tbl_Personels.PersonelSehir = txtSehir.Text;
            db.SaveChanges();
            MessageBox.Show("Personel Bilgileri Başarıyla Güncellendi");
            dataGridView1.DataSource = db.Tbl_Personels.ToList();

            txtPerAd.Text = "";
            txtPerSoyad.Text = "";
            txtYas.Text = "";
            txtSehir.Text = "";



        }
    }
}
