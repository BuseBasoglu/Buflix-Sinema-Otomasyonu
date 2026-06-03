using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace otomasyonfilm
{
    public partial class Form_Inceleme : Form
    {
        OtomasyonFilmDbContext db = new OtomasyonFilmDbContext();

        public Form_Inceleme()
        {
            InitializeComponent();
        }

        private void Form_Inceleme_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            try
            {
                combo_AktifKullanici.DataSource = db.Kullanicilar.Select(k => new
                {
                    k.Kullanici_Id,
                    AdSoyad = k.Ad + " " + k.Soyad
                }).ToList();
                combo_AktifKullanici.DisplayMember = "AdSoyad";
                combo_AktifKullanici.ValueMember = "Kullanici_Id";

                combo_Filmler.DataSource = db.Filmler.ToList();
                combo_Filmler.DisplayMember = "FilmAdi";
                combo_Filmler.ValueMember = "Film_Id";

                YorumlariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void YorumlariListele()
        {
            try
            {
                var list = db.Incelemeler
                    .Include(i => i.Kullanici)
                    .Include(i => i.Film)
                    .Select(i => new
                    {
                        i.Inceleme_Id,
                        Yazar = i.Kullanici.Ad + " " + i.Kullanici.Soyad,
                        Rütbesi = i.Kullanici.Rutbe,
                        Film = i.Film.FilmAdi,
                        Yorum = i.YorumMetni,
                        FaydalıBulunma = i.FaydaliSayisi
                    }).ToList();

                dataGridView_Incelemeler.DataSource = list;
                dataGridView_Incelemeler.Columns["Inceleme_Id"].Visible = false;
                dataGridView_Incelemeler.Columns["FaydalıBulunma"].HeaderText = "Faydalı Bulunma";
                dataGridView_Incelemeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Listeleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_YorumYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_Yorum.Text))
                {
                    MessageBox.Show("Yorum alanı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (combo_AktifKullanici.SelectedValue == null || combo_Filmler.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen kullanıcı ve film seçimi yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int seciliKullaniciId = (int)combo_AktifKullanici.SelectedValue;

                Inceleme yeniInceleme = new Inceleme
                {
                    Kullanici_Id = seciliKullaniciId,
                    Film_Id = (int)combo_Filmler.SelectedValue,
                    YorumMetni = txt_Yorum.Text,
                    FaydaliSayisi = 0
                };

                db.Incelemeler.Add(yeniInceleme);
                db.SaveChanges();

                var yorumYapanKullanici = db.Kullanicilar.Find(seciliKullaniciId);
                int kullaniciYorumSayisi = db.Incelemeler.Count(i => i.Kullanici_Id == seciliKullaniciId);

                if (kullaniciYorumSayisi >= 3 && yorumYapanKullanici.Rutbe != "Usta")
                {
                    yorumYapanKullanici.Rutbe = "Usta";
                    db.SaveChanges();
                    MessageBox.Show($"Tebrikler! {yorumYapanKullanici.Ad}, yaptığınız incelemeler sayesinde 'Usta' rütbesine yükseldiniz!", "Rütbe Atlandı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Yorumunuz başarıyla paylaşıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txt_Yorum.Clear();
                YorumlariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yorum ekleme işlemi başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_YorumSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_Incelemeler.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz yorumu tablodan seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (combo_AktifKullanici.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen aktif kullanıcıyı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int secilenIncelemeId = Convert.ToInt32(dataGridView_Incelemeler.CurrentRow.Cells["Inceleme_Id"].Value);
                var silinecekInceleme = db.Incelemeler.Find(secilenIncelemeId);

                if (silinecekInceleme != null)
                {
                    int aktifKullaniciId = (int)combo_AktifKullanici.SelectedValue;

                    if (silinecekInceleme.Kullanici_Id != aktifKullaniciId)
                    {
                        MessageBox.Show("Sadece kendi yaptığınız yorumları silebilirsiniz!", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult sonuc = MessageBox.Show("Bu yorumu silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (sonuc == DialogResult.Yes)
                    {
                        db.Incelemeler.Remove(silinecekInceleme);
                        db.SaveChanges();

                        MessageBox.Show("Yorum başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        YorumlariListele();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme işlemi başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_FaydaliBuldum_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_Incelemeler.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen faydalı bulduğunuz incelemeyi listeden seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int secilenIncelemeId = Convert.ToInt32(dataGridView_Incelemeler.CurrentRow.Cells["Inceleme_Id"].Value);
                var inceleme = db.Incelemeler.Find(secilenIncelemeId);

                if (inceleme != null)
                {
                    inceleme.FaydaliSayisi += 1;
                    db.SaveChanges();

                    MessageBox.Show("Yorum faydalı olarak işaretlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    YorumlariListele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İşlem başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void combo_Filmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                YesilYol.Visible = false;
                interstellar.Visible = false;
                Deadpool.Visible = false;
                UmudunuKaybetme.Visible = false;
                MadMax.Visible = false;
                inception.Visible = false;
                BladeRunner.Visible = false;

                string secilenFilm = combo_Filmler.Text;

                if (secilenFilm == "Yeşil Yol") YesilYol.Visible = true;
                else if (secilenFilm == "Interstellar") interstellar.Visible = true;
                else if (secilenFilm == "Deadpool") Deadpool.Visible = true;
                else if (secilenFilm == "Umudunu Kaybetme") UmudunuKaybetme.Visible = true;
                else if (secilenFilm == "Mad Max: Fury Road") MadMax.Visible = true;
                else if (secilenFilm == "Inception") inception.Visible = true;
                else if (secilenFilm == "Blade Runner 2049") BladeRunner.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Görsel yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Incelemeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}