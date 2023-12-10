using System.Collections.Generic;
using System;

namespace MedClinica.WebApi.Models
{
    public class Especialidade
    {

        public DateTime data { get; set; }

        public int Id { get; set; }

        public Paciente paciente { get; set; }

        public int MedicoId { get; set; }

        public Medico medico { get; set; }

        public IEnumerable<PacienteEspecialidade> PacienteEspecialidades { get; set; }

        public Especialidade() { }

        public Especialidade(DateTime data, Paciente paciente, int medicoId)
        {
            this.data = data;
            this.paciente = paciente;
            MedicoId = medicoId;
        }
    }
}
