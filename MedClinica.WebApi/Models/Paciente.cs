using System.Collections.Generic;

namespace MedClinica.WebApi.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public int Telefone { get; set; }


        public IEnumerable<PacienteEspecialidade> PacienteEspecialidade { get; set; }

        public Paciente() { }

        public Paciente(int id, string nome, string sobrenome, int telefone)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
    }
}
