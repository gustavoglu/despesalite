using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Application.AutoMapper
{
   public class AutoMapperConfig
    {
        public static void RegisterMappers()
        {
            Mapper.Initialize(m => { m.AddProfile(new DomainToViewModelMapperProfile()) ; });
        }
    }
}
