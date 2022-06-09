using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public static class FileManager
    {
        public static IDataResult<string> Save(string rootPath, string folder, IFormFile file)
        {
            string fileName = file.FileName;
            fileName = fileName.Length <= 64 ? fileName : fileName.Substring(fileName.Length - 64, 64);
            fileName = Guid.NewGuid().ToString() + fileName;
            string path = Path.Combine(rootPath, folder, fileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return new SuccessDataResult<string>(fileName, "success");//refactor
        }

        public static IResult Delete(string rootPath, string folder, string image)
        {
            string path = Path.Combine(rootPath, folder, image);
            if (File.Exists(path))
            {
                File.Delete(path);
                return new SuccessResult();
            }

            return new ErrorResult("The photo you wanted to edit could not be found");
        }
        
    }
}
