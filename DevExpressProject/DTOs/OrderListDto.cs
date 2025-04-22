using System;

namespace DevExpressProject.DTOs
{
    public class OrderListDto
    {
        public int Id { get; set; }
        public int FisNo { get; set; }
        public string Cari { get; set; }
        public string Products { get; set; }
        public int UrunSayisi { get; set; }
        public int TotalQuantity { get; set; }
        public DateTime SevkiyatTarihi { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
