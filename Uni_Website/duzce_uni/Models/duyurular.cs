namespace duzce_uni.Models
{
    public class duyurular
    {
        public int Id { get; set; }
        public string duyuruBaslik { get; set; } = string.Empty;
        public string duyuruTur { get; set; } = string.Empty;
        public string duyuruTarih { get; set; } = string.Empty;
        public string duyuruIcerik1 { get; set; } = string.Empty;
        public string? duyuruIcerik2 { get; set; }
        public string? duyuruIcerik3 { get; set; }
        public string? duyuruGorsel1 { get; set; }
        public string? duyuruGorsel2 { get; set; }
        public string? duyuruGorsel3 { get; set; }
        public string? duyuruGorsel4 { get; set; }
        public string? duyuruGorsel5 { get; set; }

    }
}
