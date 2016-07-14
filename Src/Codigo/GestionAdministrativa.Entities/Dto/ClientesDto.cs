using Framework.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Entities.Dto
{
    public class ClientesDto : IMapFrom<Cliente>
    {
        public Guid Id { get; set; }
        public int? Dni { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int NroCliente { get; set; }
        public string Domicilio { get; set; }
        //public bool Activo { get; set; }
    }
}
