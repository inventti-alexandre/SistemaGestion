using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Entities
{
    [MetadataType(typeof(ChoferMetadata))]
    public partial class Chofer
    {
    }

    public class ChoferMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un CUIT/DNI")]
        //[MaxLength(11, ErrorMessage = "El número de cuit/DNI no es válido")]
        [RegularExpression("^[0-9]{8,11}?$", ErrorMessage = "El número de cuit/DNI no es válido")]
        public string Dni { get; set; }

        [Required(ErrorMessage = "Debe ingresar el apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre")]
        public string Nombre { get; set; }
    }
}
