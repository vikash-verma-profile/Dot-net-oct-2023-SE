using EcommerceWebapp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace EcommerceWebapp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(LoginViewModel login) 
        {
            HttpClient client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(login),Encoding.UTF8,"application/json");
            var data = client.PostAsync("http://localhost:5016/api/Login/login-user", content).Result.Content.
                ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<ResponseViewModel>(data);
            if (response.isLogin)
            {
                HttpContext.Session.SetString("email",login.UserName);
                HttpContext.Session.SetString("userid", response.UserId);
                HttpContext.Session.SetString("isAdmin", response.isAdmin.ToString());
                HttpContext.Session.SetString("token", response.token);
                return RedirectToAction("Index", "Order");
            }
            else
            {
                return View();
            }
        }
        public JsonResult CheckLogin()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("email")))
            {
                return Json(new {username=""});
            }
            else
            {
                return Json(new { username = HttpContext.Session.GetString("email") });
            }
        }
        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
