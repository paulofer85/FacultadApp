using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FacultadAppSvc.Models
{
    public class MateriasCarrerasParameters
    {
        public int materiasCarrerasId { get; set; }

        public int carreraId { get; set; }

        public int materiaId { get; set; }
    }

    public class MateriasCarreras
    {
        [Key]
        public int MateriasCarrerasId { get; set; }

        [ForeignKey("Carrera")]
        [Column("CarreraFK")]
        public int CarreraId { get; set; }
        public Carreras Carrera{ get; set; }

        [ForeignKey("Materia")]
        [Column("MateriaFK")]
        public int MateriaId { get; set; }
        public Materias Materia { get; set; }
    }
}
