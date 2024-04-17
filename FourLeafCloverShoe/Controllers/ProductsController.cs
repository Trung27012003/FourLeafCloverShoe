using Microsoft.AspNetCore.Mvc;

namespace FourLeafCloverShoe.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
