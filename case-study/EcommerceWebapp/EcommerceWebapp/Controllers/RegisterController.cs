﻿using EcommerceWebapp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace EcommerceWebapp.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register(LoginViewModel login)
        {
            HttpClient client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8, "application/json");
            var data = client.PostAsync("http://localhost:5016/api/Login/register-user", content).Result.Content.
                ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<ResponseViewModel>(data);
            if (response.isLogin)
            {
                HttpContext.Session.SetString("email", login.UserName);
                HttpContext.Session.SetString("userid", response.UserId);
                return RedirectToAction("Index", "Order");
            }
            else
            {
                return View();
            }
        }
    }
}
