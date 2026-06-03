using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace otomasyonfilm
{
    public partial class Form_Mood : Form
    {
        OtomasyonFilmDbContext db = new OtomasyonFilmDbContext();

        public Form_Mood()
        {
            InitializeComponent();
        }

        private void Form_Mood_Load(object sender, EventArgs e)
        {
            try
            {
                if (combo_RuhHali.Items.Count > 0)
                {
                    combo_RuhHali.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_FilmOner_Click(object sender, EventArgs e)
        {
            try
            {
                string secilenMood = combo_RuhHali.Text;

                if (string.IsNullOrWhiteSpace(secilenMood))
                {
                    MessageBox.Show("Lütfen filtreleme için bir ruh hali seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var onerilenFilmler = db.Filmler
                    .Include(f => f.Kategori)
                    .Where(f => f.Mood == secilenMood)
                    .Select(f => new
                    {
                        FilmAdi = f.FilmAdi,
                        KategoriAdi = f.Kategori.KategoriAdi,
                        RuhHali = f.Mood
                    }).ToList();

                if (onerilenFilmler.Count > 0)
                {
                    dataGridView_Oneriler.DataSource = onerilenFilmler;

                    dataGridView_Oneriler.Columns["FilmAdi"].HeaderText = "Önerilen Film";
                    dataGridView_Oneriler.Columns["KategoriAdi"].HeaderText = "Kategori";
                    dataGridView_Oneriler.Columns["RuhHali"].HeaderText = "Ruh Hali Tipi";

                    dataGridView_Oneriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    dataGridView_Oneriler.DataSource = null;
                    MessageBox.Show("Seçilen ruh haline uygun veri bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sorgu hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_FilmOner_Click_1(object sender, EventArgs e)
        {
            btn_FilmOner_Click(sender, e);
        }
        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
        private void combo_RuhHali_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}