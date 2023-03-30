using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileApplicationBackend.Context;
using MobileApplicationBackend.Models;

namespace MobileApplicationBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Seminar_studentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Seminar_studentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Seminar_student
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seminar_student_link>>> GetSeminar_student_link()
        {
          if (_context.Seminar_student_link == null)
          {
              return NotFound();
          }
            return await _context.Seminar_student_link.ToListAsync();
        }

        // GET: api/Seminar_student/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Seminar_student_link>> GetSeminar_student_link(int id)
        {
          if (_context.Seminar_student_link == null)
          {
              return NotFound();
          }
            var seminar_student_link = await _context.Seminar_student_link.FindAsync(id);

            if (seminar_student_link == null)
            {
                return NotFound();
            }

            return seminar_student_link;
        }

        // PUT: api/Seminar_student/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeminar_student_link(int id, Seminar_student_link seminar_student_link)
        {
            if (id != seminar_student_link.Id)
            {
                return BadRequest();
            }

            _context.Entry(seminar_student_link).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Seminar_student_linkExists(id))
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

        // POST: api/Seminar_student
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Seminar_student_link>> PostSeminar_student_link(Seminar_student_link seminar_student_link)
        {
          if (_context.Seminar_student_link == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Seminar_student_link'  is null.");
          }
            _context.Seminar_student_link.Add(seminar_student_link);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSeminar_student_link", new { id = seminar_student_link.Id }, seminar_student_link);
        }

        // DELETE: api/Seminar_student/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeminar_student_link(int id)
        {
            if (_context.Seminar_student_link == null)
            {
                return NotFound();
            }
            var seminar_student_link = await _context.Seminar_student_link.FindAsync(id);
            if (seminar_student_link == null)
            {
                return NotFound();
            }

            _context.Seminar_student_link.Remove(seminar_student_link);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Seminar_student_linkExists(int id)
        {
            return (_context.Seminar_student_link?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
