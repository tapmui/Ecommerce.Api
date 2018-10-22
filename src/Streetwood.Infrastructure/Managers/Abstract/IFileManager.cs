﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Streetwood.Infrastructure.Managers.Abstract
{
    public interface IFileManager
    {
        Task MoveFile(IFormFile file, string directoryPath, string uniqueFileName);

        string GetUniqueName(string name);
    }
}