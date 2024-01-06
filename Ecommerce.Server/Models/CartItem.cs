namespace Ecommerce.Server.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public ShoppingSession ShoppingSession { get; set; }
        public Product Product { get; set; }
        public Inventory Inventory { get; set; }
        public int Quantity { get; set; }
    }
}
