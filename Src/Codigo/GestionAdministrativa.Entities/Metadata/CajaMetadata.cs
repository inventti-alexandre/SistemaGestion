using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Entities
{
    [MetadataType(typeof(CajaMetadata))]
    public partial class Caja
    {
    }

    public class CajaMetadata
    {
        [Required(ErrorMessage = "Debe Ingresar el efectivo real")]
        //[MaxLength(11, ErrorMessage = "El número de cuit/DNI no es válido")]
        [RegularExpression("^[1-9][0-9]*$", ErrorMessage = "Debe ser mayor a 0")]
        public string EfectivoReal { get; set; }

       
        //[MaxLength(11, ErrorMessage = "El número de cuit/DNI no es válido")]
       // [RegularExpression("^[1-9][0-9]*$", ErrorMessage = "Debe ser mayor a 0")]
        [Required(ErrorMessage = "Debe Ingresar el importe de vales real")]
        public string ValesReal { get; set; }

        //[Required(ErrorMessage = "Debe ingresar el apellido")]
        //public string Apellido { get; set; }

        //[Required(ErrorMessage = "Debe ingresar el nombre")]
        //public string Nombre { get; set; }
    }
}
