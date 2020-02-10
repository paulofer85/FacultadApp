using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FacultadAppSvc.Models;

namespace FacultadAppSvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscripcionesController : ControllerBase
    {
        private readonly FacultadAppContext _context;

        public InscripcionesController(FacultadAppContext context)
        {
            _context = context;
        }

        // GET: api/Inscripciones
        [HttpGet]
        public IEnumerable<Inscripciones> GetInscripciones()
        {
            return _context.Inscripciones;
        }

        // GET: api/Inscripciones/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInscripciones([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inscripciones = await _context.Inscripciones.FindAsync(id);

            if (inscripciones == null)
            {
                return NotFound();
            }

            return Ok(inscripciones);
        }

        // PUT: api/Inscripciones/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInscripciones([FromRoute] int id, [FromBody] InscripcionParameters i)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != i.incripcionId)
            {
                return BadRequest();
            }
            var inscripciones = await _context.Inscripciones.FindAsync(id);
            _context.Entry(inscripciones).State = EntityState.Modified;

            try
            {
                inscripciones.AlumnoId= i.alumnoId;
                inscripciones.MateriaId= i.materiaId;
                inscripciones.Nota= i.nota;
                inscripciones.Estado= i.estado;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InscripcionesExists(id))
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

        // POST: api/Inscripciones
        [HttpPost]
        public async Task<IActionResult> PostInscripciones([FromBody] Inscripciones inscripciones)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Inscripciones.Add(inscripciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInscripciones", new { id = inscripciones.IncripcionId }, inscripciones);
        }

        // DELETE: api/Inscripciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInscripciones([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inscripciones = await _context.Inscripciones.FindAsync(id);
            if (inscripciones == null)
            {
                return NotFound();
            }

            _context.Inscripciones.Remove(inscripciones);
            await _context.SaveChangesAsync();

            return Ok(inscripciones);
        }

        private bool InscripcionesExists(int id)
        {
            return _context.Inscripciones.Any(e => e.IncripcionId == id);
        }
    }
}