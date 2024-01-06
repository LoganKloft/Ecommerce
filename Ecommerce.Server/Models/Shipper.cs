namespace Ecommerce.Server.Models
{
    public class Shipper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Telephone { get; set; }
        public string Website { get; set; }
    }
}
