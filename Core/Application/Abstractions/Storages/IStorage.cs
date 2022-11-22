using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.Storages
{
    public interface IStorage
    {
        List<(string fileName, string pathOrContainerName)> Upload(string pathOrContainerName, IFormFileCollection files);
        void Delete(string pathOrContainerName, string fileName);
        List<string> GetFiles(string pathOrContainerName);
        bool HasFile(string pathOrContainerName, string fileName);
    }
    public interface IStorageService : IStorage
    {
        public string StorageName { get;}
    }
}
