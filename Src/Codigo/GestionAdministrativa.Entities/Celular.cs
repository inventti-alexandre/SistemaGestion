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
    
    public partial class Celular
    {
        public Celular()
        {
            this.CelularesMovimientoes = new HashSet<CelularMovimiento>();
            this.Choferes = new HashSet<Chofer>();
            this.PagosCelulars = new HashSet<PagoCelular>();
            this.ChoferCelulars = new HashSet<ChoferCelular>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<int> TipoCelularId { get; set; }
        public Nullable<System.DateTime> Alta { get; set; }
        public Nullable<System.DateTime> Baja { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<bool> Pagare { get; set; }
        public Nullable<bool> Habilitado { get; set; }
        public Nullable<System.DateTime> FechaUltimoPago { get; set; }
        public Nullable<System.DateTime> FechaProximoPago { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> DiaPagoId { get; set; }
        public Nullable<System.DateTime> FechaVencimientoPago { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> EmpresaCelular { get; set; }
        public string Numero { get; set; }
        public string Imei { get; set; }
        public string SIM { get; set; }
        public string Email { get; set; }
        public Nullable<int> DiaCargaId { get; set; }
        public Nullable<int> ModeloCelularId { get; set; }
        public string NumeroPagare { get; set; }
        public Nullable<int> Caja { get; set; }
    
        public virtual Dia Dia { get; set; }
        public virtual Dia Dia1 { get; set; }
        public virtual EmpresasCelulare EmpresasCelulare { get; set; }
        public virtual ModelosCelulare ModelosCelulare { get; set; }
        public virtual Operador Operadore { get; set; }
        public virtual Operador Operadore1 { get; set; }
        public virtual Sucursal Sucursale { get; set; }
        public virtual Sucursal Sucursale1 { get; set; }
        public virtual TipoCelular TiposCelulares { get; set; }
        public virtual ICollection<CelularMovimiento> CelularesMovimientoes { get; set; }
        public virtual ICollection<Chofer> Choferes { get; set; }
        public virtual ICollection<PagoCelular> PagosCelulars { get; set; }
        public virtual ICollection<ChoferCelular> ChoferCelulars { get; set; }
    }
}
