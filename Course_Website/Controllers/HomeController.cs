using Microsoft.AspNetCore.Mvc;

namespace Course_Website.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("[Action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/About",Name = "About")] // cho thêm Name vào thì có thể dùng Asp-route = "Tên route muốn force tới domain) => Nói chung thay vì controller/action -> ta muốn xài kiểu custom như /About thôi
        public IActionResult About()
        {
            return View();
        }

        [Route("/Contact",Name = "Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("/Course", Name = "Course")]
        public IActionResult Course()
        {
            return View();
        }
    }
}
