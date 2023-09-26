using Microsoft.AspNetCore.Mvc;

namespace FashionShop.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
