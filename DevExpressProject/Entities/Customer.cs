using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
