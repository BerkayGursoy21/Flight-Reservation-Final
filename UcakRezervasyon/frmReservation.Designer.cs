namespace UcakRezervasyon
{
    partial class frmReservation
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
            comboUcak = new ComboBox();
            lblUcak = new Label();
            comboLokasyon = new ComboBox();
            lblLokasyon = new Label();
            lblTarih = new Label();
            dtpTarih = new DateTimePicker();
            grupUcus = new GroupBox();
            grupMusteri = new GroupBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            lblSoyad = new Label();
            lblCinsiyet = new Label();
            comboCinsiyet = new ComboBox();
            lblAd = new Label();
            lblTCKimlikNo = new Label();
            txtTCKimlikNo = new MaskedTextBox();
            dataGridViewRezervasyon = new DataGridView();
            panelDuzen = new Panel();
            btnKaydet = new Button();
            grupUcus.SuspendLayout();
            grupMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRezervasyon).BeginInit();
            SuspendLayout();
            // 
            // comboUcak
            // 
            comboUcak.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUcak.FormattingEnabled = true;
            comboUcak.IntegralHeight = false;
            comboUcak.Location = new Point(82, 23);
            comboUcak.MaxDropDownItems = 4;
            comboUcak.Name = "comboUcak";
            comboUcak.Size = new Size(200, 25);
            comboUcak.TabIndex = 3;
            // 
            // lblUcak
            // 
            lblUcak.AutoSize = true;
            lblUcak.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUcak.ForeColor = Color.White;
            lblUcak.Location = new Point(6, 25);
            lblUcak.Name = "lblUcak";
            lblUcak.Size = new Size(53, 21);
            lblUcak.TabIndex = 0;
            lblUcak.Text = "Uçak:";
            // 
            // comboLokasyon
            // 
            comboLokasyon.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLokasyon.FormattingEnabled = true;
            comboLokasyon.IntegralHeight = false;
            comboLokasyon.Location = new Point(391, 22);
            comboLokasyon.MaxDropDownItems = 4;
            comboLokasyon.Name = "comboLokasyon";
            comboLokasyon.Size = new Size(300, 25);
            comboLokasyon.TabIndex = 4;
            // 
            // lblLokasyon
            // 
            lblLokasyon.AutoSize = true;
            lblLokasyon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLokasyon.ForeColor = Color.White;
            lblLokasyon.Location = new Point(299, 22);
            lblLokasyon.Name = "lblLokasyon";
            lblLokasyon.Size = new Size(86, 21);
            lblLokasyon.TabIndex = 1;
            lblLokasyon.Text = "Lokasyon:";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTarih.ForeColor = Color.White;
            lblTarih.Location = new Point(697, 22);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(52, 21);
            lblTarih.TabIndex = 2;
            lblTarih.Text = "Tarih:";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(767, 22);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(200, 25);
            dtpTarih.TabIndex = 5;
            dtpTarih.Value = new DateTime(2024, 6, 5, 20, 12, 52, 172);
            // 
            // grupUcus
            // 
            grupUcus.Controls.Add(comboUcak);
            grupUcus.Controls.Add(dtpTarih);
            grupUcus.Controls.Add(lblTarih);
            grupUcus.Controls.Add(lblUcak);
            grupUcus.Controls.Add(lblLokasyon);
            grupUcus.Controls.Add(comboLokasyon);
            grupUcus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grupUcus.ForeColor = Color.White;
            grupUcus.Location = new Point(12, 73);
            grupUcus.Name = "grupUcus";
            grupUcus.Size = new Size(973, 55);
            grupUcus.TabIndex = 1;
            grupUcus.TabStop = false;
            grupUcus.Text = "Uçuş Bilgisi";
            // 
            // grupMusteri
            // 
            grupMusteri.Controls.Add(txtSoyad);
            grupMusteri.Controls.Add(txtAd);
            grupMusteri.Controls.Add(lblSoyad);
            grupMusteri.Controls.Add(lblCinsiyet);
            grupMusteri.Controls.Add(comboCinsiyet);
            grupMusteri.Controls.Add(lblAd);
            grupMusteri.Controls.Add(lblTCKimlikNo);
            grupMusteri.Controls.Add(txtTCKimlikNo);
            grupMusteri.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grupMusteri.ForeColor = Color.White;
            grupMusteri.Location = new Point(12, 12);
            grupMusteri.Name = "grupMusteri";
            grupMusteri.Size = new Size(967, 55);
            grupMusteri.TabIndex = 0;
            grupMusteri.TabStop = false;
            grupMusteri.Text = "Müşteri Bilgisi";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(541, 23);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(150, 25);
            txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(320, 24);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(150, 25);
            txtAd.TabIndex = 5;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSoyad.ForeColor = Color.White;
            lblSoyad.Location = new Point(474, 24);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(61, 21);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad:";
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCinsiyet.ForeColor = Color.White;
            lblCinsiyet.Location = new Point(697, 22);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(75, 21);
            lblCinsiyet.TabIndex = 3;
            lblCinsiyet.Text = "Cinsiyet:";
            // 
            // comboCinsiyet
            // 
            comboCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCinsiyet.FormattingEnabled = true;
            comboCinsiyet.IntegralHeight = false;
            comboCinsiyet.Items.AddRange(new object[] { "", "Kadın", "Erkek" });
            comboCinsiyet.Location = new Point(778, 22);
            comboCinsiyet.MaxDropDownItems = 4;
            comboCinsiyet.Name = "comboCinsiyet";
            comboCinsiyet.Size = new Size(150, 25);
            comboCinsiyet.TabIndex = 7;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAd.ForeColor = Color.White;
            lblAd.Location = new Point(279, 26);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(35, 21);
            lblAd.TabIndex = 1;
            lblAd.Text = "Ad:";
            // 
            // lblTCKimlikNo
            // 
            lblTCKimlikNo.AutoSize = true;
            lblTCKimlikNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTCKimlikNo.ForeColor = Color.White;
            lblTCKimlikNo.Location = new Point(6, 25);
            lblTCKimlikNo.Name = "lblTCKimlikNo";
            lblTCKimlikNo.Size = new Size(120, 21);
            lblTCKimlikNo.TabIndex = 0;
            lblTCKimlikNo.Text = "T.C. Kimlik No:";
            // 
            // txtTCKimlikNo
            // 
            txtTCKimlikNo.Location = new Point(132, 23);
            txtTCKimlikNo.Mask = "00000000000";
            txtTCKimlikNo.Name = "txtTCKimlikNo";
            txtTCKimlikNo.Size = new Size(150, 25);
            txtTCKimlikNo.TabIndex = 4;
            txtTCKimlikNo.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewRezervasyon
            // 
            dataGridViewRezervasyon.AllowUserToAddRows = false;
            dataGridViewRezervasyon.AllowUserToDeleteRows = false;
            dataGridViewRezervasyon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRezervasyon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewRezervasyon.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewRezervasyon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRezervasyon.Location = new Point(12, 134);
            dataGridViewRezervasyon.Name = "dataGridViewRezervasyon";
            dataGridViewRezervasyon.ReadOnly = true;
            dataGridViewRezervasyon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRezervasyon.Size = new Size(1076, 200);
            dataGridViewRezervasyon.TabIndex = 4;
            dataGridViewRezervasyon.DataBindingComplete += dataGridViewRezervasyon_DataBindingComplete;
            // 
            // panelDuzen
            // 
            panelDuzen.Location = new Point(12, 340);
            panelDuzen.Name = "panelDuzen";
            panelDuzen.Size = new Size(1076, 309);
            panelDuzen.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(998, 23);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(97, 55);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // frmReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1107, 661);
            Controls.Add(btnKaydet);
            Controls.Add(grupUcus);
            Controls.Add(panelDuzen);
            Controls.Add(dataGridViewRezervasyon);
            Controls.Add(grupMusteri);
            Name = "frmReservation";
            grupUcus.ResumeLayout(false);
            grupUcus.PerformLayout();
            grupMusteri.ResumeLayout(false);
            grupMusteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRezervasyon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboUcak;
        private Label lblUcak;
        private ComboBox comboLokasyon;
        private Label lblLokasyon;
        private Label lblTarih;
        private DateTimePicker dtpTarih;
        private GroupBox grupUcus;
        private GroupBox grupMusteri;
        private Label lblTCKimlikNo;
        private MaskedTextBox txtTCKimlikNo;
        private Label lblSoyad;
        private Label lblCinsiyet;
        private ComboBox comboCinsiyet;
        private Label lblAd;
        private DataGridView dataGridViewRezervasyon;
        private Panel panelDuzen;
        private Button btnKaydet;
        private TextBox txtSoyad;
        private TextBox txtAd;
    }
}