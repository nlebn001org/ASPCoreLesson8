using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreLesson8Task1.Controllers
{
    public class FileController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public FileController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            string filePath = Path.Combine(_hostingEnvironment.ContentRootPath, "Files/TextFile.txt");
            FileStream fs = new FileStream(filePath, FileMode.Open);
            string fileType = "Application/txt";
            string fileName = "File.txt";
            return File(fs, fileType, fileName);
        }
    }
}
