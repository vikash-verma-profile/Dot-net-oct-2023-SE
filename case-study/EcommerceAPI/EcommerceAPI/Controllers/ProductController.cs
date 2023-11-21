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
        [HttpPost]
        public IActionResult Post(TblProduct product)
        {
            db.TblProducts.Add(product);
            db.SaveChanges();
            return Ok("your record is being added successfully");
        }
        [HttpPut]
        public IActionResult Put(TblProduct product)
        {
            db.TblProducts.Update(product);
            db.SaveChanges();
            return Ok("your record is being updated successfully");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
           var product=db.TblProducts.Where(x=>x.Id==id).FirstOrDefault();
            if (product != null)
            {
                db.TblProducts.Remove(product);
                db.SaveChanges();
                return Ok("your record is being deleted successfully");
            }
            else
            {
                return Ok("No record found with this ID.");
            }
        }
    }
}
