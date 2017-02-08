using Despesa.Lite.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Application.Interfaces
{
    public interface IVisitaAppService : IDisposable 
    {
        VisitaDespesaClienteViewModel Criar(VisitaDespesaClienteViewModel visitaDespesaClienteViewModel);

        VisitaDespesaClienteViewModel Atualizar(VisitaDespesaClienteViewModel visitaDespesaClienteViewModel);

        VisitaViewModel TrazerPorId(Guid Id);

        VisitaDespesaClienteViewModel Ativar(VisitaDespesaClienteViewModel visitaDespesaClienteViewModel);

        VisitaDespesaClienteViewModel Desativar(VisitaDespesaClienteViewModel visitaDespesaClienteViewModel);

        IEnumerable<VisitaViewModel> TrazerTodos();

        IEnumerable<VisitaViewModel> TrazerTodosAtivos();

        IEnumerable<VisitaViewModel> TrazerTodosInativos();

        IEnumerable<VisitaViewModel> TrazerTodosDeletados();

        int Remover(VisitaDespesaClienteViewModel visitaDespesaClienteViewModel);
    }
}
