using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Domain
{
    public class Visita : EntityBase
    {
        public Guid id_despesa { get; set; }

        public Guid id_cliente { get; set; }

        public DateTime Data { get; set; }

        public TimeSpan HoraChegada { get; set; }

        public TimeSpan HoraSaida { get; set; }

        public TimeSpan TempoImprodutivo { get; set; }

        public string Observações { get; set; }

        public ICollection<Despesa> Despesas { get; set; }

        public Cliente Cliente { get; set; }
    }
}
