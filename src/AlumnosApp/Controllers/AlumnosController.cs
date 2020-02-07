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
    public class AlumnosController : ControllerBase
    {
        private readonly AlumnoAppContext _context;

        public AlumnosController(AlumnoAppContext context)
        {
            _context = context;
        }

        // GET: api/Alumnos
        [HttpGet]
        public IEnumerable<Alumnos> GetAlumnos()
        {
            return _context.Alumnos;
        }

        // GET: api/Alumnos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlumnos([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var alumnos = await _context.Alumnos.FindAsync(id);

            if (alumnos == null)
            {
                return NotFound();
            }

            return Ok(alumnos);
        }

        // PUT: api/Alumnos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlumnos([FromRoute] int id, [FromBody] AlumnosParameters a)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != a.alumnoId)
            {
                return BadRequest();
            }

            Alumnos alumnos = _context.Alumnos.Find(id);
            _context.Entry(alumnos).State = EntityState.Modified;

            try
            {
                alumnos.Padron = a.padron;
                alumnos.Apellido = a.apellido;
                alumnos.Nombre = a.nombre;
                alumnos.Domicilio = a.domicilio;
                alumnos.CarreraId = a.carreraId;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlumnosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(alumnos);
        }

        // POST: api/Alumnos
        [HttpPost]
        public async Task<IActionResult> PostAlumnos([FromBody] AlumnosParameters a)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Alumnos alumnos = new Alumnos(a.padron, a.apellido, a.nombre, a.domicilio, a.carreraId);
            _context.Alumnos.Add(alumnos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlumnos", new { id = alumnos.AlumnoId }, alumnos);
        }

        // DELETE: api/Alumnos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlumnos([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var alumnos = await _context.Alumnos.FindAsync(id);
            if (alumnos == null)
            {
                return NotFound();
            }

            _context.Alumnos.Remove(alumnos);
            await _context.SaveChangesAsync();

            return Ok(alumnos);
        }

        private bool AlumnosExists(int id)
        {
            return _context.Alumnos.Any(e => e.AlumnoId == id);
        }
    }
}