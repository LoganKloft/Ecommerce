using Ecommerce.Server.Helpers;
using Ecommerce.Server.Models;
using Ecommerce.Server.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository _userRepository;
        public UserController(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users = _userRepository.GetAll().ToList();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = _userRepository.Get(id);
            if (user is null)
                return NotFound("User not found.");

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            _userRepository.Add(user);
            return Ok(user);
        }

        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser(User user)
        {
            _userRepository.Update(user);
            return Ok(user);
        }

        [HttpDelete]
        public async Task<ActionResult<User>> DeleteUser(User user)
        {
            _userRepository.Delete(user);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            User user = _userRepository.Delete(id);
            return Ok(user);
        }
    }
}
