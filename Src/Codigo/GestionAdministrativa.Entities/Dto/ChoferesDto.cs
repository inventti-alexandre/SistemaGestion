﻿using Framework.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Entities.Dto
{
    public class ChoferesDto : IMapFrom<Chofer>
    {
        public Guid Id { get; set; }
        public int? Dni { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int? MovilNumero { get; set; }
        public string CelularObservacion { get; set; }
    }
}
