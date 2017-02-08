using Despesa.Lite.Domain;
using System.Data.Entity;

namespace Despesa.Lite.Infra.Data.Context
{
    public class ContextSQL : DbContext
    {
        public ContextSQL() : base(nameOrConnectionString: "")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Despesa.Lite.Domain.Despesa> Despesas { get; set; }
        public DbSet<Visita> Visitas { get; set; }
    }
}
