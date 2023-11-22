using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebapp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
