namespace UcakRezervasyon
{
    partial class frmLocation
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
            btnSil = new Button();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            dataGridViewLokasyon = new DataGridView();
            lblAktifPasif = new Label();
            lblHavaalanı = new Label();
            lblSehir = new Label();
            lblUlke = new Label();
            comboUlke = new ComboBox();
            comboSehir = new ComboBox();
            comboHavaalani = new ComboBox();
            comboAktifPasif = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLokasyon).BeginInit();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.Location = new Point(530, 81);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(70, 29);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(444, 81);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(80, 28);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(366, 81);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(72, 30);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dataGridViewLokasyon
            // 
            dataGridViewLokasyon.AllowUserToAddRows = false;
            dataGridViewLokasyon.AllowUserToDeleteRows = false;
            dataGridViewLokasyon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLokasyon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewLokasyon.BackgroundColor = Color.MintCream;
            dataGridViewLokasyon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLokasyon.Location = new Point(15, 131);
            dataGridViewLokasyon.Name = "dataGridViewLokasyon";
            dataGridViewLokasyon.ReadOnly = true;
            dataGridViewLokasyon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLokasyon.Size = new Size(753, 329);
            dataGridViewLokasyon.TabIndex = 11;
            dataGridViewLokasyon.CellClick += dataGridViewLokasyon_CellClick;
            dataGridViewLokasyon.DataBindingComplete += dataGridViewLokasyon_DataBindingComplete;
            // 
            // lblAktifPasif
            // 
            lblAktifPasif.AutoSize = true;
            lblAktifPasif.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAktifPasif.ForeColor = SystemColors.ButtonFace;
            lblAktifPasif.Location = new Point(15, 86);
            lblAktifPasif.Name = "lblAktifPasif";
            lblAktifPasif.Size = new Size(103, 21);
            lblAktifPasif.TabIndex = 3;
            lblAktifPasif.Text = "Aktif - Pasif:";
            // 
            // lblHavaalanı
            // 
            lblHavaalanı.AutoSize = true;
            lblHavaalanı.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHavaalanı.ForeColor = SystemColors.ButtonFace;
            lblHavaalanı.Location = new Point(271, 23);
            lblHavaalanı.Name = "lblHavaalanı";
            lblHavaalanı.Size = new Size(91, 21);
            lblHavaalanı.TabIndex = 2;
            lblHavaalanı.Text = "Havaalanı:";
            // 
            // lblSehir
            // 
            lblSehir.AutoSize = true;
            lblSehir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSehir.ForeColor = SystemColors.ButtonFace;
            lblSehir.Location = new Point(530, 25);
            lblSehir.Name = "lblSehir";
            lblSehir.Size = new Size(54, 21);
            lblSehir.TabIndex = 1;
            lblSehir.Text = "Şehir:";
            // 
            // lblUlke
            // 
            lblUlke.AutoSize = true;
            lblUlke.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUlke.ForeColor = SystemColors.Control;
            lblUlke.Location = new Point(15, 25);
            lblUlke.Name = "lblUlke";
            lblUlke.Size = new Size(49, 21);
            lblUlke.TabIndex = 0;
            lblUlke.Text = "Ülke:";
            // 
            // comboUlke
            // 
            comboUlke.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUlke.FormattingEnabled = true;
            comboUlke.IntegralHeight = false;
            comboUlke.Location = new Point(70, 25);
            comboUlke.MaxDropDownItems = 4;
            comboUlke.Name = "comboUlke";
            comboUlke.Size = new Size(195, 23);
            comboUlke.TabIndex = 4;
            // 
            // comboSehir
            // 
            comboSehir.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSehir.FormattingEnabled = true;
            comboSehir.IntegralHeight = false;
            comboSehir.Location = new Point(590, 23);
            comboSehir.MaxDropDownItems = 4;
            comboSehir.Name = "comboSehir";
            comboSehir.Size = new Size(150, 23);
            comboSehir.TabIndex = 12;
            // 
            // comboHavaalani
            // 
            comboHavaalani.DropDownStyle = ComboBoxStyle.DropDownList;
            comboHavaalani.FormattingEnabled = true;
            comboHavaalani.IntegralHeight = false;
            comboHavaalani.Location = new Point(366, 23);
            comboHavaalani.MaxDropDownItems = 4;
            comboHavaalani.Name = "comboHavaalani";
            comboHavaalani.Size = new Size(150, 23);
            comboHavaalani.TabIndex = 13;
            // 
            // comboAktifPasif
            // 
            comboAktifPasif.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAktifPasif.FormattingEnabled = true;
            comboAktifPasif.IntegralHeight = false;
            comboAktifPasif.Items.AddRange(new object[] { "", "Aktif", "Pasif" });
            comboAktifPasif.Location = new Point(115, 86);
            comboAktifPasif.MaxDropDownItems = 4;
            comboAktifPasif.Name = "comboAktifPasif";
            comboAktifPasif.Size = new Size(150, 23);
            comboAktifPasif.TabIndex = 14;
            // 
            // frmLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(780, 472);
            Controls.Add(comboAktifPasif);
            Controls.Add(comboHavaalani);
            Controls.Add(comboSehir);
            Controls.Add(comboUlke);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(dataGridViewLokasyon);
            Controls.Add(lblAktifPasif);
            Controls.Add(lblHavaalanı);
            Controls.Add(lblSehir);
            Controls.Add(lblUlke);
            Name = "frmLocation";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLokasyon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSil;
        private Button btnGuncelle;
        private Button btnKaydet;
        private DataGridView dataGridViewLokasyon;
        private Label lblAktifPasif;
        private Label lblHavaalanı;
        private Label lblSehir;
        private Label lblUlke;
        private ComboBox comboUlke;
        private ComboBox comboSehir;
        private ComboBox comboHavaalani;
        private ComboBox comboAktifPasif;
    }
}