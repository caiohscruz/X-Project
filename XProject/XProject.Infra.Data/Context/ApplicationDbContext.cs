using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using XProject.Domain.Entitities;

namespace XProject.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AppPage> Views { get; set; }
        public DbSet<FinantialOperation> FinantialOperations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }


}
