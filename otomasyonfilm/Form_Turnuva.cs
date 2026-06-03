using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace otomasyonfilm
{
    public partial class Form_Turnuva : Form
    {
        OtomasyonFilmDbContext db = new OtomasyonFilmDbContext();

        public Form_Turnuva()
        {
            InitializeComponent();
        }

        private void Form_Turnuva_Load(object sender, EventArgs e)
        {
            VerileriYukle();
            AdaylariListele();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kullanıcılar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdaylariListele()
        {
            try
            {
                if (db.TurnuvaAdaylari.Count() == 0)
                {
                    var tumFilmler = db.Filmler.ToList();

                    if (tumFilmler.Count == 0)
                    {
                        MessageBox.Show("Sistemde listelenecek film bulunamadı. Lütfen film ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    foreach (var film in tumFilmler)
                    {
                        var yeniAday = new TurnuvaAdayi
                        {
                            Film_Id = film.Film_Id,
                            OySayisi = 0
                        };
                        db.TurnuvaAdaylari.Add(yeniAday);
                    }
                    db.SaveChanges();
                }

                var gridAdaylar = db.TurnuvaAdaylari
                    .OrderByDescending(t => t.OySayisi)
                    .Select(t => new
                    {
                        Aday_Id = t.Aday_Id,
                        FilmAdi = t.Film.FilmAdi,
                        Kategori = t.Film.Kategori != null ? t.Film.Kategori.KategoriAdi : "Belirtilmemiş",
                        AlinanOy = t.OySayisi
                    }).ToList();

                dataGridView_Turnuva.DataSource = gridAdaylar;

                dataGridView_Turnuva.Columns["Aday_Id"].Visible = false;
                dataGridView_Turnuva.Columns["FilmAdi"].HeaderText = "Film Adı";
                dataGridView_Turnuva.Columns["AlinanOy"].HeaderText = "Alınan Oy";

                dataGridView_Turnuva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                var comboListesi = gridAdaylar.ToList();
                combo_Adaylar.DataSource = comboListesi;
                combo_Adaylar.DisplayMember = "FilmAdi";
                combo_Adaylar.ValueMember = "Aday_Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri listeleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_OyVer_Click(object sender, EventArgs e)
        {
            try
            {

                if (combo_AktifKullanici.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen oy kullanacak aktif kullanıcıyı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (combo_Adaylar.SelectedValue != null)
                {
                    int secilenAdayId = (int)combo_Adaylar.SelectedValue;
                    var aday = db.TurnuvaAdaylari.Find(secilenAdayId);

                    if (aday != null)
                    {
                        aday.OySayisi += 1;
                        db.SaveChanges();

                        MessageBox.Show("Oyunuz başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdaylariListele();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İşlem sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Sonuclandir_Click(object sender, EventArgs e)
        {
            try
            {
                var adaylar = db.TurnuvaAdaylari
                    .Include(t => t.Film)
                    .Include(t => t.Film.Kategori)
                    .ToList();

                if (adaylar.Count == 0)
                {
                    MessageBox.Show("Turnuva için yeterli veri bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var kategoriSampiyonlari = adaylar
                    .Where(t => t.Film.Kategori != null)
                    .GroupBy(t => t.Film.Kategori.KategoriAdi)
                    .Select(grup => new
                    {
                        KategoriAdi = grup.Key,
                        SampiyonFilm = grup.OrderByDescending(x => x.OySayisi).First()
                    })
                    .ToList();

                var genelSampiyon = adaylar.OrderByDescending(t => t.OySayisi).First();

                lbl_KazananFilm.Text = $"🏆 GECENİN YILDIZI 🏆\n{genelSampiyon.Film.FilmAdi} ({genelSampiyon.OySayisi} Oy)";
                lbl_KazananFilm.Visible = true;

                YesilYol.Visible = false;
                interstellar.Visible = false;
                Deadpool.Visible = false;
                UmudunuKaybetme.Visible = false;
                MadMax.Visible = false;
                inception.Visible = false;
                BladeRunner.Visible = false;

                string kazananFilm = genelSampiyon.Film.FilmAdi;

                if (kazananFilm == "Blade Runner 2049") pictureBox_Kazanan.Image = Properties.Resources.bladerunner;
                else if (kazananFilm == "Inception") pictureBox_Kazanan.Image = Properties.Resources.inception;
                else pictureBox_Kazanan.Image = null;

                pictureBox_Kazanan.Visible = true;

                string mesaj = "--- 🎬 KATEGORİ BAZLI TURNUVA SONUÇLARI 🎬 ---\n\n";

                foreach (var item in kategoriSampiyonlari)
                {
                    mesaj += $"🎭 Kategori: {item.KategoriAdi}\n";
                    mesaj += $"🥇 Şampiyon: {item.SampiyonFilm.Film.FilmAdi} ({item.SampiyonFilm.OySayisi} Oy)\n\n";
                }

                MessageBox.Show(mesaj, "Turnuva Raporu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Raporlama sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void combo_Adaylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_KazananFilm.Visible = false;
                pictureBox_Kazanan.Visible = false;

                YesilYol.Visible = false;
                interstellar.Visible = false;
                Deadpool.Visible = false;
                UmudunuKaybetme.Visible = false;
                MadMax.Visible = false;
                inception.Visible = false;
                BladeRunner.Visible = false;

                string secilenFilm = combo_Adaylar.Text;

                if (secilenFilm == "Yeşil Yol") YesilYol.Visible = true;
                else if (secilenFilm == "Interstellar") interstellar.Visible = true;
                else if (secilenFilm == "Deadpool") Deadpool.Visible = true;
                else if (secilenFilm == "Umudunu Kaybetme") UmudunuKaybetme.Visible = true;
                else if (secilenFilm == "Mad Max: Fury Road") MadMax.Visible = true;
                else if (secilenFilm == "Inception") inception.Visible = true;
                else if (secilenFilm == "Blade Runner 2049") BladeRunner.Visible = true;
            }
            catch (Exception)
            {

            }
        }
    }
}