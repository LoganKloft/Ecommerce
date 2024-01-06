using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Server.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public Order Orders { get; set; }
        public Inventory Inventory { get; set; }
        public int Quantity { get; set; }
        [Timestamp]
        public byte[] ShippedOn { get; set; }
        [Timestamp]
        public byte[] ShipBy { get; set; }
        public Shipper Shipper { get; set; }
    }
}
