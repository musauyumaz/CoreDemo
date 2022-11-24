using Application.Abstractions.Storages.Local;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Services.StorageServices.Local
{
    public class LocalStorage : Storage,ILocalStorage
    {
        public void Delete(string pathOrContainerName, string fileName)
            => File.Delete($"{pathOrContainerName}\\{fileName}");

        public List<string> GetFiles(string pathOrContainerName)
        {
            DirectoryInfo directoryInfo = new(pathOrContainerName);
            return directoryInfo.GetFiles().Select(f => f.Name).ToList();
        }

        public bool HasFile(string pathOrContainerName, string fileName)
            => File.Exists($"{pathOrContainerName}\\{fileName}");

        public List<(string fileName, string pathOrContainerName)> Upload(string pathOrContainerName, IFormFileCollection files)
        {
            throw new NotImplementedException();
        }
    }
}
