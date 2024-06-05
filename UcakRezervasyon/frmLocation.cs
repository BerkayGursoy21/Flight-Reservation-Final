using UcakRezervasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UcakRezervasyon
{
    public partial class frmLocation : Form
    {
        private readonly DBContext context = new DBContext();
        private readonly List<DataLocation> lokasyonlar = new List<DataLocation>
        {
            new DataLocation("Türkiye", "Adana", "Adana Havalimanı (ADA)"),
            new DataLocation("Türkiye", "Adana", "Çukurova Havalimanı (COV)"),
            new DataLocation("Türkiye", "Adıyaman", "Adıyaman Havalimanı (ADF)"),
            new DataLocation("Türkiye", "Ağrı", "Ağrı Havalimanı (AJI)"),
            new DataLocation("Türkiye", "Alanya", "Gazipaşa Alanya Havalimanı (GZP)"),
            new DataLocation("Türkiye", "Amasya", "Amasya Merzifon Havalimanı (MZH)"),
            new DataLocation("Türkiye", "Ankara", "Ankara Esenboğa Havalimanı (ESB)"),
            new DataLocation("Türkiye", "Antalya", "Antalya Havalimanı (AYT)"),
            new DataLocation("Türkiye", "Balıkesir - Edremit", "Koca Seyit Havalimanı (EDO)"),
            new DataLocation("Türkiye", "Batman", "Batman Havalimanı (BAL)"),
            new DataLocation("Türkiye", "Bingöl", "Bingöl Havalimanı (BGG)"),
            new DataLocation("Türkiye", "Bursa", "Bursa Yenişehir Havalimanı (YEI)"),
            new DataLocation("Türkiye", "Çanakkale", "Çanakkale Havalimanı (CKZ)"),
            new DataLocation("Türkiye", "Denizli", "Denizli Çardak Havalimanı (DNZ)"),
            new DataLocation("Türkiye", "Diyarbakır", "Diyarbakır Havalimanı (DIY)"),
            new DataLocation("Türkiye", "Elazığ", "Elazığ Havalimanı (EZS)"),
            new DataLocation("Türkiye", "Erzincan", "Erzincan Yıldırım Akbulut Havalimanı (ERC)"),
            new DataLocation("Türkiye", "Erzurum", "Erzurum Havalimanı (ERZ)"),
            new DataLocation("Türkiye", "Eskişehir", "Hasan Polatkan Havalimanı (AOE)"),
            new DataLocation("Türkiye", "Gaziantep", "Gaziantep Havalimanı (GZT)"),
            new DataLocation("Türkiye", "Hakkari", "Yüksekova Havalimanı (YKO)"),
            new DataLocation("Türkiye", "Hatay", "Hatay Havalimanı (HTY)"),
            new DataLocation("Türkiye", "Iğdır", "Iğdır Şehit Bülent Aydın Havalimanı (IGD)"),
            new DataLocation("Türkiye", "Isparta", "Isparta Süleyman Demirel Havalimanı (ISE)"),
            new DataLocation("Türkiye", "İstanbul", "İstanbul Havalimanı (IST)"),
            new DataLocation("Türkiye", "İstanbul", "Sabiha Gökçen Havalimanı (SAW)"),
            new DataLocation("Türkiye", "İzmir", "İzmir Adnan Menderes Havalimanı (ADB)"),
            new DataLocation("Türkiye", "Kahramanmaraş", "Kahramanmaraş Havalimanı (KCM)"),
            new DataLocation("Türkiye", "Kars", "Kars Harakani Havalimanı (KSY)"),
            new DataLocation("Türkiye", "Kastamonu", "Kastamonu Havalimanı (KFS)"),
            new DataLocation("Türkiye", "Kayseri", "Kayseri Havalimanı (ASR)"),
            new DataLocation("Türkiye", "Kocaeli", "Kocaeli Cengiz Topel Havalimanı (KCO)"),
            new DataLocation("Türkiye", "Konya", "Konya Havalimanı (KYA)"),
            new DataLocation("Türkiye", "Kütahya", "Zafer Bölgesel Havalimanı (KZR)"),
            new DataLocation("Türkiye", "Malatya", "Malatya Havalimanı (MLX)"),
            new DataLocation("Türkiye", "Mardin", "Mardin Prof. Dr. Aziz Sancar Havalimanı (MQM)"),
            new DataLocation("Türkiye", "Muğla-Bodrum", "Milas-Bodrum Havalimanı (BJV)"),
            new DataLocation("Türkiye", "Muğla-Dalaman", "Dalaman Havalimanı (DLM)"),
            new DataLocation("Türkiye", "Muş", "Muş Havalimanı (MSR)"),
            new DataLocation("Türkiye", "Nevşehir", "Nevşehir Kapadokya Havalimanı (NAV)"),
            new DataLocation("Türkiye", "Ordu-Giresun", "Ordu-Giresun Havalimanı (OGU)"),
            new DataLocation("Türkiye", "Rize", "Rize Artvin Havalimanı (RZV)"),
            new DataLocation("Türkiye", "Samsun", "Samsun Çarşamba Havalimanı (SZF)"),
            new DataLocation("Türkiye", "Siirt", "Siirt Havalimanı (SXZ)"),
            new DataLocation("Türkiye", "Sinop", "Sinop Havalimanı (NOP)"),
            new DataLocation("Türkiye", "Sivas", "Sivas Nuri Demirağ Havalimanı (VAS)"),
            new DataLocation("Türkiye", "Şanlıurfa", "Şanlıurfa GAP Havalimanı (GNY)"),
            new DataLocation("Türkiye", "Şırnak", "Şırnak Şerafettin Elçi Havalimanı (NKT)"),
            new DataLocation("Türkiye", "Tokat", "Tokat Havalimanı (TJK)"),
            new DataLocation("Türkiye", "Trabzon", "Trabzon Havalimanı (TZX)"),
            new DataLocation("Türkiye", "Uşak", "Uşak Havalimanı (USQ)"),
            new DataLocation("Türkiye", "Van", "Van Ferit Melen Havalimanı (VAN)"),
            new DataLocation("Türkiye", "Zonguldak", "Zonguldak Havalimanı (ONQ)")
        };

        public frmLocation()
        {
            InitializeComponent();
            comboBoxDoldurUlke();
            veriler();

            comboUlke.SelectedIndexChanged += (s, e) =>
            {
                comboBoxDoldurSehir(comboUlke.SelectedItem.ToString());
                comboSehir.SelectedIndex = -1;
                comboHavaalani.DataSource = null;
            };

            comboSehir.SelectedIndexChanged += (s, e) =>
            {
                if (comboSehir.SelectedIndex >= 0)
                {
                    comboBoxDoldurHavaalani(comboUlke.SelectedItem.ToString(), comboSehir.SelectedItem.ToString());
                    comboHavaalani.SelectedIndex = -1;
                }
            };
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (DBContext.KontrolDB())
            {
                var durum = comboAktifPasif.SelectedItem.ToString() == "Aktif";
                var lokasyon = new Location
                {
                    Ulke = comboUlke.SelectedItem.ToString(),
                    Sehir = comboSehir.SelectedItem.ToString(),
                    Havaalani = comboHavaalani.SelectedItem.ToString(),
                    AktifPasif = durum
                };
                context.Lokasyonlar.Add(lokasyon);
                context.SaveChanges();
                veriler();
                temizle();
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası !", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (DBContext.KontrolDB())
            {
                if (dataGridViewLokasyon.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dataGridViewLokasyon.SelectedRows[0].Cells[0].Value.ToString());
                    var lokasyon = context.Lokasyonlar.Find(id);
                    if (lokasyon != null)
                    {
                        var durum = comboAktifPasif.SelectedItem.ToString() == "Aktif";
                        lokasyon.Ulke = comboUlke.SelectedItem.ToString();
                        lokasyon.Sehir = comboSehir.SelectedItem.ToString();
                        lokasyon.Havaalani = comboHavaalani.SelectedItem.ToString();
                        lokasyon.AktifPasif = durum;
                        context.SaveChanges();
                        veriler();
                        temizle();
                    }
                }
                else
                {
                    MessageBox.Show("Güncellenecek bir kayıt seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası !", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (DBContext.KontrolDB())
            {
                if (dataGridViewLokasyon.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dataGridViewLokasyon.SelectedRows[0].Cells[0].Value.ToString());
                    var lokasyon = context.Lokasyonlar.Find(id);
                    if (lokasyon != null)
                    {
                        context.Lokasyonlar.Remove(lokasyon);
                        context.SaveChanges();
                        veriler();
                        temizle();
                    }
                }
                else
                {
                    MessageBox.Show("Silinecek bir kayıt seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası !", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewLokasyon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DBContext.KontrolDB())
            {
                dataGridViewLokasyon.Columns[0].HeaderText = "Lokasyon ID";
                dataGridViewLokasyon.Columns[1].HeaderText = "Ulke";
                dataGridViewLokasyon.Columns[2].HeaderText = "Şehir";
                dataGridViewLokasyon.Columns[3].HeaderText = "Havaalanı";
                dataGridViewLokasyon.Columns[4].HeaderText = "Durum";
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası !", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewLokasyon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DBContext.KontrolDB())
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewLokasyon.Rows[e.RowIndex];
                    comboUlke.SelectedItem = row.Cells["Ulke"].Value.ToString();
                    comboSehir.SelectedItem = row.Cells["Sehir"].Value.ToString();
                    comboHavaalani.SelectedItem = row.Cells["Havaalani"].Value.ToString();
                    comboAktifPasif.SelectedItem = Convert.ToBoolean(row.Cells["AktifPasif"].Value) ? "Aktif" : "Pasif";
                }
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası ! ", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxDoldurUlke()
        {
            var ulkeler = lokasyonlar.Select(l => l.Ulke).Distinct().ToList();
            comboUlke.DataSource = ulkeler;
        }

        private void comboBoxDoldurSehir(string secilenUlke)
        {
            var sehirler = lokasyonlar.Where(l => l.Ulke == secilenUlke).Select(l => l.Sehir).Distinct().ToList();
            comboSehir.DataSource = sehirler;
        }

        private void comboBoxDoldurHavaalani(string secilenUlke, string secilenSehir)
        {
            var havaalanlari = lokasyonlar.Where(l => l.Ulke == secilenUlke && l.Sehir == secilenSehir).Select(l => l.Havaalani).Distinct().ToList();
            comboHavaalani.DataSource = havaalanlari;
        }

        private void veriler()
        {
            if (DBContext.KontrolDB())
            {
                dataGridViewLokasyon.DataSource = context.Lokasyonlar.ToList();
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Kurulurken Hata Yaşandı.", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void temizle()
        {
            comboUlke.SelectedItem = null;
            comboSehir.SelectedItem = null;
            comboHavaalani.SelectedItem = null;
            comboAktifPasif.SelectedItem = null;
        }
    }
}
