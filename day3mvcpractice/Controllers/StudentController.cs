using day3mvcpractice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace day3mvcpractice.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> studants = new List<Student>();

        [HttpGet]
        public IActionResult create()
        {
            Student studant=new Student();
            return View(studant);
        }

        [HttpPost]

        public IActionResult create(Student studant)
        {
            studants.Add(studant);
            return RedirectToAction("table");
        }

        public IActionResult table()
        {
            return View(studants); 
        }
    }
}
