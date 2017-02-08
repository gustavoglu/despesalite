using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Domain
{
    public class Despesa : EntityBase
    {
        public Guid id_visita { get; set; }

        public int Quilometragem { get; set; }

        public double Pedagio { get; set; }

        public double Refeicao { get; set; }

        public double Outros { get; set; }

        public string Detalhes { get; set; }
    }

}
