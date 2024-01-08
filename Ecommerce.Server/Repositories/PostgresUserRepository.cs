using Ecommerce.Server.Helpers;
using Ecommerce.Server.Models;

namespace Ecommerce.Server.Repositories
{
    public class PostgresUserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public PostgresUserRepository(DataContext context)
        {
            _context = context;
        }
        public User Add(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User Delete(User user)
        {
            _context.Remove(user);
            _context.SaveChanges();
            return user;
        }

        public User Delete(int id)
        {
            User user = _context.Users.Find(id);

            if (user != null)
            {
                _context.Remove(user);
                _context.SaveChanges();
            }
            return user;
        }

        public User Get(int id)
        {
            return _context.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User Update(User updatedUser)
        {
            var user = _context.Users.Attach(updatedUser);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updatedUser;
        }
    }
}
