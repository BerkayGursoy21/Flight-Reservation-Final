namespace UcakRezervasyon.Models
{
    public partial class Plane
    {
        public int IdUcak { get; set; }
        public string? UcakModel { get; set; }
        public string? UcakMarka { get; set; }
        public string? UcakSeriNo { get; set; }
        public int UcakKoltukKapasitesi { get; set; }
    }
}
