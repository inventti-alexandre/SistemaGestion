﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionAdministrativa.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using GestionAdministrativa.Entities;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GestionAdministrativaDbContext : DbContext
    {
        public GestionAdministrativaDbContext()
            : base("name=GestionAdministrativaDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<Caja> Cajas { get; set; }
        public virtual DbSet<CajaMovimiento> CajasMovimientos { get; set; }
        public virtual DbSet<CategoriaOperador> CategoriasOperadores { get; set; }
        public virtual DbSet<CelularMovimiento> CelularesMovimiento { get; set; }
        public virtual DbSet<CentroCosto> CentrosCostos { get; set; }
        public virtual DbSet<ChoferMontoFavor> ChoferesMontosFavor { get; set; }
        public virtual DbSet<Concepto> Conceptos { get; set; }
        public virtual DbSet<CondicionCompra> CondicionesCompra { get; set; }
        public virtual DbSet<Dia> Dias { get; set; }
        public virtual DbSet<Funcion> Funciones { get; set; }
        public virtual DbSet<GrupoProveedor> GruposProveedores { get; set; }
        public virtual DbSet<Localidad> Localidades { get; set; }
        public virtual DbSet<Movil> Moviles { get; set; }
        public virtual DbSet<Operador> Operadores { get; set; }
        public virtual DbSet<OperadorFuncion> OperadoresFunciones { get; set; }
        public virtual DbSet<OperadorSucursal> OperadoresSucursales { get; set; }
        public virtual DbSet<OrdenPago> OrdenesPago { get; set; }
        public virtual DbSet<OrdenPagoDetalle> OrdenesPagoDetalle { get; set; }
        public virtual DbSet<PagoCelular> PagosCelular { get; set; }
        public virtual DbSet<Pais> Paises { get; set; }
        public virtual DbSet<Personal> Personales { get; set; }
        public virtual DbSet<PersonalConcepto> PersonalesConceptos { get; set; }
        public virtual DbSet<PersonalNovedad> PersonalNovedades { get; set; }
        public virtual DbSet<Proveedor> Proveedores { get; set; }
        public virtual DbSet<ProveedorBanco> ProveedoresBancos { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Recibo> Recibos { get; set; }
        public virtual DbSet<ReciboDetalle> RecibosDetalles { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<Sucursal> Sucursales { get; set; }
        public virtual DbSet<TipoCelular> TiposCelulares { get; set; }
        public virtual DbSet<TipoComprobante> TiposComprobantes { get; set; }
        public virtual DbSet<TipoDocumentosIdentidad> TiposDocumentosIdentidad { get; set; }
        public virtual DbSet<TipoGasto> TiposGastos { get; set; }
        public virtual DbSet<TipoMovimientoCaja> TiposMovimientosCajas { get; set; }
        public virtual DbSet<TipoRecibo> TiposRecibos { get; set; }
        public virtual DbSet<Chofer> Choferes { get; set; }
        public virtual DbSet<EmpresasCelulare> EmpresasCelulares { get; set; }
        public virtual DbSet<ModelosCelulare> ModelosCelulares { get; set; }
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Celular> Celulares { get; set; }
        public virtual DbSet<CajaBalance> CajaBalances { get; set; }
        public virtual DbSet<ChoferesMovil> ChoferesMovils { get; set; }
        public virtual DbSet<ChoferCelular> ChoferCelulars { get; set; }
        public virtual DbSet<Comentario> Comentarios { get; set; }
        public virtual DbSet<ComentariosChofer> ComentariosChofers { get; set; }
        public virtual DbSet<PagosMovile> PagosMoviles { get; set; }
        public virtual DbSet<Promocione> Promociones { get; set; }
        public virtual DbSet<PromocionesMovile> PromocionesMoviles { get; set; }
        public virtual DbSet<Tallere> Talleres { get; set; }
        public virtual DbSet<TalleresMovile> TalleresMoviles { get; set; }
        public virtual DbSet<Tarifa> Tarifas { get; set; }
        public virtual DbSet<Titulare> Titulares { get; set; }
        public virtual DbSet<PagosBas> PagosBases { get; set; }
        public virtual DbSet<MovilesMontoFavor> MovilesMontoFavors { get; set; }
        public virtual DbSet<MotivosTallere> MotivosTalleres { get; set; }
    
        public virtual ObjectResult<Reporte_CajaResumida_Ingresos_Result> Reporte_CajaResumida_Ingresos(Nullable<int> sucursalId, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, Nullable<System.Guid> operadorId, Nullable<System.Guid> cajaId)
        {
            var sucursalIdParameter = sucursalId.HasValue ?
                new ObjectParameter("SucursalId", sucursalId) :
                new ObjectParameter("SucursalId", typeof(int));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            var operadorIdParameter = operadorId.HasValue ?
                new ObjectParameter("OperadorId", operadorId) :
                new ObjectParameter("OperadorId", typeof(System.Guid));
    
            var cajaIdParameter = cajaId.HasValue ?
                new ObjectParameter("CajaId", cajaId) :
                new ObjectParameter("CajaId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Reporte_CajaResumida_Ingresos_Result>("Reporte_CajaResumida_Ingresos", sucursalIdParameter, fechaInicioParameter, fechaFinParameter, operadorIdParameter, cajaIdParameter);
        }
    
        public virtual ObjectResult<Reporte_CajaResumida_ComposicionIngresos_Result> Reporte_CajaResumida_ComposicionIngresos(Nullable<int> sucursalId, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, Nullable<System.Guid> operadorId, Nullable<System.Guid> cajaId)
        {
            var sucursalIdParameter = sucursalId.HasValue ?
                new ObjectParameter("SucursalId", sucursalId) :
                new ObjectParameter("SucursalId", typeof(int));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            var operadorIdParameter = operadorId.HasValue ?
                new ObjectParameter("OperadorId", operadorId) :
                new ObjectParameter("OperadorId", typeof(System.Guid));
    
            var cajaIdParameter = cajaId.HasValue ?
                new ObjectParameter("CajaId", cajaId) :
                new ObjectParameter("CajaId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Reporte_CajaResumida_ComposicionIngresos_Result>("Reporte_CajaResumida_ComposicionIngresos", sucursalIdParameter, fechaInicioParameter, fechaFinParameter, operadorIdParameter, cajaIdParameter);
        }
    
        public virtual ObjectResult<InformeCaja_Result> InformeCaja(Nullable<int> sucursalId, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, Nullable<System.Guid> operadorId, Nullable<System.Guid> cajaId)
        {
            var sucursalIdParameter = sucursalId.HasValue ?
                new ObjectParameter("SucursalId", sucursalId) :
                new ObjectParameter("SucursalId", typeof(int));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            var operadorIdParameter = operadorId.HasValue ?
                new ObjectParameter("OperadorId", operadorId) :
                new ObjectParameter("OperadorId", typeof(System.Guid));
    
            var cajaIdParameter = cajaId.HasValue ?
                new ObjectParameter("CajaId", cajaId) :
                new ObjectParameter("CajaId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InformeCaja_Result>("InformeCaja", sucursalIdParameter, fechaInicioParameter, fechaFinParameter, operadorIdParameter, cajaIdParameter);
        }
    
        public virtual ObjectResult<MovilesPorCajaId_Result> MovilesPorCajaId(Nullable<System.Guid> cajaId)
        {
            var cajaIdParameter = cajaId.HasValue ?
                new ObjectParameter("CajaId", cajaId) :
                new ObjectParameter("CajaId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MovilesPorCajaId_Result>("MovilesPorCajaId", cajaIdParameter);
        }
    
        public virtual ObjectResult<HistorialPagosChofer_Result> HistorialPagosChofer(Nullable<System.Guid> chofer)
        {
            var choferParameter = chofer.HasValue ?
                new ObjectParameter("Chofer", chofer) :
                new ObjectParameter("Chofer", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HistorialPagosChofer_Result>("HistorialPagosChofer", choferParameter);
        }
    
        public virtual ObjectResult<FueraDeSistema_Result> FueraDeSistema()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FueraDeSistema_Result>("FueraDeSistema");
        }
    
        public virtual ObjectResult<Reporte_CajaResumida_Egresos_Result> Reporte_CajaResumida_Egresos(Nullable<int> sucursalId, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, Nullable<System.Guid> operadorId, Nullable<System.Guid> cajaId)
        {
            var sucursalIdParameter = sucursalId.HasValue ?
                new ObjectParameter("SucursalId", sucursalId) :
                new ObjectParameter("SucursalId", typeof(int));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            var operadorIdParameter = operadorId.HasValue ?
                new ObjectParameter("OperadorId", operadorId) :
                new ObjectParameter("OperadorId", typeof(System.Guid));
    
            var cajaIdParameter = cajaId.HasValue ?
                new ObjectParameter("CajaId", cajaId) :
                new ObjectParameter("CajaId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Reporte_CajaResumida_Egresos_Result>("Reporte_CajaResumida_Egresos", sucursalIdParameter, fechaInicioParameter, fechaFinParameter, operadorIdParameter, cajaIdParameter);
        }
    }
}
