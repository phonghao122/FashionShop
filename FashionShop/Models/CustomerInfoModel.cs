using Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;

namespace FashionShop.Models
{
    public class CustomerInfoModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string CompanyName { get; set; } = string.Empty;

        [Required]
        public string Country { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public PaymentMethod PaymentMethod { get; set; }
    }
}
