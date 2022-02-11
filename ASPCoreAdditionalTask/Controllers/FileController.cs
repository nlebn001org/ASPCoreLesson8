using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreAdditionalTask.Controllers
{
    public class FileController : Controller
    {
        IHostEnvironment _hostEnvironment;

        public FileController(IHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(string name, string surname, string filename)
        {
            string[] text = { name, surname };
            string generatePath = Path.Combine(_hostEnvironment.ContentRootPath, "Files");
            FileInfo file = new FileInfo(Path.Combine(generatePath, $"{filename}.txt"));
            System.IO.File.WriteAllLines(file.FullName, text);
            return PhysicalFile(file.FullName, "Application/txt", $"{filename}.txt");
        }
    }
}
