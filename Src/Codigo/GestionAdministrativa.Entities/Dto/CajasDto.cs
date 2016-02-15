using Framework.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Entities.Dto
{
    public class CajasDto : IMapFrom<Caja>
    {
        public System.Guid Id { get; set; }
        public int SucursalId { get; set; }
        public Nullable<System.Guid> OperadorId { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<System.DateTime> FCierre { get; set; }
        public Nullable<decimal> Inicio { get; set; }
        public Nullable<decimal> Ingresos { get; set; }
        public Nullable<decimal> Egresos { get; set; }
        public Nullable<decimal> Saldo { get; set; }
        public Nullable<decimal> Cheques { get; set; }
        public Nullable<decimal> Bonos { get; set; }
        public string PcAlta { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<bool> Aprobada { get; set; }
    }
}
