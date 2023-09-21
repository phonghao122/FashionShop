using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Bill : BaseEntity
    {
        [Column(TypeName = "nvarchar(1000)")]
        public string FirstName { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(1000)")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(1000)")]

        public string CompanyName { get; set; } = string.Empty;
        
        [Column(TypeName = "nvarchar(1000)")]

        public string Country { get; set; } = string.Empty;
        
        [Column(TypeName = "nvarchar(1000)")]

        public string StreetAddress { get; set; } = string.Empty;
        
        [Column(TypeName = "nvarchar(1000)")]

        public string City { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(1000)")]
        public string Telephone { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public ICollection<BillDetail> BillDetails { get; set; }
    }
}
