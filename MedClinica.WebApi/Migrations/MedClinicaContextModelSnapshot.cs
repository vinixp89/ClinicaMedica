﻿// <auto-generated />
using System;
using MedClinica.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MedClinica.WebApi.Migrations
{
    [DbContext(typeof(MedClinicaContext))]
    partial class MedClinicaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("MedClinica.WebApi.Models.Especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MedicoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("data")
                        .HasColumnType("TEXT");

                    b.Property<int?>("pacienteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("pacienteId");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("MedClinica.WebApi.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("MedClinica.WebApi.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Telefone")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("MedClinica.WebApi.Models.PacienteEspecialidade", b =>
                {
                    b.Property<int>("PacienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EspecialidadeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Paciente")
                        .HasColumnType("TEXT");

                    b.HasKey("PacienteId", "EspecialidadeId");

                    b.HasIndex("EspecialidadeId");

                    b.ToTable("PacienteEspecialidades");
                });

            modelBuilder.Entity("MedClinica.WebApi.Models.Especialidade", b =>
                {
                    b.HasOne("MedClinica.WebApi.Models.Medico", "medico")
                        .WithMany("Agendamentos")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedClinica.WebApi.Models.Paciente", "paciente")
                        .WithMany()
                        .HasForeignKey("pacienteId");
                });

            modelBuilder.Entity("MedClinica.WebApi.Models.PacienteEspecialidade", b =>
                {
                    b.HasOne("MedClinica.WebApi.Models.Especialidade", "Especialidade")
                        .WithMany("PacienteEspecialidades")
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedClinica.WebApi.Models.Paciente", null)
                        .WithMany("PacienteEspecialidade")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
