using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Entities
{
    [MetadataType(typeof(MovilMetadata))]
    public partial class Movil
    {
    }

    public class MovilMetadata
    {
        [Required(ErrorMessage = "Debe ingresar la patente")]
        public string Patente { get; set; }

        [Required(ErrorMessage = "Debe ingresar el numero")]
        [Range(1,1000,ErrorMessage = "No debe superar al numero 1000")]
        public int Numero { get; set; }
    }
}
