using ASPCoreLesson8Task1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreLesson8Task1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View(GetCustomers(3));
        }


        [NonAction]
        public List<Customer> GetCustomers(int num)
        {
            List<Customer> workers = new List<Customer>();
            for (int i = 0; i < num; i++)
                workers.Add(new Customer() { Id = i, Name = $"CustomerName{i}", Surname = $"CustomerSurname{i}" });
            return workers;
        }
    }
}
