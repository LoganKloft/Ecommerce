namespace Ecommerce.Server.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public Supplier Supplier { get; set; }
        public Product Product { get; set; }
        public string Color { get; set; }
        public string UnitSize { get; set; }
        public decimal UnitWeight { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public Discount Discount { get; set; }
        public Image Image { get; set; }
        public int ReorderThreshold { get; set; }
        public decimal MSRP { get; set; }
        public string Note { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
