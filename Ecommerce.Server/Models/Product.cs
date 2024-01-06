using System.Numerics;

namespace Ecommerce.Server.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Supplier Supplier { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public bool ProductAvailable { get; set; }
        public bool DiscountAvailable { get; set; }
        public int Ranking { get; set; }
    }
}
