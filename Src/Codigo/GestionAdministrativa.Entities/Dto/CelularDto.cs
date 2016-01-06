using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Common.Mapping;

namespace GestionAdministrativa.Entities.Dto
{
    public class CelularDto : IMapFrom<Celular>
    {
        public Guid Id { get; set; }
        public int? Numero { get; set; }
        public bool? Activo { get; set; }
        public DateTime FechaAlta { get; set; }

    }
}
