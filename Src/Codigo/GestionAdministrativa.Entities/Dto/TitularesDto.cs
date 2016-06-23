using Framework.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Entities.Dto
{
    public class TitularesDto : IMapFrom<Titulare>
    {
        public Guid Id { get; set; }
        public int? DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
    }
}
