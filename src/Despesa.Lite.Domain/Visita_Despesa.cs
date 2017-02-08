using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Domain
{
    public class Visita_Despesa : EntityBase
    {
        public Guid id_despesa { get; set; }

        public Guid id_visita  { get; set; }

        public virtual Despesa Despesa { get; set; }

        public virtual Visita Visita { get; set; }
    }
}
