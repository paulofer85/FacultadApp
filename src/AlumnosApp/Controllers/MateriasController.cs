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
    public class MateriasController : ControllerBase
    {
        private readonly FacultadAppContext _context;

        public MateriasController(FacultadAppContext context)
        {
            _context = context;
        }

        // GET: api/Materias
        [HttpGet]
        public IEnumerable<Materias> GetMaterias()
        {
            return _context.Materias;
        }

        // GET: api/Materias/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMaterias([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var materias = await _context.Materias.FindAsync(id);

            if (materias == null)
            {
                return NotFound();
            }

            return Ok(materias);
        }

        // PUT: api/Materias/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaterias([FromRoute] int id, [FromBody] MateriaParameters m)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != m.materiaId)
            {
                return BadRequest();
            }

            var materias = await _context.Materias.FindAsync(id);
            _context.Entry(materias).State = EntityState.Modified;

            try
            {
                materias.Nombre = m.nombre;
                materias.Codigo = m.codigo;
                materias.CargaHoraria= m.cargaHoraria;

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MateriasExists(id))
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

        // POST: api/Materias
        [HttpPost]
        public async Task<IActionResult> PostMaterias([FromBody] Materias materias)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Materias.Add(materias);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMaterias", new { id = materias.MateriaId }, materias);
        }

        // DELETE: api/Materias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMaterias([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var materias = await _context.Materias.FindAsync(id);
            if (materias == null)
            {
                return NotFound();
            }

            _context.Materias.Remove(materias);
            await _context.SaveChangesAsync();

            return Ok(materias);
        }

        private bool MateriasExists(int id)
        {
            return _context.Materias.Any(e => e.MateriaId == id);
        }
    }
}