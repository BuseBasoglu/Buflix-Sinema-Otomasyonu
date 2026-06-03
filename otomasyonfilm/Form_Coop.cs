using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace otomasyonfilm
{
    public partial class Form_Coop : Form
    {
        OtomasyonFilmDbContext db = new OtomasyonFilmDbContext();
        int seciliOdaId = -1;

        public Form_Coop()
        {
            InitializeComponent();
        }

        private void Form_Coop_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            try
            {
                combo_Filmler.DataSource = db.Filmler.ToList();
                combo_Filmler.DisplayMember = "FilmAdi";
                combo_Filmler.ValueMember = "Film_Id";

                combo_AktifKullanici.DataSource = db.Kullanicilar.Select(k => new
                {
                    k.Kullanici_Id,
                    AdSoyad = k.Ad + " " + k.Soyad
                }).ToList();
                combo_AktifKullanici.DisplayMember = "AdSoyad";
                combo_AktifKullanici.ValueMember = "Kullanici_Id";

                OdalariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OdalariListele()
        {
            try
            {
                var odalar = db.IzlemeOdalari
                    .Include(o => o.Film)
                    .Include(o => o.KurucuKullanici)
                    .Select(o => new
                    {
                        o.Oda_Id,
                        OdaAdi = o.OdaAdi,
                        Film = o.Film.FilmAdi,
                        Kurucu = o.KurucuKullanici.Ad + " " + o.KurucuKullanici.Soyad,
                        Tarih = o.IzlemeTarihi
                    }).ToList();

                dataGridView_Odalar.DataSource = odalar;

                dataGridView_Odalar.Columns["Oda_Id"].Visible = false;
                dataGridView_Odalar.Columns["OdaAdi"].HeaderText = "Oda Adı";
                dataGridView_Odalar.Columns["Film"].HeaderText = "Film Adı";
                dataGridView_Odalar.Columns["Kurucu"].HeaderText = "Kurucu";
                dataGridView_Odalar.Columns["Tarih"].HeaderText = "Tarih";

                dataGridView_Odalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oda listeleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_OdaKur_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_OdaAdi.Text))
                {
                    MessageBox.Show("Lütfen bir oda adı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (combo_Filmler.SelectedValue == null || combo_AktifKullanici.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen film ve kurucu seçimlerini yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                IzlemeOdasi yeniOda = new IzlemeOdasi
                {
                    OdaAdi = txt_OdaAdi.Text,
                    Film_Id = (int)combo_Filmler.SelectedValue,
                    Kurucu_Id = (int)combo_AktifKullanici.SelectedValue,
                    IzlemeTarihi = DateTime.Now
                };

                db.IzlemeOdalari.Add(yeniOda);
                db.SaveChanges();

                MessageBox.Show("İzleme odası başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_OdaAdi.Clear();
                OdalariListele();
            }
            catch (Exception ex)
            {
                string gercekHata = ex.Message;
                if (ex.InnerException != null)
                {
                    gercekHata = ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                    {
                        gercekHata = ex.InnerException.InnerException.Message;
                    }
                }
                MessageBox.Show($"Oda kurma işlemi başarısız: {gercekHata}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_OdaKapat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_Odalar.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen kapatmak (silmek) istediğiniz odayı tablodan seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dataGridView_Odalar.CurrentRow.Cells["Oda_Id"].Value);
                var silinecekOda = db.IzlemeOdalari.Find(id);

                if (silinecekOda != null)
                {
                    int aktifKullaniciId = (int)combo_AktifKullanici.SelectedValue;
                    if (silinecekOda.Kurucu_Id != aktifKullaniciId)
                    {
                        MessageBox.Show("Bu odayı sadece odayı kuran kişi kapatabilir!", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult sonuc = MessageBox.Show("Seçili odayı ve içindeki tüm sohbetleri silmek istediğinize emin misiniz?", "Oda Kapatma Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (sonuc == DialogResult.Yes)
                    {
                        var mesajlar = db.OdaMesajlari.Where(m => m.Oda_Id == id).ToList();
                        db.OdaMesajlari.RemoveRange(mesajlar);

                        db.IzlemeOdalari.Remove(silinecekOda);
                        db.SaveChanges();

                        MessageBox.Show("Oda başarıyla kapatıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OdalariListele();
                        listBox_Sohbet.Items.Clear();
                        listBox_Katilimcilar.Items.Clear();
                        seciliOdaId = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oda kapatma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_OdayaGir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_Odalar.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen girmek istediğiniz odayı tablodan seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (combo_AktifKullanici.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen odaya girecek aktif kullanıcıyı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                seciliOdaId = Convert.ToInt32(dataGridView_Odalar.CurrentRow.Cells["Oda_Id"].Value);

                OdaMesaj katilmaMesaji = new OdaMesaj
                {
                    Oda_Id = seciliOdaId,
                    Kullanici_Id = (int)combo_AktifKullanici.SelectedValue,
                    MesajMetni = "Odaya katıldı.",
                    GonderimZamani = DateTime.Now
                };

                db.OdaMesajlari.Add(katilmaMesaji);
                db.SaveChanges();

                SohbetiYukle();
                KatilimcilariYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Odaya giriş hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Odalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    seciliOdaId = Convert.ToInt32(dataGridView_Odalar.Rows[e.RowIndex].Cells["Oda_Id"].Value);
                    SohbetiYukle();
                    KatilimcilariYukle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SohbetiYukle()
        {
            try
            {
                listBox_Sohbet.Items.Clear();

                if (seciliOdaId == -1) return;

                var mesajlar = db.OdaMesajlari
                    .Include(m => m.GonderenKullanici)
                    .Where(m => m.Oda_Id == seciliOdaId)
                    .OrderBy(m => m.GonderimZamani)
                    .ToList();

                foreach (var m in mesajlar)
                {
                    string gonderenAdSoyad = m.GonderenKullanici.Ad + " " + m.GonderenKullanici.Soyad;
                    listBox_Sohbet.Items.Add($"[{m.GonderimZamani.ToShortTimeString()}] {gonderenAdSoyad}: {m.MesajMetni}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sohbet yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KatilimcilariYukle()
        {
            try
            {
                listBox_Katilimcilar.Items.Clear();

                if (seciliOdaId == -1) return;

                var oda = db.IzlemeOdalari
                    .Include(o => o.KurucuKullanici)
                    .FirstOrDefault(o => o.Oda_Id == seciliOdaId);

                if (oda != null)
                {
                    listBox_Katilimcilar.Items.Add("👑 " + oda.KurucuKullanici.Ad + " " + oda.KurucuKullanici.Soyad);

                    var mesajGonderenler = db.OdaMesajlari
                        .Include(m => m.GonderenKullanici)
                        .Where(m => m.Oda_Id == seciliOdaId && m.Kullanici_Id != oda.Kurucu_Id)
                        .Select(m => m.GonderenKullanici.Ad + " " + m.GonderenKullanici.Soyad)
                        .Distinct()
                        .ToList();

                    foreach (var kisi in mesajGonderenler)
                    {
                        listBox_Katilimcilar.Items.Add("👤 " + kisi);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Katılımcı yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliOdaId == -1)
                {
                    MessageBox.Show("Lütfen listeden işlem yapılacak odayı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_Mesaj.Text))
                {
                    MessageBox.Show("Gönderilecek mesaj boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OdaMesaj yeniMesaj = new OdaMesaj
                {
                    Oda_Id = seciliOdaId,
                    Kullanici_Id = (int)combo_AktifKullanici.SelectedValue,
                    MesajMetni = txt_Mesaj.Text,
                    GonderimZamani = DateTime.Now
                };

                db.OdaMesajlari.Add(yeniMesaj);
                db.SaveChanges();

                txt_Mesaj.Clear();
                SohbetiYukle();
                KatilimcilariYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mesaj gönderme başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            catch (Exception)
            {
            }
        }
    }
}