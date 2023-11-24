using EcommerceWebapp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Headers;
namespace EcommerceWebapp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var token = HttpContext.Session.GetString("token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            if (HttpContext.Session.GetString("isAdmin") == "1")
            {
              
                var data = client.GetAsync("http://localhost:5016/api/Order/get-all-orders").Result.Content.
                    ReadAsStringAsync().Result;
                var orderlist = JsonConvert.DeserializeObject<IEnumerable<OrderViewModel>>(data);
                return View(orderlist);
            }
            else
            {
                var userId = HttpContext.Session.GetString("userid");
                var data = client.GetAsync("http://localhost:5016/api/Order/get-orders-by-id?Id="+ userId).Result.Content.
                    ReadAsStringAsync().Result;
                var orderlist = JsonConvert.DeserializeObject<IEnumerable<OrderViewModel>>(data);
                return View(orderlist);
            }
           
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
