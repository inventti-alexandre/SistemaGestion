using Framework.Data.Repository;
using GestionAdministrativa.Entities;


namespace GestionAdministrativa.Data.Interfaces
{
    public interface IGestionAdministrativaUow : IUow
    {
        IRepository<Cajas> Cajas { get; }
        IRepository<Choferes> Choferes { get; }
        IRepository<Moviles> Moviles { get; }
      
        IReporteRepository Reportes { get; }



        GestionAdministrativaDbContext DbContext { get; }
        bool IsDisposed { get; }

        void Commit();
    }
}
