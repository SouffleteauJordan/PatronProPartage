using System.Collections.Generic;
using System.Linq;
using PatronProPartage.Models;

namespace PatronProPartage.Services;

public class InMemoryUserService : IUserService
{
    private readonly List<User> _users = new();

    public Task AddAsync(User user)
    {
        user.Id = _users.Count + 1;
        _users.Add(user);
        return Task.CompletedTask;
    }

    public Task<User?> GetByIdAsync(int id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        return Task.FromResult(user);
    }
}
