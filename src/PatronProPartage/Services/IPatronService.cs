using PatronProPartage.Models;

namespace PatronProPartage.Services;

public interface IPatronService
{
    Task<List<Pattern>> GetAllAsync();
    Task<Pattern?> GetByIdAsync(int id);
    Task AddAsync(Pattern pattern);
    Task UpdateAsync(Pattern pattern);
    Task DeleteAsync(int id);
}
