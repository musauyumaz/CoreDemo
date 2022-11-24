using Application.Abstractions.Storages;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Infrastructure.Services.StorageServices;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AzureStorage : Storage, IStorage
    {
        private readonly BlobServiceClient _blobServiceClient;
        BlobContainerClient _blobContainerClient;

        public AzureStorage(IConfiguration configuration)
        {
            _blobServiceClient = new(configuration["Storage:Azure"]);
        }

        public void Delete(string pathOrContainerName, string fileName)
        {
            _blobContainerClient = _blobServiceClient.GetBlobContainerClient(pathOrContainerName);
            BlobClient blobClient = _blobContainerClient.GetBlobClient(fileName);
            blobClient.Delete();
        }

        public List<string> GetFiles(string pathOrContainerName)
        {
            _blobContainerClient = _blobServiceClient.GetBlobContainerClient(pathOrContainerName);
            return _blobContainerClient.GetBlobs().Select(b => b.Name).ToList();
        }

        public List<(string fileName, string pathOrContainerName)> Upload(string pathOrContainerName, IFormFileCollection files)
        {
            _blobContainerClient = _blobServiceClient.GetBlobContainerClient(pathOrContainerName);
            _blobContainerClient.CreateIfNotExists();
            _blobContainerClient.SetAccessPolicy(PublicAccessType.BlobContainer);

            List<(string fileName, string pathOrContainerName)> datas = new();
            foreach (IFormFile file in files)
            {
                string fileNewName = FileRename(pathOrContainerName, file.Name, HasFile);

                BlobClient blobClient = _blobContainerClient.GetBlobClient(fileNewName);
                blobClient.Upload(file.OpenReadStream());
                datas.Add((fileNewName, pathOrContainerName));
            }
            return datas;
        }

        public bool HasFile(string pathOrContainerName, string fileName)
        {
            _blobContainerClient = _blobServiceClient.GetBlobContainerClient(pathOrContainerName);
            return _blobContainerClient.GetBlobs().Any(b => b.Name == fileName);
        }
    }
}
