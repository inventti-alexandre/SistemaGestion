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
        
        //[IsUnique("Numero")]
        //public string Numero { get; set; }

       
    }
}
