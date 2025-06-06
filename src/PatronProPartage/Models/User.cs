using System.Collections.Generic;
namespace PatronProPartage.Models;

public class User
{
    public int Id { get; set; }
    public string Pseudo { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public List<Library> Libraries { get; set; } = new();
    public List<Pattern> Patterns { get; set; } = new();
    public List<PrivateMessage> Messages { get; set; } = new();
    public UserRole Role { get; set; } = UserRole.Utilisateur;
    public List<Badge> Badges { get; set; } = new();
}
