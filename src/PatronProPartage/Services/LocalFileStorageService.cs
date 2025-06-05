using System.IO;
namespace PatronProPartage.Services;

public class LocalFileStorageService : IFileStorageService
{
    private readonly string _basePath = "D:/CoutureShare/PatronsStorage";

    public Task SaveAsync(string path, Stream content)
    {
        string fullPath = Path.Combine(_basePath, path);
        Directory.CreateDirectory(Path.GetDirectoryName(fullPath)!);
        using var fileStream = File.Create(fullPath);
        return content.CopyToAsync(fileStream);
    }

    public Task<Stream?> GetAsync(string path)
    {
        string fullPath = Path.Combine(_basePath, path);
        if (!File.Exists(fullPath)) return Task.FromResult<Stream?>(null);
        Stream fileStream = File.OpenRead(fullPath);
        return Task.FromResult<Stream?>(fileStream);
    }

    public Task DeleteAsync(string path)
    {
        string fullPath = Path.Combine(_basePath, path);
        if (File.Exists(fullPath)) File.Delete(fullPath);
        return Task.CompletedTask;
    }
}
