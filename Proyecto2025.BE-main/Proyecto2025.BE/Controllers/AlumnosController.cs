using Proyecto2025.BE.Data;
using Proyecto2025.BE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto2025.BE.Controllers
{ 

    [ApiController]
    [Route("api/[controller]")]
    public class AlumnosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlumnosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alumno>>> GetAlumnos()
        {
            return await _context.Alumnos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Alumno>> GetAlumno(int id)
        {
            var alumno = await _context.Alumnos.FindAsync(id);
            if (alumno == null)
                return NotFound();

            return alumno;
        }

        [HttpPost]
        public async Task<ActionResult<Alumno>> PostAlumno([FromBody] Alumno alumno)
        {
            _context.Alumnos.Add(alumno);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAlumno), new { id = alumno.Id }, alumno);
        }
        [HttpPut("{id}")]
public async Task<IActionResult> PutAlumno(int id, Alumno alumno)
{
    if (id != alumno.Id)
        return BadRequest();

    var alumnoExistente = await _context.Alumnos.FindAsync(id);
    if (alumnoExistente == null)
        return NotFound();

    // Actualizar propiedades
    alumnoExistente.Nombre = alumno.Nombre;
    alumnoExistente.Apellido = alumno.Apellido;
    alumnoExistente.FechaNacimiento = alumno.FechaNacimiento;
    alumnoExistente.CorreoElectronico = alumno.CorreoElectronico;
    alumnoExistente.Matricula = alumno.Matricula;

    try
    {
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        return StatusCode(500, "Error de concurrencia al actualizar el alumno.");
    }

    return NoContent();
}

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlumno(int id)
        {
            var alumno = await _context.Alumnos.FindAsync(id);
            if (alumno == null)
                return NotFound();

            _context.Alumnos.Remove(alumno);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}