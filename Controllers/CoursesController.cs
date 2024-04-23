using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCourse.Models.Services.Application;
using MyCourse.Models.ViewModels;


namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public CoursesController()
        {

        }

        public IActionResult Index() //metodo che deve recuperare la lista di tutti i corsi
        {
            var courseService=new CourseService();
            List<CourseViewModel> courses= courseService.GetCourses(); //metodo che ritorna la lista di tutti i corsi 
            return View(courses);
        }

        public IActionResult Detail(string id)
        {
            return View();
        }

        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}