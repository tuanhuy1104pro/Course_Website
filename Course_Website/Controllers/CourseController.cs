using CourseEdu_Core.DTO;
using CourseEdu_Core.Enum;
using CourseEdu_Core.IServices;
using CourseEdu_Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Course_Website.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseServices _Courseservices;
        private readonly ICategoryServices _categoryService;
        public CourseController(ICategoryServices categoryService, ICourseServices courseServices )
        {

            _categoryService = categoryService;
            _Courseservices = courseServices;

        }
        [Route("/Course", Name = "Course")]
        public IActionResult Course()
        {
            return View();
        }
        [HttpGet]
        [Route("/Course/List",Name ="CourseList")]
        public async Task<IActionResult> Courses(string? sortBy,string? searchString, SortOrder order = SortOrder.Ascending )
        {
            List<CourseRespone> listCourse = await _Courseservices.GetAll(); 
            return View(listCourse);
        }
    }
}
