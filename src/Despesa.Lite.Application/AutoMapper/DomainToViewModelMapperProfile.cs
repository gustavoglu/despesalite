using AutoMapper;
using Despesa.Lite.Application.ViewModels;
using Despesa.Lite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Application.AutoMapper
{
   public class DomainToViewModelMapperProfile : Profile
    {
        public DomainToViewModelMapperProfile()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Despesa.Lite.Domain.Despesa, DespesaViewModel>().ReverseMap();
            CreateMap<Visita, VisitaViewModel>().ReverseMap();

        }
    }
}
