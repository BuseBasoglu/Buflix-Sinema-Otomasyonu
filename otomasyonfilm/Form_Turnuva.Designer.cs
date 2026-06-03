namespace otomasyonfilm
{
    partial class Form_Turnuva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Turnuva));
            this.dataGridView_Turnuva = new System.Windows.Forms.DataGridView();
            this.combo_Adaylar = new System.Windows.Forms.ComboBox();
            this.btn_OyVer = new System.Windows.Forms.Button();
            this.btn_Sonuclandir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Kazanan = new System.Windows.Forms.PictureBox();
            this.lbl_KazananFilm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_AktifKullanici = new System.Windows.Forms.ComboBox();
            this.BladeRunner = new System.Windows.Forms.PictureBox();
            this.inception = new System.Windows.Forms.PictureBox();
            this.MadMax = new System.Windows.Forms.PictureBox();
            this.UmudunuKaybetme = new System.Windows.Forms.PictureBox();
            this.Deadpool = new System.Windows.Forms.PictureBox();
            this.interstellar = new System.Windows.Forms.PictureBox();
            this.YesilYol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Turnuva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Kazanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BladeRunner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inception)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MadMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UmudunuKaybetme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deadpool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interstellar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YesilYol)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Turnuva
            // 
            this.dataGridView_Turnuva.AllowUserToAddRows = false;
            this.dataGridView_Turnuva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Turnuva.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView_Turnuva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Turnuva.Location = new System.Drawing.Point(64, 12);
            this.dataGridView_Turnuva.Name = "dataGridView_Turnuva";
            this.dataGridView_Turnuva.ReadOnly = true;
            this.dataGridView_Turnuva.RowHeadersVisible = false;
            this.dataGridView_Turnuva.RowHeadersWidth = 51;
            this.dataGridView_Turnuva.RowTemplate.Height = 24;
            this.dataGridView_Turnuva.Size = new System.Drawing.Size(539, 228);
            this.dataGridView_Turnuva.TabIndex = 0;
            // 
            // combo_Adaylar
            // 
            this.combo_Adaylar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_Adaylar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_Adaylar.FormattingEnabled = true;
            this.combo_Adaylar.Location = new System.Drawing.Point(141, 262);
            this.combo_Adaylar.Name = "combo_Adaylar";
            this.combo_Adaylar.Size = new System.Drawing.Size(160, 28);
            this.combo_Adaylar.TabIndex = 1;
            this.combo_Adaylar.SelectedIndexChanged += new System.EventHandler(this.combo_Adaylar_SelectedIndexChanged);
            // 
            // btn_OyVer
            // 
            this.btn_OyVer.BackColor = System.Drawing.Color.Thistle;
            this.btn_OyVer.FlatAppearance.BorderSize = 0;
            this.btn_OyVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OyVer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OyVer.Location = new System.Drawing.Point(62, 346);
            this.btn_OyVer.Name = "btn_OyVer";
            this.btn_OyVer.Size = new System.Drawing.Size(127, 42);
            this.btn_OyVer.TabIndex = 2;
            this.btn_OyVer.Text = "Oy Ver";
            this.btn_OyVer.UseVisualStyleBackColor = false;
            this.btn_OyVer.Click += new System.EventHandler(this.btn_OyVer_Click);
            // 
            // btn_Sonuclandir
            // 
            this.btn_Sonuclandir.BackColor = System.Drawing.Color.Thistle;
            this.btn_Sonuclandir.FlatAppearance.BorderSize = 0;
            this.btn_Sonuclandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sonuclandir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sonuclandir.Location = new System.Drawing.Point(204, 346);
            this.btn_Sonuclandir.Name = "btn_Sonuclandir";
            this.btn_Sonuclandir.Size = new System.Drawing.Size(127, 42);
            this.btn_Sonuclandir.TabIndex = 3;
            this.btn_Sonuclandir.Text = "Sonuçlandır";
            this.btn_Sonuclandir.UseVisualStyleBackColor = false;
            this.btn_Sonuclandir.Click += new System.EventHandler(this.btn_Sonuclandir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Adaylar :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::otomasyonfilm.Properties.Resources.LOGO_BUFLIX;
            this.pictureBox1.Location = new System.Drawing.Point(53, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_Kazanan
            // 
            this.pictureBox_Kazanan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Kazanan.Location = new System.Drawing.Point(384, 301);
            this.pictureBox_Kazanan.Name = "pictureBox_Kazanan";
            this.pictureBox_Kazanan.Size = new System.Drawing.Size(220, 230);
            this.pictureBox_Kazanan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Kazanan.TabIndex = 36;
            this.pictureBox_Kazanan.TabStop = false;
            this.pictureBox_Kazanan.Visible = false;
            // 
            // lbl_KazananFilm
            // 
            this.lbl_KazananFilm.AutoSize = true;
            this.lbl_KazananFilm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KazananFilm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_KazananFilm.Location = new System.Drawing.Point(397, 270);
            this.lbl_KazananFilm.Name = "lbl_KazananFilm";
            this.lbl_KazananFilm.Size = new System.Drawing.Size(44, 16);
            this.lbl_KazananFilm.TabIndex = 37;
            this.lbl_KazananFilm.Text = "label1";
            this.lbl_KazananFilm.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Aktif Kullanıcı :";
            // 
            // combo_AktifKullanici
            // 
            this.combo_AktifKullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_AktifKullanici.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_AktifKullanici.FormattingEnabled = true;
            this.combo_AktifKullanici.Location = new System.Drawing.Point(141, 301);
            this.combo_AktifKullanici.Name = "combo_AktifKullanici";
            this.combo_AktifKullanici.Size = new System.Drawing.Size(160, 28);
            this.combo_AktifKullanici.TabIndex = 38;
            // 
            // BladeRunner
            // 
            this.BladeRunner.BackColor = System.Drawing.Color.Transparent;
            this.BladeRunner.Image = global::otomasyonfilm.Properties.Resources.bladerunner;
            this.BladeRunner.Location = new System.Drawing.Point(400, 259);
            this.BladeRunner.Name = "BladeRunner";
            this.BladeRunner.Size = new System.Drawing.Size(182, 272);
            this.BladeRunner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BladeRunner.TabIndex = 46;
            this.BladeRunner.TabStop = false;
            this.BladeRunner.Visible = false;
            // 
            // inception
            // 
            this.inception.BackColor = System.Drawing.Color.Transparent;
            this.inception.Image = global::otomasyonfilm.Properties.Resources.inception;
            this.inception.Location = new System.Drawing.Point(400, 259);
            this.inception.Name = "inception";
            this.inception.Size = new System.Drawing.Size(182, 272);
            this.inception.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inception.TabIndex = 45;
            this.inception.TabStop = false;
            this.inception.Visible = false;
            // 
            // MadMax
            // 
            this.MadMax.BackColor = System.Drawing.Color.Transparent;
            this.MadMax.Image = global::otomasyonfilm.Properties.Resources._477217;
            this.MadMax.Location = new System.Drawing.Point(400, 259);
            this.MadMax.Name = "MadMax";
            this.MadMax.Size = new System.Drawing.Size(182, 272);
            this.MadMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MadMax.TabIndex = 44;
            this.MadMax.TabStop = false;
            this.MadMax.Visible = false;
            // 
            // UmudunuKaybetme
            // 
            this.UmudunuKaybetme.BackColor = System.Drawing.Color.Transparent;
            this.UmudunuKaybetme.Image = global::otomasyonfilm.Properties.Resources.umudunu_kaybetme;
            this.UmudunuKaybetme.Location = new System.Drawing.Point(400, 259);
            this.UmudunuKaybetme.Name = "UmudunuKaybetme";
            this.UmudunuKaybetme.Size = new System.Drawing.Size(182, 272);
            this.UmudunuKaybetme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UmudunuKaybetme.TabIndex = 43;
            this.UmudunuKaybetme.TabStop = false;
            this.UmudunuKaybetme.Visible = false;
            // 
            // Deadpool
            // 
            this.Deadpool.BackColor = System.Drawing.Color.Transparent;
            this.Deadpool.Image = global::otomasyonfilm.Properties.Resources._71995f6864395a3aafee44d4fb73c467_ryan_reynolds_marvel_dc;
            this.Deadpool.Location = new System.Drawing.Point(400, 259);
            this.Deadpool.Name = "Deadpool";
            this.Deadpool.Size = new System.Drawing.Size(182, 272);
            this.Deadpool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Deadpool.TabIndex = 42;
            this.Deadpool.TabStop = false;
            this.Deadpool.Visible = false;
            // 
            // interstellar
            // 
            this.interstellar.BackColor = System.Drawing.Color.Transparent;
            this.interstellar.Image = global::otomasyonfilm.Properties.Resources.fullhd_yildizlararasi_fullhd_izle_xl;
            this.interstellar.Location = new System.Drawing.Point(400, 259);
            this.interstellar.Name = "interstellar";
            this.interstellar.Size = new System.Drawing.Size(182, 272);
            this.interstellar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.interstellar.TabIndex = 41;
            this.interstellar.TabStop = false;
            this.interstellar.Visible = false;
            // 
            // YesilYol
            // 
            this.YesilYol.BackColor = System.Drawing.Color.Transparent;
            this.YesilYol.Image = global::otomasyonfilm.Properties.Resources.YesilYol;
            this.YesilYol.Location = new System.Drawing.Point(400, 259);
            this.YesilYol.Name = "YesilYol";
            this.YesilYol.Size = new System.Drawing.Size(182, 272);
            this.YesilYol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YesilYol.TabIndex = 40;
            this.YesilYol.TabStop = false;
            this.YesilYol.Visible = false;
            // 
            // Form_Turnuva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::otomasyonfilm.Properties.Resources.arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 555);
            this.Controls.Add(this.combo_AktifKullanici);
            this.Controls.Add(this.lbl_KazananFilm);
            this.Controls.Add(this.pictureBox_Kazanan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Sonuclandir);
            this.Controls.Add(this.btn_OyVer);
            this.Controls.Add(this.combo_Adaylar);
            this.Controls.Add(this.dataGridView_Turnuva);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BladeRunner);
            this.Controls.Add(this.inception);
            this.Controls.Add(this.MadMax);
            this.Controls.Add(this.UmudunuKaybetme);
            this.Controls.Add(this.Deadpool);
            this.Controls.Add(this.interstellar);
            this.Controls.Add(this.YesilYol);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Turnuva";
            this.Text = "Haftanın Film Turnuvası";
            this.Load += new System.EventHandler(this.Form_Turnuva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Turnuva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Kazanan)).EndInit();
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

        private System.Windows.Forms.DataGridView dataGridView_Turnuva;
        private System.Windows.Forms.ComboBox combo_Adaylar;
        private System.Windows.Forms.Button btn_OyVer;
        private System.Windows.Forms.Button btn_Sonuclandir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_Kazanan;
        private System.Windows.Forms.Label lbl_KazananFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_AktifKullanici;
        private System.Windows.Forms.PictureBox BladeRunner;
        private System.Windows.Forms.PictureBox inception;
        private System.Windows.Forms.PictureBox MadMax;
        private System.Windows.Forms.PictureBox UmudunuKaybetme;
        private System.Windows.Forms.PictureBox Deadpool;
        private System.Windows.Forms.PictureBox interstellar;
        private System.Windows.Forms.PictureBox YesilYol;
    }
}