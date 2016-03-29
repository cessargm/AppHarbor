using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Closer.Services.Data
{
    public class CloserDataContext : DbContext
    {
        public CloserDataContext()
            : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CloserDataContext, CloserContextMigrationConfiguration>());
        }

    public DbSet<InformacionBasica> InformacionBasicaUsuarios { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    }
}