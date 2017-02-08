using Despesa.Lite.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Application.Interfaces
{
   public interface IClienteAppService : IDisposable
    {
        ClienteViewModel Criar(ClienteViewModel clienteViewModel);

        ClienteViewModel Atualizar(ClienteViewModel clienteViewModel);

        ClienteViewModel TrazerPorId(Guid Id);

        ClienteViewModel Ativar(ClienteViewModel clienteViewModel);

        ClienteViewModel Desativar(ClienteViewModel clienteViewModel);

        IEnumerable<ClienteViewModel> TrazerTodos();

        IEnumerable<ClienteViewModel> TrazerTodosAtivos();

        IEnumerable<ClienteViewModel> TrazerTodosInativos();

        IEnumerable<ClienteViewModel> TrazerTodosDeletados();

        int Remover(ClienteViewModel clienteViewModel);

    }
}
