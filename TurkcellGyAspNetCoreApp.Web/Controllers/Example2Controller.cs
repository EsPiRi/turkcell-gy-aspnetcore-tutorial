using Microsoft.AspNetCore.Mvc;

namespace TurkcellGyAspNetCoreApp.Web.Controllers
{
    public class Example2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NoLayout()
        {
            return View();
        }
    }
}
