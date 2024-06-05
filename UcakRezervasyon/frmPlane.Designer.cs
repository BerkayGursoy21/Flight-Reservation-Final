namespace UcakRezervasyon
{
    partial class frmPlane
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
            lblUcakModel = new Label();
            lblUcakMarka = new Label();
            lblUcakSeriNo = new Label();
            lblUcakKoltukKapasitesi = new Label();
            txtUcakModel = new TextBox();
            txtUcakMarka = new TextBox();
            txtUcakSeriNo = new TextBox();
            txtUcakKoltukKapasitesi = new MaskedTextBox();
            dataGridViewUcak = new DataGridView();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUcak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUcakModel
            // 
            lblUcakModel.AutoSize = true;
            lblUcakModel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblUcakModel.ForeColor = Color.White;
            lblUcakModel.Location = new Point(12, 15);
            lblUcakModel.Name = "lblUcakModel";
            lblUcakModel.Size = new Size(82, 17);
            lblUcakModel.TabIndex = 0;
            lblUcakModel.Text = "Uçak Model:";
            // 
            // lblUcakMarka
            // 
            lblUcakMarka.AutoSize = true;
            lblUcakMarka.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblUcakMarka.ForeColor = Color.White;
            lblUcakMarka.Location = new Point(12, 49);
            lblUcakMarka.Name = "lblUcakMarka";
            lblUcakMarka.Size = new Size(82, 17);
            lblUcakMarka.TabIndex = 1;
            lblUcakMarka.Text = "Uçak Marka:";
            // 
            // lblUcakSeriNo
            // 
            lblUcakSeriNo.AutoSize = true;
            lblUcakSeriNo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblUcakSeriNo.ForeColor = Color.White;
            lblUcakSeriNo.Location = new Point(7, 81);
            lblUcakSeriNo.Name = "lblUcakSeriNo";
            lblUcakSeriNo.Size = new Size(88, 17);
            lblUcakSeriNo.TabIndex = 2;
            lblUcakSeriNo.Text = "Uçak Seri No:";
            // 
            // lblUcakKoltukKapasitesi
            // 
            lblUcakKoltukKapasitesi.AutoSize = true;
            lblUcakKoltukKapasitesi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblUcakKoltukKapasitesi.ForeColor = Color.White;
            lblUcakKoltukKapasitesi.Location = new Point(13, 119);
            lblUcakKoltukKapasitesi.Name = "lblUcakKoltukKapasitesi";
            lblUcakKoltukKapasitesi.Size = new Size(147, 17);
            lblUcakKoltukKapasitesi.TabIndex = 3;
            lblUcakKoltukKapasitesi.Text = "Uçak Koltuk Kapasitesi:";
            // 
            // txtUcakModel
            // 
            txtUcakModel.Location = new Point(91, 12);
            txtUcakModel.Name = "txtUcakModel";
            txtUcakModel.Size = new Size(150, 23);
            txtUcakModel.TabIndex = 4;
            // 
            // txtUcakMarka
            // 
            txtUcakMarka.Location = new Point(91, 49);
            txtUcakMarka.Name = "txtUcakMarka";
            txtUcakMarka.Size = new Size(150, 23);
            txtUcakMarka.TabIndex = 5;
            // 
            // txtUcakSeriNo
            // 
            txtUcakSeriNo.Location = new Point(91, 80);
            txtUcakSeriNo.Name = "txtUcakSeriNo";
            txtUcakSeriNo.Size = new Size(150, 23);
            txtUcakSeriNo.TabIndex = 6;
            // 
            // txtUcakKoltukKapasitesi
            // 
            txtUcakKoltukKapasitesi.Location = new Point(13, 145);
            txtUcakKoltukKapasitesi.Mask = "0000";
            txtUcakKoltukKapasitesi.Name = "txtUcakKoltukKapasitesi";
            txtUcakKoltukKapasitesi.Size = new Size(150, 23);
            txtUcakKoltukKapasitesi.TabIndex = 7;
            txtUcakKoltukKapasitesi.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewUcak
            // 
            dataGridViewUcak.AllowUserToAddRows = false;
            dataGridViewUcak.AllowUserToDeleteRows = false;
            dataGridViewUcak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUcak.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewUcak.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewUcak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUcak.Location = new Point(13, 174);
            dataGridViewUcak.Name = "dataGridViewUcak";
            dataGridViewUcak.ReadOnly = true;
            dataGridViewUcak.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUcak.Size = new Size(555, 300);
            dataGridViewUcak.TabIndex = 11;
            dataGridViewUcak.CellClick += dataGridViewUcak_CellClick;
            dataGridViewUcak.DataBindingComplete += dataGridViewUcak_DataBindingComplete;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ButtonFace;
            btnKaydet.Location = new Point(274, 104);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(82, 34);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ButtonFace;
            btnGuncelle.Location = new Point(274, 20);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(82, 36);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ButtonFace;
            btnSil.Location = new Point(274, 62);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(82, 36);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Flight_Reservation.Properties.Resources.airplane;
            pictureBox1.Location = new Point(410, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // frmPlane
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(580, 486);
            Controls.Add(pictureBox1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(dataGridViewUcak);
            Controls.Add(txtUcakKoltukKapasitesi);
            Controls.Add(txtUcakSeriNo);
            Controls.Add(txtUcakMarka);
            Controls.Add(txtUcakModel);
            Controls.Add(lblUcakKoltukKapasitesi);
            Controls.Add(lblUcakSeriNo);
            Controls.Add(lblUcakMarka);
            Controls.Add(lblUcakModel);
            Name = "frmPlane";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUcak).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUcakModel;
        private Label lblUcakMarka;
        private Label lblUcakSeriNo;
        private Label lblUcakKoltukKapasitesi;
        private TextBox txtUcakModel;
        private TextBox txtUcakMarka;
        private TextBox txtUcakSeriNo;
        private MaskedTextBox txtUcakKoltukKapasitesi;
        private DataGridView dataGridViewUcak;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnSil;
        private PictureBox pictureBox1;
    }
}