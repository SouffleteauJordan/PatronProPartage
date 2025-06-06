using System.Collections.Generic;
using System.Linq;
using PatronProPartage.Models;

namespace PatronProPartage.Services;

public class InMemoryPatronService : IPatronService
{
    private static readonly List<Pattern> _patterns = new();

    public Task<List<Pattern>> GetAllAsync()
    {
        return Task.FromResult(_patterns.ToList());
    }

    public Task<Pattern?> GetByIdAsync(int id)
    {
        var pattern = _patterns.FirstOrDefault(p => p.Id == id);
        return Task.FromResult(pattern);
    }

    public Task AddAsync(Pattern pattern)
    {
        pattern.Id = _patterns.Count == 0 ? 1 : _patterns.Max(p => p.Id) + 1;
        _patterns.Add(pattern);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(Pattern pattern)
    {
        var index = _patterns.FindIndex(p => p.Id == pattern.Id);
        if (index >= 0)
        {
            _patterns[index] = pattern;
        }
        return Task.CompletedTask;
    }

    public Task DeleteAsync(int id)
    {
        var existing = _patterns.FirstOrDefault(p => p.Id == id);
        if (existing != null)
        {
            _patterns.Remove(existing);
        }
        return Task.CompletedTask;
    }
}
