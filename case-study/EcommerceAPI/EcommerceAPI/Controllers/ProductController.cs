using EcommerceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        EcommerceDbContext db = new EcommerceDbContext();
        [HttpGet]
        public IEnumerable<TblProduct> Get()
        {
            return db.TblProducts;
        }
    }
}
