using System.Collections.Generic;

namespace MedClinica.WebApi.Models
{
    public class Medico
    {

        public string Nome { get; set; }


        public int Id { get; set; }

        public IEnumerable<Especialidade> Agendamentos { get; set; }



        public Medico() { }

        public Medico(string nome, int id)
        {
            Nome = nome;
            Id = id;

        }
    }
}
