using System;
using Framework.Data.Repository;
using GestionAdministrativa.Entities;


namespace GestionAdministrativa.Data.Interfaces
{
    public interface IGestionAdministrativaUow : IDisposable
    {
        IRepository<Caja> Cajas { get; }
        IRepository<Chofer> Choferes { get; }
        IRepository<Operador> Operadores { get; }
        IRepository<Movil> Moviles { get; }
        IRepository<PagoCelular> PagosCelulares { get; }
        IReporteRepository Reportes { get; }
        IRepository<Sucursal> Sucursales { get; }
        IRepository<Celular> Celulares { get; }
        IRepository<Dia> Dias { get; }
        IRepository<EmpresasCelulare> EmpresasCelulares { get; }
        IRepository<TipoCelular> TiposCelulares { get; }
        IRepository<ModelosCelulare> ModelosCelulares { get; }
        GestionAdministrativaDbContext DbContext { get; }
        bool IsDisposed { get; }

        void Commit();
    }
}
