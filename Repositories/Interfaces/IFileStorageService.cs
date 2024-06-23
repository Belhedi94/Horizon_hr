namespace Horizon_HR.Repositories.Interfaces
{
    public interface IFileStorageService
    {
        Task<string> StoreFileAsync(IFormFile file, string folderName);
        void DeleteFile(string fileName);
    }
}
