using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Models;
using EcommerceAPI.ViewModels;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly EcommerceDbContext _context;

        public OrderController(EcommerceDbContext context)
        {
            _context = context;
        }

        // GET: api/Order
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderViewModel>>> GetTblOrders()
        {
          if (_context.TblOrders == null)
          {
              return NotFound();
          }
            return await _context.TblOrders.ToListAsync();
        }

        // GET: api/Order/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblOrder>> GetTblOrder(int id)
        {
          if (_context.TblOrders == null)
          {
              return NotFound();
          }
            var tblOrder = await _context.TblOrders.FindAsync(id);

            if (tblOrder == null)
            {
                return NotFound();
            }

            return tblOrder;
        }

        // PUT: api/Order/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblOrder(int id, TblOrder tblOrder)
        {
            if (id != tblOrder.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblOrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Order
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblOrder>> PostTblOrder(TblOrder tblOrder)
        {
          if (_context.TblOrders == null)
          {
              return Problem("Entity set 'EcommerceDbContext.TblOrders'  is null.");
          }
            _context.TblOrders.Add(tblOrder);
            await _context.SaveChangesAsync();

            var data = _context.TblOrders.Where(x => x.Id == tblOrder.Id).FirstOrDefault();
            data.OrderNo = "ORD" + data.Id;
            _context.TblOrders.Update(data);
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostTblOrder", new { OrderId=data.OrderNo });
        }

        // DELETE: api/Order/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblOrder(int id)
        {
            if (_context.TblOrders == null)
            {
                return NotFound();
            }
            var tblOrder = await _context.TblOrders.FindAsync(id);
            if (tblOrder == null)
            {
                return NotFound();
            }

            _context.TblOrders.Remove(tblOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblOrderExists(int id)
        {
            return (_context.TblOrders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
