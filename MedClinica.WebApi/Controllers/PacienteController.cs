using MedClinica.WebApi.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MedClinica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly MedClinicaContext _context;

        public PacienteController(MedClinicaContext context) 
        
        {
            _context = context;
        
        }


        // GET: api/<Paciente>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Paciente>/5
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok (_context.Pacientes);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var paciente = _context.Pacientes.FirstOrDefault(a => a.Id == id);
            if (paciente == null) return BadRequest("aluno não foi encontrado ou a base está vazia");
            return Ok(_context.Pacientes);
        }

        [HttpGet("ByName")]
        public IActionResult GeByName(string nome , string Sobrenome) 
        {
            var paciente = _context.Pacientes.FirstOrDefault(a => a.Nome.Contains(nome) && a.Nome.Contains(Sobrenome));
            if (nome == null) return BadRequest("o nome do paciente não foi localizado");
            return Ok(_context.Pacientes);
        }

        // POST api/<Paciente>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Paciente>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Paciente>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
