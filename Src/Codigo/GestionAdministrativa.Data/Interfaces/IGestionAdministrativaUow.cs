using Framework.Data.Repository;
using GestionAdministrativa.Entities;


namespace GestionAdministrativa.Data.Interfaces
{
    public interface IGestionAdministrativaUow : IUow
    {
        IRepository<Caja> Cajas { get; }
        IRepository<Chofer> Choferes { get; }
        IRepository<Operador> Operadores { get; }
        IRepository<Movil> Moviles { get; }
      
        IReporteRepository Reportes { get; }
        IRepository<Sucursal> Sucursales { get; }


        GestionAdministrativaDbContext DbContext { get; }
        bool IsDisposed { get; }

        void Commit();
    }
}
