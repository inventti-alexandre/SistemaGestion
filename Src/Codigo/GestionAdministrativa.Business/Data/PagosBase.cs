using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAdministrativa.Entities;

namespace GestionAdministrativa.Business.Data
{
    public class PagosBase
    {
        public Guid MovilId { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public int Dias { get; set; }
        public decimal Taller { get; set; }
        public decimal AFavor { get; set; }
        public decimal SubTotal { get; set; }
        public Decimal Total { get; set; }
        public Movil Movil { get; set; }

    }
}
