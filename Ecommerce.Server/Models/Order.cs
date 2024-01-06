using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Server.Models
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        [Timestamp]
        public byte[] OrderDate { get; set; }
        [Timestamp]
        public byte[] RequiredDate { get; set; }
        [Timestamp]
        public byte[] FinalShipDate { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal SalesTax { get; set; }
        public bool Fulfilled { get; set; }
        public bool Canceled { get; set; }
        public decimal AmountPaid { get; set; }
        [Timestamp]
        public byte[] FinalPaymentDate { get; set; }
        [Timestamp]
        public byte[] LastPaymentDate { get; set; }
        [Timestamp]
        public byte[] BillDate { get; set; }
    }
}
