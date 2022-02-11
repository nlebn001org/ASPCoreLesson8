using ASPCoreLesson8Task1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreLesson8Task1.Controllers
{
    public class WorkerController : Controller
    {
        public IActionResult Index()
        {
            return View(GetWorkers(3));
        }

        [NonAction]
        public List<Worker> GetWorkers(int num)
        {
            List<Worker> workers = new List<Worker>();
            for (int i = 0; i < num; i++)
                workers.Add(new Worker() { Id = i, Name = $"WorkerName{i}", Surname = $"WorkerSurname{i}" });
            return workers;
        }
    }
}
