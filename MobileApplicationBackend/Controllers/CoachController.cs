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
    public class CoachController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CoachController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Coach
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coach>>> GetCoach()
        {
          if (_context.Coach == null)
          {
              return NotFound();
          }
            return await _context.Coach.ToListAsync();
        }

        // GET: api/Coach/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Coach>> GetCoach(int id)
        {
          if (_context.Coach == null)
          {
              return NotFound();
          }
            var coach = await _context.Coach.FindAsync(id);

            if (coach == null)
            {
                return NotFound();
            }

            return coach;
        }

        // PUT: api/Coach/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCoach(int id, Coach coach)
        {
            if (id != coach.Id)
            {
                return BadRequest();
            }

            _context.Entry(coach).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoachExists(id))
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

        // POST: api/Coach
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Coach>> PostCoach(Coach coach)
        {
          if (_context.Coach == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Coach'  is null.");
          }
          _context.Coach.Add(coach);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCoach", new { id = coach.Id }, coach);
        }

        // DELETE: api/Coach/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCoach(int id)
        {
            if (_context.Coach == null)
            {
                return NotFound();
            }
            var coach = await _context.Coach.FindAsync(id);
            if (coach == null)
            {
                return NotFound();
            }

            _context.Coach.Remove(coach);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CoachExists(int id)
        {
            return (_context.Coach?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
