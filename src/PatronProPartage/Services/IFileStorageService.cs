namespace PatronProPartage.Services;

public interface IFileStorageService
{
    Task SaveAsync(string path, Stream content);
    Task<Stream?> GetAsync(string path);
    Task DeleteAsync(string path);
}
