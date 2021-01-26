using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FigureWebAPI.Models;

namespace FigureWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FigureController : ControllerBase
    {
        private readonly FigureContext _context;

        public FigureController(FigureContext context)
        {
            _context = context;
            
        }

        // GET: api/Figure
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CreateFigure>>> GetCreateFigures()
        {

            return await _context.Figures.ToListAsync();
        }

        // GET: api/Figure/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CreateFigure>> GetCreateFigure(long id)
        {
            var createFigure = await _context.Figures.FindAsync(id);

            if (createFigure == null)
            {
                return NotFound();
            }

            return createFigure;
        }

        // PUT: api/Figure/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCreateFigure(long id, CreateFigure createFigure)
        {
            if (id != createFigure.Id)
            {
                return BadRequest();
            }

            _context.Entry(createFigure).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreateFigureExists(id))
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

        // POST: api/Figure
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CreateFigure>> PostCreateFigure(CreateFigure createFigure)
        {
            _context.Figures.Add(createFigure);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCreateFigure), new { id = createFigure.Id }, createFigure);
        }

        // DELETE: api/Figure/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCreateFigure(long id)
        {
            var createFigure = await _context.Figures.FindAsync(id);
            if (createFigure == null)
            {
                return NotFound();
            }

            _context.Figures.Remove(createFigure);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CreateFigureExists(long id)
        {
            return _context.Figures.Any(e => e.Id == id);
        }
    }
}
