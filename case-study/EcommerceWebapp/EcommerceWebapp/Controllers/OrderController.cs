using EcommerceWebapp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace EcommerceWebapp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var data = client.GetAsync("http://localhost:5016/api/Order").Result.Content.
                ReadAsStringAsync().Result;
            var orderlist = JsonConvert.DeserializeObject<IEnumerable<OrderViewModel>>(data);
            return View(orderlist);
        }
        public IActionResult BuyNow(int Id)
        {
            HttpClient client = new HttpClient();
            var OrderDetails = new OrderViewModel() { ProductId=Id,UserId= HttpContext.Session.GetString("userid"),Quantity=1 };
            var content = new StringContent(JsonConvert.SerializeObject(OrderDetails), Encoding.UTF8, "application/json");
            var data = client.PostAsync("http://localhost:5016/api/Order", content).Result.Content.
                ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<OrderResponseViewModel>(data);
            if (!string.IsNullOrEmpty(response.OrderId))
            {
                return RedirectToAction("Index", "Order");
            }
            else
            {
                return View();
            }
        }
    }
}
