using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacultadAppSvc.Models;

namespace FacultadAppSvc.Models
{
    public class AlumnoAppContext : DbContext
    {
        public AlumnoAppContext(DbContextOptions<AlumnoAppContext> options) : base(options)
        {
        }
        public virtual DbSet<Carreras> Carreras { get; set; }
        public virtual DbSet<Alumnos> Alumnos { get; set; }
        public virtual DbSet<Inscripciones> Inscripciones { get; set; }
        public virtual DbSet<Materias> Materias { get; set; }
        public virtual DbSet<MateriasCarreras> MateriasCarreras { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Alumnos>().ToTable("Alumnos");
            modelBuilder.Entity<Inscripciones>().ToTable("Inscripciones");
            modelBuilder.Entity<Carreras>().ToTable("Carreras");
            modelBuilder.Entity<Materias>().ToTable("Materias");
            modelBuilder.Entity<MateriasCarreras>().ToTable("MateriasCarreras");

        }

    }
}
