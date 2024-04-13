using Microsoft.AspNetCore.Mvc;

namespace Course_Website.Controllers
{
    [Route("[Controller]")]
    public class AccountController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult Login()
        {
            return View();
        }


        [HttpGet("[action]")]
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
