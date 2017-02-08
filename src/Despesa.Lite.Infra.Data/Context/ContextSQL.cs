using Despesa.Lite.Domain;
using Despesa.Lite.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Despesa.Lite.Infra.Data.Context
{
    public class ContextSQL : DbContext
    {
        public ContextSQL() : base(nameOrConnectionString: "")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties().Where(p => p.Name == "Id").Configure(p => p.IsKey());

            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new DespesaConfig());
            modelBuilder.Configurations.Add(new VisitaConfig());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Despesa.Lite.Domain.Despesa> Despesas { get; set; }
        public DbSet<Visita> Visitas { get; set; }
    }
}
