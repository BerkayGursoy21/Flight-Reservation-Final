namespace UcakRezervasyon.Models
{
    public partial class Location
    {
        public int IdLokasyon { get; set; }
        public string? Ulke { get; set; }
        public string? Sehir { get; set; }
        public string? Havaalani { get; set; }
        public bool AktifPasif { get; set; }
    }
}
