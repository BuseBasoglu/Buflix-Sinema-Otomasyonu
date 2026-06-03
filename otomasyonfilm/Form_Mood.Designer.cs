namespace otomasyonfilm
{
    partial class Form_Mood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Mood));
            this.combo_RuhHali = new System.Windows.Forms.ComboBox();
            this.btn_FilmOner = new System.Windows.Forms.Button();
            this.dataGridView_Oneriler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Oneriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_RuhHali
            // 
            this.combo_RuhHali.BackColor = System.Drawing.Color.Thistle;
            this.combo_RuhHali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_RuhHali.FormattingEnabled = true;
            this.combo_RuhHali.Items.AddRange(new object[] {
            "Kafa Dağıtmalık",
            "Ters Köşe Yapan",
            "Arka Planda Çalsın",
            "Beyin Yakan",
            "Karanlık ve Distopik",
            "Adrenalin Pompası",
            "İç Isıtan",
            "Motive Edici"});
            this.combo_RuhHali.Location = new System.Drawing.Point(123, 14);
            this.combo_RuhHali.Name = "combo_RuhHali";
            this.combo_RuhHali.Size = new System.Drawing.Size(163, 24);
            this.combo_RuhHali.TabIndex = 0;
            this.combo_RuhHali.SelectedIndexChanged += new System.EventHandler(this.combo_RuhHali_SelectedIndexChanged);
            // 
            // btn_FilmOner
            // 
            this.btn_FilmOner.BackColor = System.Drawing.Color.Thistle;
            this.btn_FilmOner.FlatAppearance.BorderSize = 0;
            this.btn_FilmOner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_FilmOner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FilmOner.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_FilmOner.Location = new System.Drawing.Point(123, 66);
            this.btn_FilmOner.Name = "btn_FilmOner";
            this.btn_FilmOner.Size = new System.Drawing.Size(116, 41);
            this.btn_FilmOner.TabIndex = 1;
            this.btn_FilmOner.Text = "Öner";
            this.btn_FilmOner.UseVisualStyleBackColor = false;
            this.btn_FilmOner.Click += new System.EventHandler(this.btn_FilmOner_Click_1);
            // 
            // dataGridView_Oneriler
            // 
            this.dataGridView_Oneriler.AllowUserToAddRows = false;
            this.dataGridView_Oneriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Oneriler.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView_Oneriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Oneriler.Location = new System.Drawing.Point(292, 12);
            this.dataGridView_Oneriler.Name = "dataGridView_Oneriler";
            this.dataGridView_Oneriler.ReadOnly = true;
            this.dataGridView_Oneriler.RowHeadersVisible = false;
            this.dataGridView_Oneriler.RowHeadersWidth = 51;
            this.dataGridView_Oneriler.RowTemplate.Height = 24;
            this.dataGridView_Oneriler.Size = new System.Drawing.Size(496, 361);
            this.dataGridView_Oneriler.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Film Öner :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ruh Hali :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::otomasyonfilm.Properties.Resources.LOGO_BUFLIX;
            this.pictureBox1.Location = new System.Drawing.Point(-60, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.Thistle;
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(123, 113);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(116, 41);
            this.btn_geri.TabIndex = 36;
            this.btn_geri.Text = "Geri Dön";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Form_Mood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::otomasyonfilm.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.dataGridView_Oneriler);
            this.Controls.Add(this.btn_FilmOner);
            this.Controls.Add(this.combo_RuhHali);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Mood";
            this.Text = "Ruh Haline Göre Film Öner";
            this.Load += new System.EventHandler(this.Form_Mood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Oneriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_RuhHali;
        private System.Windows.Forms.Button btn_FilmOner;
        private System.Windows.Forms.DataGridView dataGridView_Oneriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_geri;
    }
}