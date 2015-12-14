using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Common.Mapping;

namespace GestionAdministrativa.Entities.Dto
{
    public class MovilesDto : IMapFrom<Movil>
    {
        public Guid Id { get; set; }
        public int Numero { get; set; }
        public string Patente { get; set; }
        
    }
}
