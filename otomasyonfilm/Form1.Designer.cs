namespace otomasyonfilm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Gecis = new System.Windows.Forms.Button();
            this.btn_MoodFiltresineGit = new System.Windows.Forms.Button();
            this.btn_IncelemelereGit = new System.Windows.Forms.Button();
            this.btn_TurnuvayaGit = new System.Windows.Forms.Button();
            this.btn_CoopOdalaraGit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Telefon = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 599);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1174, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1148, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1140, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1154, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.BackColor = System.Drawing.Color.Thistle;
            this.txt_Ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Ad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ad.Location = new System.Drawing.Point(1213, 25);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(102, 27);
            this.txt_Ad.TabIndex = 5;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.BackColor = System.Drawing.Color.Thistle;
            this.txt_Soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Soyad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Soyad.Location = new System.Drawing.Point(1213, 62);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(102, 27);
            this.txt_Soyad.TabIndex = 6;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.Thistle;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Email.Location = new System.Drawing.Point(1213, 100);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(102, 27);
            this.txt_Email.TabIndex = 7;
            // 
            // btn_Listele
            // 
            this.btn_Listele.BackColor = System.Drawing.Color.Thistle;
            this.btn_Listele.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Listele.FlatAppearance.BorderSize = 0;
            this.btn_Listele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_Listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listele.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Listele.Location = new System.Drawing.Point(1144, 189);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(97, 37);
            this.btn_Listele.TabIndex = 9;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = false;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Thistle;
            this.btn_Sil.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Sil.FlatAppearance.BorderSize = 0;
            this.btn_Sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(1247, 234);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(97, 37);
            this.btn_Sil.TabIndex = 10;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Thistle;
            this.btn_Ekle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Ekle.FlatAppearance.BorderSize = 0;
            this.btn_Ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ekle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(1144, 234);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(97, 37);
            this.btn_Ekle.TabIndex = 11;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.Thistle;
            this.btn_Guncelle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Guncelle.FlatAppearance.BorderSize = 0;
            this.btn_Guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(1247, 189);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(97, 37);
            this.btn_Guncelle.TabIndex = 12;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Gecis
            // 
            this.btn_Gecis.BackColor = System.Drawing.Color.Thistle;
            this.btn_Gecis.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Gecis.FlatAppearance.BorderSize = 0;
            this.btn_Gecis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_Gecis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gecis.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Gecis.Location = new System.Drawing.Point(12, 12);
            this.btn_Gecis.Name = "btn_Gecis";
            this.btn_Gecis.Size = new System.Drawing.Size(207, 40);
            this.btn_Gecis.TabIndex = 13;
            this.btn_Gecis.Text = "İzleme Listesi Yönetimi";
            this.btn_Gecis.UseVisualStyleBackColor = false;
            this.btn_Gecis.Click += new System.EventHandler(this.btn_Gecis_Click);
            // 
            // btn_MoodFiltresineGit
            // 
            this.btn_MoodFiltresineGit.BackColor = System.Drawing.Color.Thistle;
            this.btn_MoodFiltresineGit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_MoodFiltresineGit.FlatAppearance.BorderSize = 0;
            this.btn_MoodFiltresineGit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_MoodFiltresineGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MoodFiltresineGit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_MoodFiltresineGit.Location = new System.Drawing.Point(225, 12);
            this.btn_MoodFiltresineGit.Name = "btn_MoodFiltresineGit";
            this.btn_MoodFiltresineGit.Size = new System.Drawing.Size(243, 40);
            this.btn_MoodFiltresineGit.TabIndex = 14;
            this.btn_MoodFiltresineGit.Text = "Ruh Haline Göre Film Öner";
            this.btn_MoodFiltresineGit.UseVisualStyleBackColor = false;
            this.btn_MoodFiltresineGit.Click += new System.EventHandler(this.btn_MoodFiltresineGit_Click);
            // 
            // btn_IncelemelereGit
            // 
            this.btn_IncelemelereGit.BackColor = System.Drawing.Color.Thistle;
            this.btn_IncelemelereGit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_IncelemelereGit.FlatAppearance.BorderSize = 0;
            this.btn_IncelemelereGit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_IncelemelereGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IncelemelereGit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_IncelemelereGit.Location = new System.Drawing.Point(474, 12);
            this.btn_IncelemelereGit.Name = "btn_IncelemelereGit";
            this.btn_IncelemelereGit.Size = new System.Drawing.Size(225, 40);
            this.btn_IncelemelereGit.TabIndex = 15;
            this.btn_IncelemelereGit.Text = "İncelemeler ve Eleştirmenler";
            this.btn_IncelemelereGit.UseVisualStyleBackColor = false;
            this.btn_IncelemelereGit.Click += new System.EventHandler(this.btn_IncelemelereGit_Click);
            // 
            // btn_TurnuvayaGit
            // 
            this.btn_TurnuvayaGit.BackColor = System.Drawing.Color.Thistle;
            this.btn_TurnuvayaGit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_TurnuvayaGit.FlatAppearance.BorderSize = 0;
            this.btn_TurnuvayaGit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_TurnuvayaGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TurnuvayaGit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_TurnuvayaGit.Location = new System.Drawing.Point(705, 12);
            this.btn_TurnuvayaGit.Name = "btn_TurnuvayaGit";
            this.btn_TurnuvayaGit.Size = new System.Drawing.Size(194, 40);
            this.btn_TurnuvayaGit.TabIndex = 16;
            this.btn_TurnuvayaGit.Text = "Haftanın Film Turnuvası";
            this.btn_TurnuvayaGit.UseVisualStyleBackColor = false;
            this.btn_TurnuvayaGit.Click += new System.EventHandler(this.btn_TurnuvayaGit_Click);
            // 
            // btn_CoopOdalaraGit
            // 
            this.btn_CoopOdalaraGit.BackColor = System.Drawing.Color.Thistle;
            this.btn_CoopOdalaraGit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_CoopOdalaraGit.FlatAppearance.BorderSize = 0;
            this.btn_CoopOdalaraGit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_CoopOdalaraGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CoopOdalaraGit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CoopOdalaraGit.Location = new System.Drawing.Point(905, 12);
            this.btn_CoopOdalaraGit.Name = "btn_CoopOdalaraGit";
            this.btn_CoopOdalaraGit.Size = new System.Drawing.Size(224, 40);
            this.btn_CoopOdalaraGit.TabIndex = 17;
            this.btn_CoopOdalaraGit.Text = "Birlikte İzle (Co-op) Odaları";
            this.btn_CoopOdalaraGit.UseVisualStyleBackColor = false;
            this.btn_CoopOdalaraGit.Click += new System.EventHandler(this.btn_CoopOdalaraGit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::otomasyonfilm.Properties.Resources.LOGO_BUFLIX;
            this.pictureBox1.Location = new System.Drawing.Point(984, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.BackColor = System.Drawing.Color.Thistle;
            this.txt_Telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Telefon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Telefon.Location = new System.Drawing.Point(1213, 139);
            this.txt_Telefon.Mask = "(000) 000 00 00";
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(102, 27);
            this.txt_Telefon.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::otomasyonfilm.Properties.Resources.arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1359, 706);
            this.Controls.Add(this.txt_Telefon);
            this.Controls.Add(this.btn_CoopOdalaraGit);
            this.Controls.Add(this.btn_TurnuvayaGit);
            this.Controls.Add(this.btn_IncelemelereGit);
            this.Controls.Add(this.btn_MoodFiltresineGit);
            this.Controls.Add(this.btn_Gecis);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kullanıcı Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Gecis;
        private System.Windows.Forms.Button btn_MoodFiltresineGit;
        private System.Windows.Forms.Button btn_IncelemelereGit;
        private System.Windows.Forms.Button btn_TurnuvayaGit;
        private System.Windows.Forms.Button btn_CoopOdalaraGit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txt_Telefon;
    }
}

