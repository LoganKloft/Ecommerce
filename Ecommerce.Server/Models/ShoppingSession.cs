namespace Ecommerce.Server.Models
{
    public class ShoppingSession
    {
        public int Id { get; set; }
        public User User { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
