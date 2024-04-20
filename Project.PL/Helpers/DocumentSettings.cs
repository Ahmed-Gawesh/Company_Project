using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Project.PL.Helpers
{
    public class DocumentSettings
    {
        public static string UploadImage(IFormFile file,string FolderName)
        {
            //1.Get Located Folder Path
            string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", FolderName);
            //2.get FileName And Make It Unique
            string FileName = $"{Guid.NewGuid()}{file.FileName}";
            //3.Get FilePath
            string FilePath=Path.Combine(FolderPath, FileName);
            //4.FileStream
            var fs = new FileStream(FilePath, FileMode.Create);
              file.CopyTo(fs);

            return FileName;
        }

        public static void DeleteFile(string fileName,string FolderName)
        {
            if(fileName is not null && FolderName is not null)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\files",FolderName,fileName);
                if(File.Exists(filePath))
                {
                     File.Delete(filePath);
                }
            }
        }
    }
}
