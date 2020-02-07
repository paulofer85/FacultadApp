using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacultadAppSvc.Models
{
    public class MateriaParameters
    {
        public int materiaId { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public short cargaHoraria{ get; set; }

        public bool IsValid => (!string.IsNullOrEmpty(nombre));

    }

    public class Materias
    {
        [Key]
        public int MateriaId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public short CargaHoraria { get; set; }
        public List<Inscripciones> Inscripciones { get; set; }
    }
}