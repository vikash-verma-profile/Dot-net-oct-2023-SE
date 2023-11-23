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
    public class LoginController : ControllerBase
    {
        private readonly EcommerceDbContext _context;

        public LoginController(EcommerceDbContext context)
        {
            _context = context;
        }

        // GET: api/Login
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblLogin>>> GetTblLogins()
        {
          if (_context.TblLogins == null)
          {
              return NotFound();
          }
            return await _context.TblLogins.ToListAsync();
        }

        // GET: api/Login/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblLogin>> GetTblLogin(int id)
        {
          if (_context.TblLogins == null)
          {
              return NotFound();
          }
            var tblLogin = await _context.TblLogins.FindAsync(id);

            if (tblLogin == null)
            {
                return NotFound();
            }

            return tblLogin;
        }

        // PUT: api/Login/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblLogin(int id, TblLogin tblLogin)
        {
            if (id != tblLogin.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblLogin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblLoginExists(id))
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

        // POST: api/Login
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("register-user")]
        public async Task<ActionResult<TblLogin>> Register(TblLogin tblLogin)
        {
          if (_context.TblLogins == null)
          {
              return Problem("Entity set 'EcommerceDbContext.TblLogins'  is null.");
          }
            _context.TblLogins.Add(tblLogin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblLogin", new { isLogin = true, Message = "registered Successfully", UserId= tblLogin.Id });
        }

        // POST: api/Login
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("login-user")]
        public async Task<ActionResult<TblLogin>> PostTblLogin(TblLogin tblLogin)
        {
           if(_context.TblLogins.Any(x=>x.UserName==tblLogin.UserName && x.Password==tblLogin.Password))
            {
                var data = _context.TblLogins.Where(x => x.UserName == tblLogin.UserName && x.Password == tblLogin.Password).FirstOrDefault();
                return Ok(new {isLogin=true,isAdmin= data.IsAdmin, Message="validated User", UserId = data.Id });
            }
            else
            {
                return Ok(new { isLogin = false, Message = "not a valid User" });
            }
        }
        // DELETE: api/Login/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblLogin(int id)
        {
            if (_context.TblLogins == null)
            {
                return NotFound();
            }
            var tblLogin = await _context.TblLogins.FindAsync(id);
            if (tblLogin == null)
            {
                return NotFound();
            }

            _context.TblLogins.Remove(tblLogin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblLoginExists(int id)
        {
            return (_context.TblLogins?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
