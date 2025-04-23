using System.Collections.Generic;

namespace DevExpressProject.Entities
{
    public class Customer : BaseEntity
    {
        public string FullName { get; set; } = default;
        public string TCNo { get; set; } = default;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string VergiNo { get; set; } = string.Empty;
        public string VergiDairesi { get; set; } = string.Empty;
        public string Country { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
