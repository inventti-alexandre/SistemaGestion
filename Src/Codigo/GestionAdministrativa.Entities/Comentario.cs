//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionAdministrativa.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comentario
    {
        public Comentario()
        {
            this.ComentariosChofers = new HashSet<ComentariosChofer>();
        }
    
        public System.Guid Id { get; set; }
        public string comentario1 { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
    
        public virtual Operador Operadore { get; set; }
        public virtual Sucursal Sucursale { get; set; }
        public virtual ICollection<ComentariosChofer> ComentariosChofers { get; set; }
    }
}
