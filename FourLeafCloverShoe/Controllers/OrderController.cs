using Microsoft.AspNetCore.Mvc;

namespace FourLeafCloverShoe.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
