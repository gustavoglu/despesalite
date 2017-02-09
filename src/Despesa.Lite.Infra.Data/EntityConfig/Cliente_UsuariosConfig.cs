using Despesa.Lite.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Infra.Data.EntityConfig
{
   public  class Cliente_UsuariosConfig : EntityTypeConfiguration<Cliente_Usuarios>
    {
        public Cliente_UsuariosConfig()
        {
            ToTable("cliente_usuarios");

            HasRequired(cs => cs.Usuario)
                .WithMany(u => u.Cliente_Usuarios)
                .HasForeignKey(cs => cs.Id);

            HasRequired(cs => cs.Cliente)
                .WithMany(c => c.Cliente_Usuarios)
                .HasForeignKey(cs => cs.id_cliente);


        }
    }
}
