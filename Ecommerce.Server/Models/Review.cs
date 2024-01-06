namespace Ecommerce.Server.Models
{
    public class Review
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
