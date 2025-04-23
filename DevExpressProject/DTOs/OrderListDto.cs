using System;

namespace DevExpressProject.DTOs
{
    public class OrderListDto
    {
        public int Id { get; set; }
        public int FisNo { get; set; }
        public string Ürünler { get; set; }
        public DateTime SevkiyatTarihi { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
