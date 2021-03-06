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
    
    public partial class ProveedorBanco
    {
        public System.Guid Id { get; set; }
        public System.Guid ProveedorId { get; set; }
        public Nullable<int> BancoId { get; set; }
        public string CtaCte { get; set; }
        public string CajaAhorro { get; set; }
        public int SucursalAltaId { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public System.Guid OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public string Titular { get; set; }
        public string CBU { get; set; }
    
        public virtual Banco Bancos { get; set; }
        public virtual Operador Operadores { get; set; }
        public virtual Operador Operadores1 { get; set; }
        public virtual Proveedor Proveedores { get; set; }
        public virtual Sucursal Sucursales { get; set; }
        public virtual Sucursal Sucursales1 { get; set; }
    }
}
