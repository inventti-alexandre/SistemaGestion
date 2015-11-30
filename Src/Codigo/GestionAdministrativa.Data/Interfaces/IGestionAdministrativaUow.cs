using Framework.Data.Repository;
using GestionAdministrativa.Entities;


namespace GestionAdministrativa.Data.Interfaces
{
    public interface IGestionAdministrativaUow : IUow
    {
        IRepository<Caja> Cajas { get; }
        IRepository<Chofer> Choferes { get; }
        IRepository<Movil> Moviles { get; }
      
        IReporteRepository Reportes { get; }



        GestionAdministrativaDbContext DbContext { get; }
        bool IsDisposed { get; }

        void Commit();
    }
}
