using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Common.Mapping;

namespace GestionAdministrativa.Entities.Dto
{
    public class TalleresMovilesDto : IMapFrom<TalleresMovile> 
    {
        public Guid Id { get; set; }
        public Guid TallerId { get; set; }
        public Guid MovilId { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public bool? Activo { get; set; }
        public bool? Acreditado { get; set; }
        public string Observaciones { get; set; }
        public int? MovilNumero { get; set; }

        
    }
}
