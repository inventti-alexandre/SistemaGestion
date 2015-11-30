using System;
using System.Data.Entity;


namespace GestionAdministrativa.Data.Repository
{
    /// <summary>
    /// The EF-dependent, base repository for data access
    /// </summary>
    public class EFBaseRepository
    {
        public EFBaseRepository()
        {
            CreateDbContext();
        }

        public EFBaseRepository(DbContext dbContext)
        {
            if (dbContext == null) 
                throw new ArgumentNullException("dbContext");
            DbContext = dbContext;
            GestionAdministrativaDbContext = dbContext as GestionAdministrativaDbContext;
            if (GestionAdministrativaDbContext != null)
                GestionAdministrativaDbContext.Database.CommandTimeout = 1000;
        }

        protected void CreateDbContext()
        {
            DbContext = new GestionAdministrativaDbContext();
            DbContext.Configuration.ProxyCreationEnabled = false;
            DbContext.Configuration.LazyLoadingEnabled = false;
            DbContext.Configuration.ValidateOnSaveEnabled = false;

            GestionAdministrativaDbContext = DbContext as GestionAdministrativaDbContext;
            if (GestionAdministrativaDbContext != null)
                GestionAdministrativaDbContext.Database.CommandTimeout = 1000;
        }
        
        protected DbContext DbContext { get; set; }

        public GestionAdministrativaDbContext GestionAdministrativaDbContext { get; set; }
    }
}
