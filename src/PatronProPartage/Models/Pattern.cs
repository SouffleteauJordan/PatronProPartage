using System;
using System.Collections.Generic;
namespace PatronProPartage.Models;

public class Pattern
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> ClothingCategories { get; set; } = new();
    public List<string> Techniques { get; set; } = new();
    public List<string> Sizes { get; set; } = new();
    public List<string> Seasons { get; set; } = new();
    public List<string> Styles { get; set; } = new();
    public List<string> Formats { get; set; } = new();
    public List<string> Files { get; set; } = new();
    public List<string> Images { get; set; } = new();
    public string? Video { get; set; }
    public double AverageRating { get; set; }
    public List<string> Comments { get; set; } = new();
    public User? Author { get; set; }
    public List<PatternVersion> Versions { get; set; } = new();
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
