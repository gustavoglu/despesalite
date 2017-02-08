using Despesa.Lite.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Infra.Data.EntityConfig
{
    public class Visita_DespesaConfig : EntityTypeConfiguration<Visita_Despesa>
    {
        public Visita_DespesaConfig()
        {
            ToTable("visita_despesas");

            //HasRequired(vd => vd.despe)
            //    .WithMany(v => v.Visita_Despesas)
            //    .HasForeignKey(vd => vd.id_visita);

            //HasRequired(vd => vd.Despesa)
            //    .WithMany(d => d.)

        }
    }
}
