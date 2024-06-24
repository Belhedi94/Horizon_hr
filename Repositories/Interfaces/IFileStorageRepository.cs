namespace Horizon_HR.Repositories.Interfaces
{
    public interface IFileStorageRepository
    {
        Task<string> StoreFileAsync(IFormFile file, string folderName);
        void DeleteFile(string fileName);
    }
}
