using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestMvc1.Models;

namespace TestMvc1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            this.context = context;
        }

       
        public IActionResult Index()
        {
            ViewBag.test = 545;
            ViewData["test"] = 874;
            TempData["test2"] = 8423;
            string test3 = "ali";

            return View("Index",test3);
        }
        [HttpPost]
        public IActionResult Index(string a)
        {
            ViewBag.test = 545;
            ViewData["test"] = 874;
            TempData["test2"] = 8423;
            string test3 = "ali";

            return View("Index", test3);
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }


        [HttpPost]

        public IActionResult AddStudent()
        {
            //var manager = new Manager()
            //{
            //    M_FirstName = "m",
            //    M_LastName = "m2"
            //};
            //context.Add(manager);
            //context.SaveChanges();

            //var student = new Student()
            //{
            //    ManagerId = manager.Id,
            //    FirstName ="m",
            //    LastName="m2"
            //};

            //context.Add(student);
            //context.SaveChanges();

            var result = context.Mangers.Where(x=>x.Id==1).FirstOrDefault();
            
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
