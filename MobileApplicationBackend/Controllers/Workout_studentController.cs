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
    public class Workout_studentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Workout_studentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Workout_student
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Workout_student_link>>> GetWorkout_student_link()
        {
          if (_context.Workout_student_link == null)
          {
              return NotFound();
          }
            return await _context.Workout_student_link.ToListAsync();
        }

        // GET: api/Workout_student/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Workout_student_link>> GetWorkout_student_link(int id)
        {
          if (_context.Workout_student_link == null)
          {
              return NotFound();
          }
            var workout_student_link = await _context.Workout_student_link.FindAsync(id);

            if (workout_student_link == null)
            {
                return NotFound();
            }

            return workout_student_link;
        }

        // PUT: api/Workout_student/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkout_student_link(int id, Workout_student_link workout_student_link)
        {
            if (id != workout_student_link.Id)
            {
                return BadRequest();
            }

            _context.Entry(workout_student_link).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Workout_student_linkExists(id))
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

        // POST: api/Workout_student
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Workout_student_link>> PostWorkout_student_link(Workout_student_link workout_student_link)
        {
          if (_context.Workout_student_link == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Workout_student_link'  is null.");
          }
            _context.Workout_student_link.Add(workout_student_link);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkout_student_link", new { id = workout_student_link.Id }, workout_student_link);
        }

        // DELETE: api/Workout_student/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkout_student_link(int id)
        {
            if (_context.Workout_student_link == null)
            {
                return NotFound();
            }
            var workout_student_link = await _context.Workout_student_link.FindAsync(id);
            if (workout_student_link == null)
            {
                return NotFound();
            }

            _context.Workout_student_link.Remove(workout_student_link);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Workout_student_linkExists(int id)
        {
            return (_context.Workout_student_link?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
