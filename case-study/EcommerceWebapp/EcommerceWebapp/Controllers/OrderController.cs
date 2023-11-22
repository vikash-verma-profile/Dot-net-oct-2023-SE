using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebapp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
