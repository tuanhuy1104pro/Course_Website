using Microsoft.AspNetCore.Mvc;

namespace Course_Website.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
