using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;


namespace otomasyonfilm
{
    public partial class Form_IzlemeListesi : Form
    {
        OtomasyonFilmDbContext db = new OtomasyonFilmDbContext();
        public Form_IzlemeListesi()
        {
            InitializeComponent();
        }

        private void Form_IzlemeListesi_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_1.Text = string.Empty;
                lbl_2.Text = string.Empty;

                var kullanicilar = db.Kullanicilar.Select(k => new
                {
                    k.Kullanici_Id,
                    AdSoyad = k.Ad + " " + k.Soyad
                }).ToList();

                combo_Kullanici.DataSource = kullanicilar;
                combo_Kullanici.DisplayMember = "AdSoyad";
                combo_Kullanici.ValueMember = "Kullanici_Id";

                var filmler = db.Filmler.Select(f => new
                {
                    f.Film_Id,
                    f.FilmAdi
                }).ToList();

                combo_Film.DataSource = filmler;
                combo_Film.DisplayMember = "FilmAdi";
                combo_Film.ValueMember = "Film_Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AnaForm_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            try
            {
                var list = db.IzlemeListeleri
                    .Include(i => i.Kullanici)
                    .Include(i => i.Film.Kategori)
                    .Select(i => new
                    {
                        i.Kayit_Id,
                        KullaniciAdi = i.Kullanici.Ad + " " + i.Kullanici.Soyad,
                        FilmAdi = i.Film.FilmAdi,
                        Kategori = i.Film.Kategori.KategoriAdi
                    }).ToList();

                dataGridView1.DataSource = list;

                dataGridView1.Columns["KullaniciAdi"].HeaderText = "Kullanıcı Adı";
                dataGridView1.Columns["FilmAdi"].HeaderText = "Film Adı";
                dataGridView1.Columns["Kategori"].HeaderText = "Tür";

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["Kayit_Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Listeleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (combo_Kullanici.SelectedValue == null || combo_Film.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen kullanıcı ve film seçimi yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                IzlemeListesi yeniKayit = new IzlemeListesi
                {
                    Kullanici_Id = (int)combo_Kullanici.SelectedValue,
                    Film_Id = (int)combo_Film.SelectedValue
                };

                db.IzlemeListeleri.Add(yeniKayit);
                db.SaveChanges();

                MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ekleme işlemi başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silinecek kaydı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult sonuc = MessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kayit_Id"].Value);
                    var silinecekKayit = db.IzlemeListeleri.Find(secilenId);

                    if (silinecekKayit != null)
                    {
                        db.IzlemeListeleri.Remove(silinecekKayit);
                        db.SaveChanges();

                        MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_Listele.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme işlemi başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rd_1.Checked)
                {
                    var enCokFilmAlan = db.IzlemeListeleri
                        .GroupBy(i => i.Kullanici.Ad + " " + i.Kullanici.Soyad)
                        .Select(g => new
                        {
                            KullaniciAdi = g.Key,
                            FilmSayisi = g.Count()
                        })
                        .OrderByDescending(x => x.FilmSayisi)
                        .FirstOrDefault();

                    if (enCokFilmAlan != null)
                    {
                        lbl_1.Text = $"Kullanıcı: {enCokFilmAlan.KullaniciAdi} - Eklenen Film: {enCokFilmAlan.FilmSayisi} Adet";
                    }
                    else
                    {
                        lbl_1.Text = "Veri bulunamadı.";
                    }

                    lbl_2.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sorgu hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rd_2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rd_2.Checked)
                {
                    var enCokIncelemeYapan = db.Incelemeler
                        .GroupBy(i => i.Kullanici.Ad + " " + i.Kullanici.Soyad)
                        .Select(g => new
                        {
                            KullaniciAdi = g.Key,
                            IncelemeSayisi = g.Count()
                        })
                        .OrderByDescending(x => x.IncelemeSayisi)
                        .FirstOrDefault();

                    if (enCokIncelemeYapan != null)
                    {
                        lbl_2.Text = $"Kullanıcı: {enCokIncelemeYapan.KullaniciAdi} - İnceleme: {enCokIncelemeYapan.IncelemeSayisi} Adet";
                    }
                    else
                    {
                        lbl_2.Text = "Veri bulunamadı.";
                    }

                    lbl_1.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sorgu hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combo_Film_SelectedIndexChanged(object sender, EventArgs e)
        {
            YesilYol.Visible = false;
            interstellar.Visible = false;
            Deadpool.Visible = false;
            UmudunuKaybetme.Visible = false;
            MadMax.Visible = false;
            inception.Visible = false;
            BladeRunner.Visible = false;

            string secilenFilm = combo_Film.Text;

            if (secilenFilm == "Yeşil Yol") YesilYol.Visible = true;
            else if (secilenFilm == "Interstellar") interstellar.Visible = true;
            else if (secilenFilm == "Deadpool") Deadpool.Visible = true;
            else if (secilenFilm == "Umudunu Kaybetme") UmudunuKaybetme.Visible = true;
            else if (secilenFilm == "Mad Max: Fury Road") MadMax.Visible = true;
            else if (secilenFilm == "Inception") inception.Visible = true;
            else if (secilenFilm == "Blade Runner 2049") BladeRunner.Visible = true;
        }
    }
}
