using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacultadAppSvc.Models
{
    public static class DbInitializer
    {
        public static void Initialize(FacultadAppContext context)
        {
            context.Database.EnsureCreated();

            //Elements in DB?
            if (context.Alumnos.Any())
            {
                return;   // DB has been seeded
            }


            //Seed Carreras
            var carreras = new Carreras[]
            {
                new Carreras{Nombre="Ing. en Informática", Titulo="Ingeniero/a"},
            };
            foreach (Carreras c in carreras)
            {
                context.Carreras.Add(c);
            }
            context.SaveChanges();

            //Seed Alumnos
            var alumnos = new Alumnos[]
            {
                new Alumnos{Nombre="Carl",Apellido="Sagan",Domicilio="Av. Siempre viva 314", Padron="85847", CarreraId=1},
                new Alumnos{Nombre="Mario",Apellido="Escher",Domicilio="Av. Siempre viva 314",Padron="85848", CarreraId=1},
                new Alumnos{Nombre="Pirulo",Apellido="En el Bosque",Domicilio="Av. Siempre viva 314",Padron="85849", CarreraId=1},
            };
            foreach (Alumnos a in alumnos)
            {
                context.Alumnos.Add(a);
            }
            context.SaveChanges();

            //Seed Materias
            var materias = new Materias[]
            {
                new Materias{Nombre ="Algoritmos I",CargaHoraria=8,Codigo="60.50"},
                new Materias{Nombre ="Algoritmos II",CargaHoraria=8,Codigo="60.51"},
                new Materias{Nombre ="Algoritmos III",CargaHoraria=8,Codigo="60.52"},
                new Materias{Nombre ="Algoritmos IV",CargaHoraria=8,Codigo="60.53"},
                new Materias{Nombre ="Algoritmos V",CargaHoraria=8,Codigo="60.54"}
            };
            foreach (Materias c in materias)
            {
                context.Materias.Add(c);
            }
            context.SaveChanges();


            //Seed Inscripciones
            var incripciones = new Inscripciones[]
            {
            new Inscripciones{AlumnoId=1,MateriaId=1,Nota=9,Estado=1},
            };
            foreach (Inscripciones i in incripciones)
            {
                context.Inscripciones.Add(i);
            }
            context.SaveChanges();

            //Seed MateriasCarreras
            var materiasCarreras = new MateriasCarreras[]
            {
                new MateriasCarreras{CarreraId=1,MateriaId=1},
                new MateriasCarreras{CarreraId=1,MateriaId=2},
                new MateriasCarreras{CarreraId=1,MateriaId=3},
                new MateriasCarreras{CarreraId=1,MateriaId=4},
                new MateriasCarreras{CarreraId=1,MateriaId=5},
            };
            foreach (MateriasCarreras mc in materiasCarreras)
            {
                context.MateriasCarreras.Add(mc);
            }
            context.SaveChanges();
        }
    }
}
