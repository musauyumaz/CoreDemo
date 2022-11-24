using Infrastructure.Operations;

namespace Infrastructure.Services.StorageServices
{
    public class Storage
    {
        protected delegate bool HasFile(string pathOrContainerName, string fileName);
        protected string FileRename(string pathOrContainerName, string fileName, HasFile hasFileMethod)
        {
            string extension = Path.GetExtension(fileName);
            string changedFileName = $"{NameOperation.CharacterRegulatory(Path.GetFileNameWithoutExtension(fileName))}{extension}";

            if (!hasFileMethod(pathOrContainerName, changedFileName))
                return changedFileName;

            string newFileName = Path.GetFileNameWithoutExtension(changedFileName);
            if (int.TryParse(newFileName[newFileName.Length - 1].ToString(), out int sayi) && newFileName.EndsWith($"-{sayi}"))
            {
                sayi++;
                newFileName = $"{newFileName.Remove(newFileName.IndexOf("-"))}-{sayi}";
                changedFileName = newFileName + $"{extension}";
            }
            else
                changedFileName = newFileName + "-1";

            return  FileRename(pathOrContainerName, changedFileName, hasFileMethod);
        }
    }
}
