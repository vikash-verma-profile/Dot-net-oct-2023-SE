using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Models;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly EcommerceDbContext _context;

        public CategoryController(EcommerceDbContext context)
        {
            _context = context;
        }

        // GET: api/Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblCategory>>> GetTblCategories()
        {
          if (_context.TblCategories == null)
          {
              return NotFound();
          }
            return await _context.TblCategories.ToListAsync();
        }

        // GET: api/Category/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblCategory>> GetTblCategory(int id)
        {
          if (_context.TblCategories == null)
          {
              return NotFound();
          }
            var tblCategory = await _context.TblCategories.FindAsync(id);

            if (tblCategory == null)
            {
                return NotFound();
            }

            return tblCategory;
        }

        // PUT: api/Category/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblCategory(int id, TblCategory tblCategory)
        {
            if (id != tblCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCategoryExists(id))
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

        // POST: api/Category
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblCategory>> PostTblCategory(TblCategory tblCategory)
        {
          if (_context.TblCategories == null)
          {
              return Problem("Entity set 'EcommerceDbContext.TblCategories'  is null.");
          }
            _context.TblCategories.Add(tblCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblCategory", new { id = tblCategory.Id }, tblCategory);
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblCategory(int id)
        {
            if (_context.TblCategories == null)
            {
                return NotFound();
            }
            var tblCategory = await _context.TblCategories.FindAsync(id);
            if (tblCategory == null)
            {
                return NotFound();
            }

            _context.TblCategories.Remove(tblCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblCategoryExists(int id)
        {
            return (_context.TblCategories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
