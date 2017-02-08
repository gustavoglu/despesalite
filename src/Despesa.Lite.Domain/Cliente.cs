using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Domain
{
    public class Cliente : EntityBase
    {
        public string Nome { get; set; }

        public string RazaoSocial { get; set; }

        public Guid id_cliente_usuarios { get; set; }

        public Cliente_Usuarios Cliente_Usuarios  { get; set; }

        public ICollection<Visita> Visitas { get; set; }
        
    }
}
