using PatronProPartage.Models;

namespace PatronProPartage.Services;

public interface IUserService
{
    Task<User?> GetByIdAsync(int id);
    Task AddAsync(User user);
}
