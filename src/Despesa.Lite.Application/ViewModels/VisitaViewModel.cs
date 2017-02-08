using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Application.ViewModels
{
    public class VisitaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="")]
        public DateTime Data { get; set; }

        public TimeSpan HoraChegada { get; set; }

        public TimeSpan HoraSaida { get; set; }

        public TimeSpan TempoImprodutivo { get; set; }

        public string Observações { get; set; }

        public ICollection<DespesaViewModel> Despesas { get; set; }

    }
}
