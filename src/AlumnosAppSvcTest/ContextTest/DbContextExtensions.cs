using FacultadAppSvc.Models;
using System;
using System.Collections.Generic;
using System.Text;



namespace FacultadAppSvc.ContextTest
{
    public static class DbContextExtensions
    {
        public static void Seed(this FacultadAppContext dbContext)
        {
            dbContext.Carreras.Add(new Carreras
            {
                Nombre = "Ing. en Informática",
                Titulo = "Ingeniero/a"
            });


            dbContext.Alumnos.Add(new Alumnos
            {
                Nombre = "Pedro",
                Apellido = "Almodovar",
                CarreraId = 1,
                Domicilio = "Av. Siempre viva 123",
                Padron = "85847"
            });
            dbContext.Alumnos.Add(new Alumnos
            {
                Nombre = "Alex",
                Apellido = "De la Iglesia",
                CarreraId = 1,
                Domicilio = "Av. Siempre viva 123",
                Padron = "84700"
            });

            dbContext.Materias.Add(new Materias
            {
                CargaHoraria = 12,
                Codigo = "65.12",
                Nombre = "Algoritmos y programación I",
            });
            dbContext.Materias.Add(new Materias
            {
                CargaHoraria = 12,
                Codigo = "65.13",
                Nombre = "Algoritmos y programación II",
            });
            dbContext.Materias.Add(new Materias
            {
                CargaHoraria = 12,
                Codigo = "65.14",
                Nombre = "Algoritmos y programación III",
            });

            dbContext.Inscripciones.Add(new Inscripciones
            {
                MateriaId = 1,
                AlumnoId = 1
            });
            dbContext.Inscripciones.Add(new Inscripciones
            {
                MateriaId = 1,
                AlumnoId = 2
            });

            dbContext.MateriasCarreras.Add(new MateriasCarreras
            {
                CarreraId = 1,
                MateriaId = 1
            }); dbContext.MateriasCarreras.Add(new MateriasCarreras
            {
                CarreraId = 1,
                MateriaId = 2
            });
            dbContext.MateriasCarreras.Add(new MateriasCarreras
            {
                CarreraId = 1,
                MateriaId = 3
            });

            dbContext.SaveChanges();
        }
    }
}

