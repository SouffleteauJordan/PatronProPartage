namespace PatronProPartage.Models;

public class Pattern
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string[] Categories { get; set; } = System.Array.Empty<string>();
    public string[] Techniques { get; set; } = System.Array.Empty<string>();
}
