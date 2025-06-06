using System;
using System.Collections.Generic;

namespace PatronProPartage.Models;

public class PatternVersion
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public List<string> Files { get; set; } = new();
    public string? Note { get; set; }
}
