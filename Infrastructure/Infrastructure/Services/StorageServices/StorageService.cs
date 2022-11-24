using Application.Abstractions.Storages;

namespace Infrastructure.Services.StorageServices
{
    public class StorageService : IStorageService
    {

        private readonly IStorage _storage;

        public StorageService(IStorage storage)
        {
            _storage = storage;
        }
        public string StorageName => _storage.GetType().Name;

        public void Delete(string pathOrContainerName, string fileName)
            => _storage.Delete(pathOrContainerName, fileName);

        public List<string> GetFiles(string pathOrContainerName)
            => _storage.GetFiles(pathOrContainerName);

        public bool HasFile(string pathOrContainerName, string fileName)
            =>_storage.HasFile(pathOrContainerName, fileName);

        public List<(string fileName, string pathOrContainerName)> Upload(string pathOrContainerName, Microsoft.AspNetCore.Http.IFormFileCollection files)
            =>_storage.Upload(pathOrContainerName, files);
    }
}
