using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Server.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public decimal Amount { get; set; }
        public string PaymentProvider { get; set; }
        public string PaymentStatus { get; set; }
        [Timestamp]
        public byte[] Expiry { get; set; }
    }
}
