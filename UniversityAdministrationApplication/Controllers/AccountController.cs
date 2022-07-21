using Microsoft.AspNetCore.Mvc;

namespace UniversityAdministrationApplication.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Sign()
        {
            return View();
        }
        public IActionResult Forget()
        {
            return View();
        }
    }
}
