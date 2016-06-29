using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Entities.Metadata
{
    [MetadataType(typeof(TalleresMovilesMetaData))]
    public partial class TalleresMovile
    {
         
    }
    class TalleresMovilesMetaData
    {
        [Required(ErrorMessage = "Debe seleccionar un móvil")]
        public Guid MovilId { get; set; }

        [Required(ErrorMessage = "Debe agregar una observación")]
        public string Observaciones { get; set; }
    }
}
