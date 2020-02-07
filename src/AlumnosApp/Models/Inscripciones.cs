using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacultadAppSvc.Models
{

    public class InscripcionParameters
    {
        public int incripcionId { get; set; }
        public short nota { get; set; }
        public short estado { get; set; }
        public int alumnoId { get; set; }
        public int materiaId { get; set; }
    }

    public class Inscripciones
    {
        [Key]
        public int IncripcionId { get; set; }

        public short Nota { get; set; }

        public short Estado { get; set; }

        [ForeignKey("Alumno")]
        [Column("AlumnoFK")]
        public int AlumnoId { get; set; }
        public Alumnos Alumno { get; set; }

        [ForeignKey("Materia")]
        [Column("MateriaFK")]
        public int MateriaId { get; set; }
        public Materias Materia { get; set; }

    }
}