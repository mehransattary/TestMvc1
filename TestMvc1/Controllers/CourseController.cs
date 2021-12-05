using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMvc1.Models;

namespace TestMvc1.Controllers
{
    public class CourseController : Controller
    {
      private Context context;
        public CourseController(Context context )
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var courses = context.Courses.ToList();

            return View(courses);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(/*string C_name,string C_coeffient*/  Course course)
        {
            if(ModelState.IsValid)
            {
                context.Courses.Add(course);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.err = "please fill all blankets.";
            return View();
        }
        [HttpGet]
        public IActionResult Edit( int id)
        {
            // recive id
            //var course = context.Courses.Find(id);
           // var course1 = context.Courses.Where(x => x.Id == id).FirstOrDefault();
            var course2 = context.Courses.FirstOrDefault(x => x.Id == id);
            return View( course2);
        }
        [HttpPost]
        public IActionResult Edit(Course course)
        {
            context.Update(course);
            context.SaveChanges();
            return View();
        }

    }
}
