using Ecommerce.Server.Models;

namespace Ecommerce.Server.Repositories
{
    public interface IUserRepository
    {
        User Add(User user);
        User Update(User user);
        User Delete(User user);
        User Delete(int id);
        User Get(int id);
        IEnumerable<User> GetAll();
    }
}
