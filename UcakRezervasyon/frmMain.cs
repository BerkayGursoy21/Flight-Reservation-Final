namespace UcakRezervasyon
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnUcak_Click(object sender, EventArgs e)
        {
            var ucakForm = new frmPlane();
            ucakForm.Show();
        }

        private void btnLokasyon_Click(object sender, EventArgs e)
        {
            var lokasyonForm = new frmLocation();
            lokasyonForm.Show();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            var rezervasyonForm = new frmReservation();
            rezervasyonForm.Show();
        }
    }
}
