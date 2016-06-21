using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Entities.Metadata
{
    [MetadataType(typeof(TiposTalleresMetadata))]
    public partial class Tallere
    {
         
    }
    
    public class TiposTalleresMetadata
    {

        [Required(ErrorMessage = "Debe Ingresar una descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Debe Ingresar el porcentaje")]
        //[MaxLength(11, ErrorMessage = "El número de cuit/DNI no es válido")]
        [RegularExpression("^[1-9][0-9]*$", ErrorMessage = "Debe Ingresar el porcentaje")]
        public decimal Porcentaje { get; set; }

    }
}
