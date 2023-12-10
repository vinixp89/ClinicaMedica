using MedClinica.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MedClinica.WebApi.Data
{
    public class MedClinicaContext : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<PacienteEspecialidade> PacienteEspecialidades { get; set; }

        public MedClinicaContext(DbContextOptions<MedClinicaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PacienteEspecialidade>().HasKey(AD => new { AD.PacienteId, AD.EspecialidadeId });


        }
    }
}
