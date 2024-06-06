using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Inscripcioness.Models;

namespace Inscripcioness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiAnioCarreras1Controller : ControllerBase
    {
        private readonly InscripcionesContext _context;

        public ApiAnioCarreras1Controller(InscripcionesContext context)
        {
            _context = context;
        }

        // GET: api/ApiAnioCarreras1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnioCarrera>>> GetaniosCarreras()
        {
            return await _context.aniosCarreras.ToListAsync();
        }

        // GET: api/ApiAnioCarreras1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnioCarrera>> GetAnioCarrera(int id)
        {
            var anioCarrera = await _context.aniosCarreras.FindAsync(id);

            if (anioCarrera == null)
            {
                return NotFound();
            }

            return anioCarrera;
        }

        // PUT: api/ApiAnioCarreras1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnioCarrera(int id, AnioCarrera anioCarrera)
        {
            if (id != anioCarrera.Id)
            {
                return BadRequest();
            }

            _context.Entry(anioCarrera).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnioCarreraExists(id))
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

        // POST: api/ApiAnioCarreras1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnioCarrera>> PostAnioCarrera(AnioCarrera anioCarrera)
        {
            _context.aniosCarreras.Add(anioCarrera);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnioCarrera", new { id = anioCarrera.Id }, anioCarrera);
        }

        // DELETE: api/ApiAnioCarreras1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnioCarrera(int id)
        {
            var anioCarrera = await _context.aniosCarreras.FindAsync(id);
            if (anioCarrera == null)
            {
                return NotFound();
            }

            _context.aniosCarreras.Remove(anioCarrera);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnioCarreraExists(int id)
        {
            return _context.aniosCarreras.Any(e => e.Id == id);
        }
    }
}
