using UcakRezervasyon.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UcakRezervasyon
{
    public partial class frmPlane : Form
    {
        private readonly DBContext context = new DBContext();

        public frmPlane()
        {
            InitializeComponent();
            veriler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (DBContext.KontrolDB())
            {
                var ucak = new Plane
                {
                    UcakModel = txtUcakModel.Text,
                    UcakMarka = txtUcakMarka.Text,
                    UcakSeriNo = txtUcakSeriNo.Text,
                    UcakKoltukKapasitesi = int.Parse(txtUcakKoltukKapasitesi.Text)
                };
                context.Ucaklar.Add(ucak);
                context.SaveChanges();
                veriler();
                temizle();
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası!", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (DBContext.KontrolDB())
            {
                if (dataGridViewUcak.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dataGridViewUcak.SelectedRows[0].Cells[0].Value.ToString());
                    var ucak = context.Ucaklar.Find(id);
                    if (ucak != null)
                    {
                        ucak.UcakModel = txtUcakModel.Text;
                        ucak.UcakMarka = txtUcakMarka.Text;
                        ucak.UcakSeriNo = txtUcakSeriNo.Text;
                        ucak.UcakKoltukKapasitesi = int.Parse(txtUcakKoltukKapasitesi.Text);
                        context.SaveChanges();
                        veriler();
                        temizle();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen güncellenecek uçak seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası!", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (DBContext.KontrolDB())
            {
                if (dataGridViewUcak.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dataGridViewUcak.SelectedRows[0].Cells[0].Value.ToString());
                    var ucak = context.Ucaklar.Find(id);
                    if (ucak != null)
                    {
                        context.Ucaklar.Remove(ucak);
                        context.SaveChanges();
                        veriler();
                        temizle();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek uçak seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası!", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUcak_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DBContext.KontrolDB())
            {
                dataGridViewUcak.Columns[0].HeaderText = "Uçak ID";
                dataGridViewUcak.Columns[1].HeaderText = "Uçak Model";
                dataGridViewUcak.Columns[2].HeaderText = "Uçak Marka";
                dataGridViewUcak.Columns[3].HeaderText = "Uçak Seri No";
                dataGridViewUcak.Columns[4].HeaderText = "Uçak Koltuk Kapasitesi";
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası!", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUcak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DBContext.KontrolDB())
            {
                if (e.RowIndex >= 0)
                {
                    var row = dataGridViewUcak.Rows[e.RowIndex];
                    txtUcakModel.Text = row.Cells["UcakModel"].Value.ToString();
                    txtUcakMarka.Text = row.Cells["UcakMarka"].Value.ToString();
                    txtUcakSeriNo.Text = row.Cells["UcakSeriNo"].Value.ToString();
                    txtUcakKoltukKapasitesi.Text = row.Cells["UcakKoltukKapasitesi"].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası!", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void veriler()
        {
            if (DBContext.KontrolDB())
            {
                dataGridViewUcak.DataSource = context.Ucaklar.ToList();
            }
            else
            {
                MessageBox.Show("Veritabanı ile Bağlantı Hatası!", "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void temizle()
        {
            txtUcakModel.Clear();
            txtUcakMarka.Clear();
            txtUcakSeriNo.Clear();
            txtUcakKoltukKapasitesi.Clear();
        }
    }
}
