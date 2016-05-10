using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Entities
{
    [MetadataType(typeof(OrdenPagoMetadata))]
    public partial class OrdenPago
    {
    }

    public class OrdenPagoMetadata
    {

        [Required(ErrorMessage = "Debe ingresar el importe")]
        public decimal Importe { get; set; }

       
    }
}
