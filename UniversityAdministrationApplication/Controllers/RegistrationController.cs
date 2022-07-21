using Microsoft.AspNetCore.Mvc;

namespace UniversityAdministrationApplication.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
