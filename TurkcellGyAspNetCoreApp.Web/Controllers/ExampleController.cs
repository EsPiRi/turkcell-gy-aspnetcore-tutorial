using Microsoft.AspNetCore.Mvc;

namespace TurkcellGyAspNetCoreApp.Web.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            var productList=new List<Product>()
            {
                new(){Id=1,Name="Kalem"},
                new(){Id=2,Name="Defter"},
                new(){Id=3,Name="Silgi"}
            };
            
            
            return View(productList);
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
