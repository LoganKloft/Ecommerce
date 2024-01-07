using Ecommerce.Server.Helpers;
using Ecommerce.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users = new List<User>
            {
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Password = "admin"
                }
            };

            return Ok(users);
        }
    }
}
