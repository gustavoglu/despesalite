using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Infra.Data.EntityConfig
{
    public class DespesaConfig : EntityTypeConfiguration<Despesa.Lite.Domain.Despesa>
    {
        public DespesaConfig()
        {
            ToTable("despesa");

            HasRequired(d => d.Visita)
                .WithMany(v => v.Despesas)
                .HasForeignKey(d => d.id_visita);

            Property(d => d.Refeicao).HasColumnType("float");
            Property(d => d.Pedagio).HasColumnType("float");
            Property(d => d.Detalhes).HasMaxLength(1000);

        }
    }
}
