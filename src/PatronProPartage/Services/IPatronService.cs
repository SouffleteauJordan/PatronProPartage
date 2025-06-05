using PatronProPartage.Models;

namespace PatronProPartage.Services;

public interface IPatronService
{
    Task<IEnumerable<Pattern>> GetPublicPatternsAsync();
    Task<Pattern?> GetByIdAsync(int id);
    Task AddAsync(Pattern pattern);
}
