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
    public class Tournament_studentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Tournament_studentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Tournament_student
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tournament_student_link>>> GetTournament_student_link()
        {
          if (_context.Tournament_student_link == null)
          {
              return NotFound();
          }
            return await _context.Tournament_student_link.ToListAsync();
        }

        // GET: api/Tournament_student/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tournament_student_link>> GetTournament_student_link(int id)
        {
          if (_context.Tournament_student_link == null)
          {
              return NotFound();
          }
            var tournament_student_link = await _context.Tournament_student_link.FindAsync(id);

            if (tournament_student_link == null)
            {
                return NotFound();
            }

            return tournament_student_link;
        }

        // PUT: api/Tournament_student/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTournament_student_link(int id, Tournament_student_link tournament_student_link)
        {
            if (id != tournament_student_link.Id)
            {
                return BadRequest();
            }

            _context.Entry(tournament_student_link).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tournament_student_linkExists(id))
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

        // POST: api/Tournament_student
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tournament_student_link>> PostTournament_student_link(Tournament_student_link tournament_student_link)
        {
          if (_context.Tournament_student_link == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Tournament_student_link'  is null.");
          }
            _context.Tournament_student_link.Add(tournament_student_link);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTournament_student_link", new { id = tournament_student_link.Id }, tournament_student_link);
        }

        // DELETE: api/Tournament_student/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTournament_student_link(int id)
        {
            if (_context.Tournament_student_link == null)
            {
                return NotFound();
            }
            var tournament_student_link = await _context.Tournament_student_link.FindAsync(id);
            if (tournament_student_link == null)
            {
                return NotFound();
            }

            _context.Tournament_student_link.Remove(tournament_student_link);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Tournament_student_linkExists(int id)
        {
            return (_context.Tournament_student_link?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
