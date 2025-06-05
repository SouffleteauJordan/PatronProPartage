using System.Collections.Generic;
using System.Linq;
using PatronProPartage.Models;

namespace PatronProPartage.Services;

public class InMemoryPatronService : IPatronService
{
    private readonly List<Pattern> _patterns = new();

    public Task AddAsync(Pattern pattern)
    {
        pattern.Id = _patterns.Count + 1;
        _patterns.Add(pattern);
        return Task.CompletedTask;
    }

    public Task<Pattern?> GetByIdAsync(int id)
    {
        var pattern = _patterns.FirstOrDefault(p => p.Id == id);
        return Task.FromResult(pattern);
    }

    public Task<IEnumerable<Pattern>> GetPublicPatternsAsync()
    {
        return Task.FromResult<IEnumerable<Pattern>>(_patterns);
    }
}
