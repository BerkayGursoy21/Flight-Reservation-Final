using UcakRezervasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UcakRezervasyon
{
    public partial class frmReservation : Form
    {
        private readonly DBContext context = new DBContext();
        private int koltukNo;

        public frmReservation()
        {
            InitializeComponent();
            veriler();
            ucaklar();
            lokasyonlar();
            duzen();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (DBContext.KontrolDB())
            {
                var rezervasyon = new Reservation
                {
                    UcakId = (int)comboUcak.SelectedValue,
                    LokasyonId = (int)comboLokasyon.SelectedValue,
                    Tarih = dtpTarih.Value,
                    MusteriKimlikNo = txtTCKimlikNo.Text,
                    MusteriAd = txtAd.Text,
                    MusteriSoyad = txtSoyad.Text,
                    MusteriCinsiyet = comboCinsiyet.Text,
                    KoltukNo = koltukNo
                };
                context.Rezervasyonlar.Add(rezervasyon);
                context.SaveChanges();
                veriler();
                panelDuzen.Controls.Clear();
                duzen();
                temizle();
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası !", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewRezervasyon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DBContext.KontrolDB())
            {
                dataGridViewRezervasyon.Columns[0].HeaderText = "T.C. Kimlik No";
                dataGridViewRezervasyon.Columns[1].HeaderText = "Ad";
                dataGridViewRezervasyon.Columns[2].HeaderText = "Soyad";
                dataGridViewRezervasyon.Columns[3].HeaderText = "Cinsiyet";
                dataGridViewRezervasyon.Columns[4].HeaderText = "Yaşlı";
                dataGridViewRezervasyon.Columns[5].HeaderText = "Engelli";
                dataGridViewRezervasyon.Columns[6].HeaderText = "Koltuk No";
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası !", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucaklar()
        {
            if (DBContext.KontrolDB())
            {
                var ucaklar = context.Ucaklar.ToList();
                comboUcak.DataSource = ucaklar;
                comboUcak.DisplayMember = "UcakModel";
                comboUcak.ValueMember = "IdUcak";
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası !", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lokasyonlar()
        {
            if (DBContext.KontrolDB())
            {
                var lokasyonlar = context.Lokasyonlar.ToList();
                comboLokasyon.DataSource = lokasyonlar;
                comboLokasyon.DisplayMember = "Havaalani";
                comboLokasyon.ValueMember = "IdLokasyon";
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası !", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<int> dondurRezervasyonluKoltuklar()
        {
            return context.Rezervasyonlar.Select(r => r.KoltukNo).ToList();
        }

        private void duzen()
        {
            var rezervasyonluKoltuklar = dondurRezervasyonluKoltuklar();
            const int buttonWidth = 75;
            const int buttonHeight = 23;
            int x = 30, y = 30, tabIndex = 1;

            for (int row = 0; row < 10; row++)
            {
                CreateButtons(rezervasyonluKoltuklar, ref x, y, ref tabIndex, buttonWidth, buttonHeight, 3);
                x += buttonWidth + 1;
                CreateButtons(rezervasyonluKoltuklar, ref x, y, ref tabIndex, buttonWidth, buttonHeight, 4);
                x += buttonWidth + 1;
                CreateButtons(rezervasyonluKoltuklar, ref x, y, ref tabIndex, buttonWidth, buttonHeight, 3);

                x = 30;
                y += buttonHeight + 1;
            }
        }

        private void CreateButtons(List<int> rezervasyonluKoltuklar, ref int x, int y, ref int tabIndex, int buttonWidth, int buttonHeight, int buttonCount)
        {
            for (int col = 0; col < buttonCount; col++)
            {
                var button = new Button
                {
                    Text = $"{tabIndex}",
                    Location = new System.Drawing.Point(x, y),
                    Size = new System.Drawing.Size(buttonWidth, buttonHeight),
                    TabIndex = tabIndex,
                    BackColor = rezervasyonluKoltuklar.Contains(tabIndex) ? System.Drawing.Color.Red : System.Drawing.Color.Green,
                    FlatStyle = FlatStyle.Flat
                };
                button.Click += button_Click;
                panelDuzen.Controls.Add(button);

                x += buttonWidth + 1;
                tabIndex++;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                koltukNo = int.Parse(button.Text);
            }
        }

        private void veriler()
        {
            if (DBContext.KontrolDB())
            {
                dataGridViewRezervasyon.DataSource = context.Rezervasyonlar
                    .Select(r => new { r.MusteriKimlikNo, r.MusteriAd, r.MusteriSoyad, r.MusteriCinsiyet, r.YasliGenc, r.EngelliSaglam, r.KoltukNo })
                    .ToList();
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası !", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void temizle()
        {
            txtTCKimlikNo.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            comboCinsiyet.SelectedIndex = -1;
            comboUcak.SelectedIndex = -1;
            comboLokasyon.SelectedIndex = -1;
            dtpTarih.Value = DateTime.Now;
        }
    }
}
