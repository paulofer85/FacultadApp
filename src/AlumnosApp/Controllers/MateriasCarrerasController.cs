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
    public class MateriasCarrerasController : ControllerBase
    {
        private readonly AlumnoAppContext _context;

        public MateriasCarrerasController(AlumnoAppContext context)
        {
            _context = context;
        }

        // GET: api/MateriasCarreras
        [HttpGet]
        public IEnumerable<MateriasCarreras> GetMateriasCarreras()
        {
            return _context.MateriasCarreras;
        }

        // GET: api/MateriasCarreras/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMateriasCarreras([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var materiasCarreras = await _context.MateriasCarreras.FindAsync(id);

            if (materiasCarreras == null)
            {
                return NotFound();
            }

            return Ok(materiasCarreras);
        }

        // PUT: api/MateriasCarreras/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMateriasCarreras([FromRoute] int id, [FromBody] MateriasCarrerasParameters mc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mc.materiasCarrerasId)
            {
                return BadRequest();
            }


            var materiasCarreras = await _context.MateriasCarreras.FindAsync(id);
            _context.Entry(materiasCarreras).State = EntityState.Modified;

            try
            {
                materiasCarreras.CarreraId = mc.carreraId;
                materiasCarreras.MateriaId = mc.materiaId;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MateriasCarrerasExists(id))
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

        // POST: api/MateriasCarreras
        [HttpPost]
        public async Task<IActionResult> PostMateriasCarreras([FromBody] MateriasCarreras materiasCarreras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MateriasCarreras.Add(materiasCarreras);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMateriasCarreras", new { id = materiasCarreras.MateriasCarrerasId }, materiasCarreras);
        }

        // DELETE: api/MateriasCarreras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMateriasCarreras([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var materiasCarreras = await _context.MateriasCarreras.FindAsync(id);
            if (materiasCarreras == null)
            {
                return NotFound();
            }

            _context.MateriasCarreras.Remove(materiasCarreras);
            await _context.SaveChangesAsync();

            return Ok(materiasCarreras);
        }

        private bool MateriasCarrerasExists(int id)
        {
            return _context.MateriasCarreras.Any(e => e.MateriasCarrerasId == id);
        }
    }
}