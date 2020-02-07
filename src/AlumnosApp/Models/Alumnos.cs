using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FacultadAppSvc.Models
{
    public class Alumnos
    {
        public Alumnos()
        {
        }

        public Alumnos(string padron, string apellido, string nombre, string domicilio, int carreraId)
        {
            Padron = padron ?? throw new ArgumentNullException(nameof(padron));
            Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Domicilio = domicilio ?? throw new ArgumentNullException(nameof(domicilio));
            CarreraId = carreraId;
        }

        [Key]
        public int AlumnoId { get; set; }
        public string Padron{ get; set; }
        public string Apellido{ get; set; }
        public string Nombre { get; set; }
        public string Domicilio{ get; set; }
        
        [ForeignKey("Carrera")]
        [Column("CarreraFK")]
        public int CarreraId { get; internal set; }
        public Carreras Carrera { get; set; }
        
        //public virtual ICollection<Inscripciones> Inscripciones { get; set; }
        
    }

    public class AlumnosParameters
    {
        public int alumnoId { get; set; }
        public int carreraId { get; set; }
        public string padron { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string domicilio { get; set; }

        public bool IsValid => (!string.IsNullOrEmpty(padron)) && (carreraId > 0);

    }
}
