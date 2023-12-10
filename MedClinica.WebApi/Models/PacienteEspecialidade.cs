namespace MedClinica.WebApi.Models
{
    public class PacienteEspecialidade
    {

        public int PacienteId { get; set; }

        public string Paciente { get; set; }

        public int EspecialidadeId { get; set; }

        public Especialidade Especialidade { get; set; }


        public PacienteEspecialidade()
        {

        }
        public PacienteEspecialidade(int pacienteId, int EspecialidadeId)
        {
            PacienteId = pacienteId;

            EspecialidadeId = EspecialidadeId;

        }
    }
}