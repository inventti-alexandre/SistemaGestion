using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Common.Mapping;

namespace GestionAdministrativa.Entities.Dto
{
    class TiposTalleresDto :IMapFrom<Tallere>
    {
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Porcentaje { get; set; }

    }
}
