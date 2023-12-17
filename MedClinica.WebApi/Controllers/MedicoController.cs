using MedClinica.WebApi.Data;
using MedClinica.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MedClinica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly MedClinicaContext _context;

        public MedicoController(MedClinicaContext context) 

        {
            _context = context;
        
        }

        // GET: api/<Medico>
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_context.Medicos);
        }

        // GET api/<Medico>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id, Medico medico )
        {
            // 
            var med = _context.Medicos.AsNoTracking().FirstOrDefault(m => m.Id == id);
            _context.SaveChanges();
            if (medico == null) BadRequest("Médico não encontrado");

            return Ok(medico);///
        }

        // POST api/<Medico>
        [HttpPost]
        public IActionResult Post(int id, Medico medico)
        {
            var med = _context.Medicos.AsNoTracking().FirstOrDefault( m => m.Id == id);
            _context.SaveChanges();
            if (medico == null) BadRequest("medico não localizado");
            return Ok(medico);

        }

        // PUT api/<Medico>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Medico medico)
        {
            var med = _context.Pacientes.AsNoTracking().FirstOrDefault(a => a.Id == id);
            _context.SaveChanges();
            if (medico == null) return BadRequest("paciente não localizado");

            _context.Update(medico);
            _context.SaveChanges();
            return Ok(medico);
        }

        // DELETE api/<Medico>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var medico = _context.Pacientes.FirstOrDefault(a => a.Id == id);
            if (medico == null) BadRequest("medico não encontrado");

            _context.Remove(medico);
            _context.SaveChanges();



        }
    }
}
