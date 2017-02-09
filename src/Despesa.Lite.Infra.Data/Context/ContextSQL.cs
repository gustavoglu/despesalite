using Despesa.Lite.Domain;
using Despesa.Lite.Infra.Data.EntityConfig;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Despesa.Lite.Infra.Data.Context
{
    public class ContextSQL : DbContext
    {
        public ContextSQL() : base(nameOrConnectionString: "default")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties().Where(p => p.Name == "Id").Configure(p => p.IsKey());

            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Entity<IdentityUser>()
            .ToTable("usuarios")
            .Property(p => p.Id)
            .HasColumnName("Id");

            modelBuilder.Entity<Usuario>()
            .ToTable("usuarios")
            .Property(p => p.Id)
            .HasColumnName("Id");

            modelBuilder.Entity<IdentityUserRole>()
            .ToTable("usuario_regras");

            modelBuilder.Entity<IdentityUserLogin>()
            .ToTable("logins");

            modelBuilder.Entity<IdentityUserClaim>()
            .ToTable("claims");

            modelBuilder.Entity<IdentityRole>()
            .ToTable("regras");

            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new DespesaConfig());
            modelBuilder.Configurations.Add(new VisitaConfig());
            modelBuilder.Configurations.Add(new Cliente_UsuariosConfig());

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Despesa.Lite.Domain.Despesa> Despesas { get; set; }
        public DbSet<Visita> Visitas { get; set; }
        public DbSet<Cliente_Usuarios> Cliente_Usuarios { get; set; }
    }
}
