namespace UcakRezervasyon.Models
{
    public partial class Reservation
    {
        public int IdRezervasyon { get; set; }
        public int UcakId { get; set; }
        public int LokasyonId { get; set; }
        public DateTime Tarih { get; set; }
        public string? MusteriKimlikNo { get; set; }
        public string? MusteriAd { get; set; }
        public string? MusteriSoyad { get; set; }
        public string? MusteriCinsiyet { get; set; }
        public bool YasliGenc { get; set; }
        public bool EngelliSaglam { get; set; }
        public int KoltukNo { get; set; }
    }
}
