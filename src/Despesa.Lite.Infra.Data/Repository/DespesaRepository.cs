using Despesa.Lite.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Infra.Data.Repository
{
    public class DespesaRepository : Repository<Despesa.Lite.Domain.Despesa>, IDespesaRepository
    {
    }
}
