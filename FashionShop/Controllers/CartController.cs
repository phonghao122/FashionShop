using Microsoft.AspNetCore.Mvc;

namespace FashionShop.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
