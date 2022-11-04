using Microsoft.AspNetCore.Mvc;

namespace TurkcellGyAspNetCoreApp.Web.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.name = "Asp.Net Core";
            //ViewBag.surname = "sfdsf";
            ViewData["age"] = 28;
            ViewData["names"] = new List<string>() { "ahmet", "mehmet", "hasan" };
            ViewBag.person = new { Id = 1, name = "ahmet", age = 23 };
            //ViewBag.name=new List<string>() { "a","b","c"};
            TempData["surname"] = "sezgin";
            
            return View();
        }
        public IActionResult Index3()
        {
            var surname = TempData["surname"];
            return View();            
            
        }

        public IActionResult Index2()
        {
            //veritabanı işlemleri
            return RedirectToAction("Index","Example");
        }

        public IActionResult ParameterView(int id)
        {
            return RedirectToAction("JsonResultParameter", "Example", new { id = id });
        }
        public IActionResult JsonResultParameter(int id)
        {
            return Json(new { Id =id });
        }

        public IActionResult ContentResult()
        {
            return Content("ContentResult");
        }

        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, name = "kalem 1", price = 100 });
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}
