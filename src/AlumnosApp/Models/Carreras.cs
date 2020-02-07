using System.ComponentModel.DataAnnotations;

namespace FacultadAppSvc.Models
{

    public class CarreraParameters
    {
        public int carreraId { get; set; }
        public string nombre { get; set; }
        public string titulo { get; set; }

        public bool IsValid => (!string.IsNullOrEmpty(nombre)) ;

    }

    public class Carreras
    {
        [Key]
        public int CarreraId { get; set; }

        public string Nombre { get; set; }
        public string Titulo { get; set; }
    }
}