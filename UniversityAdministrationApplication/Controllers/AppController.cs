using Microsoft.AspNetCore.Mvc;

namespace UniversityAdministrationApplication.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Application()
        {
            return View();
        }
        public IActionResult process()
        {
            return View();
        }
        public IActionResult table()
        {
            return View();
        }
    }
}
