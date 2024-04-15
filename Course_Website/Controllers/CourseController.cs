using Microsoft.AspNetCore.Mvc;

namespace Course_Website.Controllers
{
    public class CourseController : Controller
    {
        [Route("/Course", Name = "Course")]
        public IActionResult Course()
        {
            return View();
        }

        [Route("/Course/List",Name ="CourseList")]
        public IActionResult Courses()
        {
            return View();
        }
    }
}
