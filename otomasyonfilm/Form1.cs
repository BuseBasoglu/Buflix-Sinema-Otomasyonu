using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace otomasyonfilm
{
    public partial class Form1 : Form
    {
        OtomasyonFilmDbContext db = new OtomasyonFilmDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = db.Kullanicilar.ToList();

                dataGridView1.Columns["Ad"].HeaderText = "Kullanıcı Adı";
                dataGridView1.Columns["Soyad"].HeaderText = "Kullanıcı Soyadı";
                dataGridView1.Columns["Email"].HeaderText = "E-Posta";
                dataGridView1.Columns["Telefon"].HeaderText = "Telefon No";
                dataGridView1.Columns["ElestirmenPuani"].HeaderText = "Eleştirmen Puanı";
                dataGridView1.Columns["Rutbe"].HeaderText = "Rütbe";

                dataGridView1.Columns["Kullanici_Id"].Visible = false;
                dataGridView1.Columns["IzlemeListeleri"].Visible = false;
                dataGridView1.Columns["Incelemeler"].Visible = false;
                dataGridView1.Columns["KurduguOdalar"].Visible = false;
                dataGridView1.Columns["GonderdigiMesajlar"].Visible = false;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_Ad.Text = dataGridView1.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
                txt_Soyad.Text = dataGridView1.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();
                txt_Email.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txt_Telefon.Text = dataGridView1.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici yeniKullanici = new Kullanici()
                {
                    Ad = txt_Ad.Text,
                    Soyad = txt_Soyad.Text,
                    Email = txt_Email.Text,
                    Telefon = txt_Telefon.Text
                };

                db.Kullanicilar.Add(yeniKullanici);
                db.SaveChanges();

                MessageBox.Show("Yeni Müşteri Eklendi!");
                btn_Listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kullanici_Id"].Value);
                    Kullanici guncellenecekKullanici = db.Kullanicilar.Find(secilenId);

                    if (guncellenecekKullanici != null)
                    {
                        guncellenecekKullanici.Ad = txt_Ad.Text;
                        guncellenecekKullanici.Soyad = txt_Soyad.Text;
                        guncellenecekKullanici.Email = txt_Email.Text;
                        guncellenecekKullanici.Telefon = txt_Telefon.Text;

                        db.SaveChanges();

                        MessageBox.Show("Kayıt Güncellendi!");
                        btn_Listele.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    if (dataGridView1.CurrentRow != null)
                    {
                        int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kullanici_Id"].Value);
                        var silinecekKullanici = db.Kullanicilar.Find(secilenId);

                        if (silinecekKullanici != null)
                        {
                            db.Kullanicilar.Remove(silinecekKullanici);
                            db.SaveChanges();

                            MessageBox.Show("Kayıt başarıyla silindi.");
                            btn_Listele.PerformClick();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_Gecis_Click(object sender, EventArgs e)
        {
            Form_IzlemeListesi form2 = new Form_IzlemeListesi();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void btn_MoodFiltresineGit_Click(object sender, EventArgs e)
        {
            Form_Mood moodFormu = new Form_Mood();
            moodFormu.Show();
        }

        private void btn_IncelemelereGit_Click(object sender, EventArgs e)
        {
            Form_Inceleme incelemeFormu = new Form_Inceleme();
            incelemeFormu.Show();
        }

        private void btn_TurnuvayaGit_Click(object sender, EventArgs e)
        {
            Form_Turnuva turnuvaFormu = new Form_Turnuva();
            turnuvaFormu.Show();
        }

        private void btn_CoopOdalaraGit_Click(object sender, EventArgs e)
        {
            Form_Coop coopFormu = new Form_Coop();
            coopFormu.Show();
        }
    }
}