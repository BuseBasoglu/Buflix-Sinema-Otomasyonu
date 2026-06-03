namespace otomasyonfilm
{
    partial class Form_Coop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Odalar = new System.Windows.Forms.DataGridView();
            this.txt_OdaAdi = new System.Windows.Forms.TextBox();
            this.combo_Filmler = new System.Windows.Forms.ComboBox();
            this.btn_OdaKur = new System.Windows.Forms.Button();
            this.listBox_Sohbet = new System.Windows.Forms.ListBox();
            this.combo_AktifKullanici = new System.Windows.Forms.ComboBox();
            this.txt_Mesaj = new System.Windows.Forms.TextBox();
            this.btn_Gonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BladeRunner = new System.Windows.Forms.PictureBox();
            this.inception = new System.Windows.Forms.PictureBox();
            this.MadMax = new System.Windows.Forms.PictureBox();
            this.UmudunuKaybetme = new System.Windows.Forms.PictureBox();
            this.Deadpool = new System.Windows.Forms.PictureBox();
            this.interstellar = new System.Windows.Forms.PictureBox();
            this.YesilYol = new System.Windows.Forms.PictureBox();
            this.btn_OdaKapat = new System.Windows.Forms.Button();
            this.btn_OdayaGir = new System.Windows.Forms.Button();
            this.listBox_Katilimcilar = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Odalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BladeRunner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inception)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MadMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UmudunuKaybetme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deadpool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interstellar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YesilYol)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Odalar
            // 
            this.dataGridView_Odalar.AllowUserToAddRows = false;
            this.dataGridView_Odalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Odalar.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView_Odalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Odalar.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Odalar.Name = "dataGridView_Odalar";
            this.dataGridView_Odalar.ReadOnly = true;
            this.dataGridView_Odalar.RowHeadersVisible = false;
            this.dataGridView_Odalar.RowHeadersWidth = 51;
            this.dataGridView_Odalar.RowTemplate.Height = 24;
            this.dataGridView_Odalar.Size = new System.Drawing.Size(710, 361);
            this.dataGridView_Odalar.TabIndex = 0;
            this.dataGridView_Odalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Odalar_CellClick);
            // 
            // txt_OdaAdi
            // 
            this.txt_OdaAdi.BackColor = System.Drawing.Color.Thistle;
            this.txt_OdaAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OdaAdi.Location = new System.Drawing.Point(874, 25);
            this.txt_OdaAdi.Name = "txt_OdaAdi";
            this.txt_OdaAdi.Size = new System.Drawing.Size(199, 22);
            this.txt_OdaAdi.TabIndex = 1;
            // 
            // combo_Filmler
            // 
            this.combo_Filmler.BackColor = System.Drawing.Color.Thistle;
            this.combo_Filmler.FormattingEnabled = true;
            this.combo_Filmler.Location = new System.Drawing.Point(874, 57);
            this.combo_Filmler.Name = "combo_Filmler";
            this.combo_Filmler.Size = new System.Drawing.Size(199, 24);
            this.combo_Filmler.TabIndex = 2;
            this.combo_Filmler.SelectedIndexChanged += new System.EventHandler(this.combo_Filmler_SelectedIndexChanged);
            // 
            // btn_OdaKur
            // 
            this.btn_OdaKur.BackColor = System.Drawing.Color.Thistle;
            this.btn_OdaKur.FlatAppearance.BorderSize = 0;
            this.btn_OdaKur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OdaKur.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OdaKur.Location = new System.Drawing.Point(807, 131);
            this.btn_OdaKur.Name = "btn_OdaKur";
            this.btn_OdaKur.Size = new System.Drawing.Size(130, 40);
            this.btn_OdaKur.TabIndex = 4;
            this.btn_OdaKur.Text = "Odayı Kur";
            this.btn_OdaKur.UseVisualStyleBackColor = false;
            this.btn_OdaKur.Click += new System.EventHandler(this.btn_OdaKur_Click);
            // 
            // listBox_Sohbet
            // 
            this.listBox_Sohbet.BackColor = System.Drawing.Color.Thistle;
            this.listBox_Sohbet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Sohbet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_Sohbet.FormattingEnabled = true;
            this.listBox_Sohbet.ItemHeight = 23;
            this.listBox_Sohbet.Location = new System.Drawing.Point(229, 404);
            this.listBox_Sohbet.Name = "listBox_Sohbet";
            this.listBox_Sohbet.Size = new System.Drawing.Size(493, 117);
            this.listBox_Sohbet.TabIndex = 5;
            // 
            // combo_AktifKullanici
            // 
            this.combo_AktifKullanici.BackColor = System.Drawing.Color.Thistle;
            this.combo_AktifKullanici.FormattingEnabled = true;
            this.combo_AktifKullanici.Location = new System.Drawing.Point(874, 87);
            this.combo_AktifKullanici.Name = "combo_AktifKullanici";
            this.combo_AktifKullanici.Size = new System.Drawing.Size(199, 24);
            this.combo_AktifKullanici.TabIndex = 6;
            // 
            // txt_Mesaj
            // 
            this.txt_Mesaj.BackColor = System.Drawing.Color.Thistle;
            this.txt_Mesaj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mesaj.Location = new System.Drawing.Point(229, 529);
            this.txt_Mesaj.Name = "txt_Mesaj";
            this.txt_Mesaj.Size = new System.Drawing.Size(493, 22);
            this.txt_Mesaj.TabIndex = 7;
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.BackColor = System.Drawing.Color.Thistle;
            this.btn_Gonder.FlatAppearance.BorderSize = 0;
            this.btn_Gonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gonder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Gonder.Location = new System.Drawing.Point(229, 557);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(121, 30);
            this.btn_Gonder.TabIndex = 8;
            this.btn_Gonder.Text = "Gönder";
            this.btn_Gonder.UseVisualStyleBackColor = false;
            this.btn_Gonder.Click += new System.EventHandler(this.btn_Gonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(788, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Oda Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(799, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filmler :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(746, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Aktif Kullanıcı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(159, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mesaj :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(229, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sohbet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::otomasyonfilm.Properties.Resources.LOGO_BUFLIX;
            this.pictureBox1.Location = new System.Drawing.Point(704, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // BladeRunner
            // 
            this.BladeRunner.BackColor = System.Drawing.Color.Transparent;
            this.BladeRunner.Image = global::otomasyonfilm.Properties.Resources.bladerunner;
            this.BladeRunner.Location = new System.Drawing.Point(-24, 377);
            this.BladeRunner.Name = "BladeRunner";
            this.BladeRunner.Size = new System.Drawing.Size(214, 212);
            this.BladeRunner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BladeRunner.TabIndex = 43;
            this.BladeRunner.TabStop = false;
            this.BladeRunner.Visible = false;
            // 
            // inception
            // 
            this.inception.BackColor = System.Drawing.Color.Transparent;
            this.inception.Image = global::otomasyonfilm.Properties.Resources.inception;
            this.inception.Location = new System.Drawing.Point(-24, 378);
            this.inception.Name = "inception";
            this.inception.Size = new System.Drawing.Size(214, 204);
            this.inception.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inception.TabIndex = 42;
            this.inception.TabStop = false;
            this.inception.Visible = false;
            // 
            // MadMax
            // 
            this.MadMax.BackColor = System.Drawing.Color.Transparent;
            this.MadMax.Image = global::otomasyonfilm.Properties.Resources._477217;
            this.MadMax.Location = new System.Drawing.Point(-24, 378);
            this.MadMax.Name = "MadMax";
            this.MadMax.Size = new System.Drawing.Size(214, 204);
            this.MadMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MadMax.TabIndex = 41;
            this.MadMax.TabStop = false;
            this.MadMax.Visible = false;
            // 
            // UmudunuKaybetme
            // 
            this.UmudunuKaybetme.BackColor = System.Drawing.Color.Transparent;
            this.UmudunuKaybetme.Image = global::otomasyonfilm.Properties.Resources.umudunu_kaybetme;
            this.UmudunuKaybetme.Location = new System.Drawing.Point(-24, 378);
            this.UmudunuKaybetme.Name = "UmudunuKaybetme";
            this.UmudunuKaybetme.Size = new System.Drawing.Size(214, 204);
            this.UmudunuKaybetme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UmudunuKaybetme.TabIndex = 40;
            this.UmudunuKaybetme.TabStop = false;
            this.UmudunuKaybetme.Visible = false;
            // 
            // Deadpool
            // 
            this.Deadpool.BackColor = System.Drawing.Color.Transparent;
            this.Deadpool.Image = global::otomasyonfilm.Properties.Resources._71995f6864395a3aafee44d4fb73c467_ryan_reynolds_marvel_dc;
            this.Deadpool.Location = new System.Drawing.Point(-24, 378);
            this.Deadpool.Name = "Deadpool";
            this.Deadpool.Size = new System.Drawing.Size(214, 204);
            this.Deadpool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Deadpool.TabIndex = 39;
            this.Deadpool.TabStop = false;
            this.Deadpool.Visible = false;
            // 
            // interstellar
            // 
            this.interstellar.BackColor = System.Drawing.Color.Transparent;
            this.interstellar.Image = global::otomasyonfilm.Properties.Resources.fullhd_yildizlararasi_fullhd_izle_xl;
            this.interstellar.Location = new System.Drawing.Point(-24, 378);
            this.interstellar.Name = "interstellar";
            this.interstellar.Size = new System.Drawing.Size(214, 204);
            this.interstellar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.interstellar.TabIndex = 38;
            this.interstellar.TabStop = false;
            this.interstellar.Visible = false;
            // 
            // YesilYol
            // 
            this.YesilYol.BackColor = System.Drawing.Color.Transparent;
            this.YesilYol.Image = global::otomasyonfilm.Properties.Resources.YesilYol;
            this.YesilYol.Location = new System.Drawing.Point(-24, 378);
            this.YesilYol.Name = "YesilYol";
            this.YesilYol.Size = new System.Drawing.Size(214, 204);
            this.YesilYol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YesilYol.TabIndex = 37;
            this.YesilYol.TabStop = false;
            this.YesilYol.Visible = false;
            // 
            // btn_OdaKapat
            // 
            this.btn_OdaKapat.BackColor = System.Drawing.Color.Thistle;
            this.btn_OdaKapat.FlatAppearance.BorderSize = 0;
            this.btn_OdaKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OdaKapat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OdaKapat.Location = new System.Drawing.Point(943, 131);
            this.btn_OdaKapat.Name = "btn_OdaKapat";
            this.btn_OdaKapat.Size = new System.Drawing.Size(130, 40);
            this.btn_OdaKapat.TabIndex = 44;
            this.btn_OdaKapat.Text = "Odayı Kapat";
            this.btn_OdaKapat.UseVisualStyleBackColor = false;
            this.btn_OdaKapat.Click += new System.EventHandler(this.btn_OdaKapat_Click);
            // 
            // btn_OdayaGir
            // 
            this.btn_OdayaGir.BackColor = System.Drawing.Color.Thistle;
            this.btn_OdayaGir.FlatAppearance.BorderSize = 0;
            this.btn_OdayaGir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OdayaGir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OdayaGir.Location = new System.Drawing.Point(807, 177);
            this.btn_OdayaGir.Name = "btn_OdayaGir";
            this.btn_OdayaGir.Size = new System.Drawing.Size(266, 40);
            this.btn_OdayaGir.TabIndex = 45;
            this.btn_OdayaGir.Text = "Odaya Gir";
            this.btn_OdayaGir.UseVisualStyleBackColor = false;
            this.btn_OdayaGir.Click += new System.EventHandler(this.btn_OdayaGir_Click);
            // 
            // listBox_Katilimcilar
            // 
            this.listBox_Katilimcilar.BackColor = System.Drawing.Color.Thistle;
            this.listBox_Katilimcilar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Katilimcilar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_Katilimcilar.FormattingEnabled = true;
            this.listBox_Katilimcilar.ItemHeight = 23;
            this.listBox_Katilimcilar.Location = new System.Drawing.Point(728, 254);
            this.listBox_Katilimcilar.Name = "listBox_Katilimcilar";
            this.listBox_Katilimcilar.Size = new System.Drawing.Size(345, 163);
            this.listBox_Katilimcilar.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(724, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "Katılımcılar";
            // 
            // Form_Coop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::otomasyonfilm.Properties.Resources.arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 602);
            this.Controls.Add(this.txt_Mesaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox_Katilimcilar);
            this.Controls.Add(this.btn_OdayaGir);
            this.Controls.Add(this.btn_OdaKapat);
            this.Controls.Add(this.BladeRunner);
            this.Controls.Add(this.inception);
            this.Controls.Add(this.MadMax);
            this.Controls.Add(this.UmudunuKaybetme);
            this.Controls.Add(this.Deadpool);
            this.Controls.Add(this.interstellar);
            this.Controls.Add(this.YesilYol);
            this.Controls.Add(this.btn_Gonder);
            this.Controls.Add(this.combo_AktifKullanici);
            this.Controls.Add(this.listBox_Sohbet);
            this.Controls.Add(this.btn_OdaKur);
            this.Controls.Add(this.combo_Filmler);
            this.Controls.Add(this.txt_OdaAdi);
            this.Controls.Add(this.dataGridView_Odalar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "Form_Coop";
            this.Text = "Form_Coop";
            this.Load += new System.EventHandler(this.Form_Coop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Odalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BladeRunner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inception)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MadMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UmudunuKaybetme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deadpool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interstellar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YesilYol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Odalar;
        private System.Windows.Forms.TextBox txt_OdaAdi;
        private System.Windows.Forms.ComboBox combo_Filmler;
        private System.Windows.Forms.Button btn_OdaKur;
        private System.Windows.Forms.ListBox listBox_Sohbet;
        private System.Windows.Forms.ComboBox combo_AktifKullanici;
        private System.Windows.Forms.TextBox txt_Mesaj;
        private System.Windows.Forms.Button btn_Gonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BladeRunner;
        private System.Windows.Forms.PictureBox inception;
        private System.Windows.Forms.PictureBox MadMax;
        private System.Windows.Forms.PictureBox UmudunuKaybetme;
        private System.Windows.Forms.PictureBox Deadpool;
        private System.Windows.Forms.PictureBox interstellar;
        private System.Windows.Forms.PictureBox YesilYol;
        private System.Windows.Forms.Button btn_OdaKapat;
        private System.Windows.Forms.Button btn_OdayaGir;
        private System.Windows.Forms.ListBox listBox_Katilimcilar;
        private System.Windows.Forms.Label label3;
    }
}