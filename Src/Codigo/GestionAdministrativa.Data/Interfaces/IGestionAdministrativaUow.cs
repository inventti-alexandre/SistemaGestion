using System;
using Framework.Data.Repository;
using GestionAdministrativa.Entities;


namespace GestionAdministrativa.Data.Interfaces
{
    public interface IGestionAdministrativaUow : IDisposable
    {
        IReporteRepository Reportes { get; }
        IRepository<Caja> Cajas { get; }
        IRepository<Chofer> Choferes { get; }
        IRepository<Operador> Operadores { get; }
        IRepository<Movil> Moviles { get; }
        IRepository<Promocione> Promociones { get; }
        IRepository<PromocionesMovile> PromocionesMoviles { get; }
        IRepository<Tarifa> Tarifas { get; }
        IRepository<PagoCelular> PagosCelulares { get; }
        IRepository<PagosMovile> PagosMoviles { get; }
        IRepository<PagosBas> PagosBases { get; }
        IRepository<Sucursal> Sucursales { get; }
        IRepository<Celular> Celulares { get; }
        IRepository<Dia> Dias { get; }
        IRepository<EmpresasCelulare> EmpresasCelulares { get; }
        IRepository<TipoCelular> TiposCelulares { get; }
        IRepository<ChoferMontoFavor> ChoferesMontosFavor { get; }
        IRepository<ModelosCelulare> ModelosCelulares { get; }
        IRepository<CajaMovimiento> CajaMovimientos { get; }
        IRepository<ChoferesMovil> ChoferesMoviles { get; }
        IRepository<ChoferCelular> ChoferCelulares { get; }
        IRepository<OperadorSucursal> OperadorSucursales { get; }
        IRepository<CajaBalance> CajaBalances { get; }
        IRepository<Comentario> Comentarios { get; }
        IRepository<ComentariosChofer> ComentariosChoferes { get; }
        GestionAdministrativaDbContext DbContext { get; }
        IRepository<OrdenPago> OrdenesPagos { get; }
        IRepository<OrdenPagoDetalle> OrdenesPagosDetalles { get; }
        IRepository<Proveedor> Proveedores { get; }
        IRepository<Titulare> Titulares { get; }
        bool IsDisposed { get; }

        void Commit();
    }
}
