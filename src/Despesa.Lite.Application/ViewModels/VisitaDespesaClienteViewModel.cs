﻿using System.Collections.ObjectModel;

namespace Despesa.Lite.Application.ViewModels
{
    public class VisitaDespesaClienteViewModel
    {
        public ClienteViewModel Cliente { get; set; }

        public VisitaViewModel Visita { get; set; }

        public Collection<DespesaViewModel> Despesas { get; set; }
    }
}
