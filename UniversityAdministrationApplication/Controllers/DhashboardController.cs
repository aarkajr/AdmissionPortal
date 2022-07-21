using Microsoft.AspNetCore.Mvc;

namespace UniversityAdministrationApplication.Controllers
{
    public class DhashboardController : Controller
    {
        public IActionResult DhashboardPage()
        {
            return View();
        }
    }
}
