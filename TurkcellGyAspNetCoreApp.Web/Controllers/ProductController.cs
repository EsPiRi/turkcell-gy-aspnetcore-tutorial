using Microsoft.AspNetCore.Mvc;
using TurkcellGyAspNetCoreApp.Web.Models;

namespace TurkcellGyAspNetCoreApp.Web.Controllers
{
	public class ProductController : Controller
	{
		private readonly ProductRepository _productRepository;
		public ProductController()
		{
			_productRepository=new ProductRepository();			
		}
		public IActionResult Index()
		{
			var products = _productRepository.GetAll();
			return View(products);
		}

		public IActionResult Remove(int id)
		{
			_productRepository.RemoveProduct(id);
			return RedirectToAction("Index");
		}

		public IActionResult Add()
		{
			return View();
		}

		public IActionResult Update(int id)
		{
			return View();
		}


	}
}
