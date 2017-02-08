using Despesa.Lite.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Infra.Data.EntityConfig
{
   public  class VisitaConfig : EntityTypeConfiguration<Visita>
    {
        public VisitaConfig()
        {
            ToTable("visita");

            HasRequired(v => v.Cliente)
                .WithMany(c => c.Visitas)
                .HasForeignKey(v => v.id_cliente);

            Property(v => v.Data).IsRequired();

            Property(v => v.Observações).IsOptional().HasMaxLength(1000);


        }
    }
}
