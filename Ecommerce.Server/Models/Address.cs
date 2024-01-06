﻿namespace Ecommerce.Server.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string StreetAddress { get; set; }
        public User User { get; set; }
        public string PostalCode { get; set; }
    }
}
