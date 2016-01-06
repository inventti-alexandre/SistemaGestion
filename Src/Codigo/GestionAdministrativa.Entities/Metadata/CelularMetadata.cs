using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Entities
{
    [MetadataType(typeof(CelularMetadata))]
    public partial class Celular
    {
    }

    public class CelularMetadata
    {
        //[Required(ErrorMessage = "Debe ingresar un número de celular")]
        //[Range(1, 9999999999999, ErrorMessage = "Debe ingresar un celular válido")]
        //public string Numero { get; set; }

       
    }
}
