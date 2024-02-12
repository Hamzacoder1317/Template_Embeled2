using Microsoft.AspNetCore.Mvc;

namespace Template_Embeled.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminIndex()
        {
            return View();
        }
        public IActionResult Adminform()
        {
            return View();
        }
        public IActionResult Admintable()
        {
            return View();
        }
        public IActionResult Adminuser()
        {
            return View();
        }
    }
}
