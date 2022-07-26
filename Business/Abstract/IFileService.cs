using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFileService
    {
        string SaveFileToServer(IFormFile file, string path);
        string SaveFileToFtp(IFormFile file);
        byte[] GetFileBinaryType(IFormFile file);
    }
}
