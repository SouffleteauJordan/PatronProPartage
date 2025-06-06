using System.Collections.Generic;
namespace PatronProPartage.Models;

public class Library
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsPublic { get; set; }
    public List<Pattern> Patterns { get; set; } = new();
}
