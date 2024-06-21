namespace Horizon_HR.Interfaces
{
    public interface IFileStorageService
    {
       Task<string> StoreFileAsync(IFormFile file, string folderName);
       void DeleteFile(string fileName);
    }
}
