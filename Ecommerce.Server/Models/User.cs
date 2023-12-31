﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Server.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public Role Role { get; set; }
    }
}
