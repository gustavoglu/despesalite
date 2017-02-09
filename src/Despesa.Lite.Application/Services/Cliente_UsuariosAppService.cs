using Despesa.Lite.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Despesa.Lite.Application.ViewModels;
using Despesa.Lite.Domain.Interfaces.Repository;
using Despesa.Lite.Infra.Data.Repository;
using AutoMapper;
using Despesa.Lite.Domain;

namespace Despesa.Lite.Application.Services
{
    public class Cliente_UsuariosAppService : ICliente_UsuariosAppService
    {
        protected readonly ICliente_UsuariosRepository _cliente_UsuariosRepository;

        public Cliente_UsuariosAppService()
        {
            _cliente_UsuariosRepository = new Cliente_UsuariosRepository();   
        }

        public Cliente_UsuariosViewModel Ativar(Cliente_UsuariosViewModel cliente_UsuariosViewModel)
        {
            return Mapper.Map<Cliente_UsuariosViewModel>(_cliente_UsuariosRepository.Ativar(Mapper.Map<Cliente_Usuarios>(cliente_UsuariosViewModel)));
        }

        public Cliente_UsuariosViewModel Atualizar(Cliente_UsuariosViewModel cliente_UsuariosViewModel)
        {
            return Mapper.Map<Cliente_UsuariosViewModel>(_cliente_UsuariosRepository.Atualizar(Mapper.Map<Cliente_Usuarios>(cliente_UsuariosViewModel)));
        }

        public Cliente_UsuariosViewModel Criar(Cliente_UsuariosViewModel cliente_UsuariosViewModel)
        {
            return Mapper.Map<Cliente_UsuariosViewModel>(_cliente_UsuariosRepository.Criar(Mapper.Map<Cliente_Usuarios>(cliente_UsuariosViewModel)));
        }

        public Cliente_UsuariosViewModel Desativar(Cliente_UsuariosViewModel cliente_UsuariosViewModel)
        {
            return Mapper.Map<Cliente_UsuariosViewModel>(_cliente_UsuariosRepository.Desativar(Mapper.Map<Cliente_Usuarios>(cliente_UsuariosViewModel)));
        }

        public int Remover(Cliente_UsuariosViewModel cliente_UsuariosViewModel)
        {
            return _cliente_UsuariosRepository.Remover(Mapper.Map<Cliente_Usuarios>(cliente_UsuariosViewModel));
        }

        public Cliente_UsuariosViewModel TrazerPorId(Guid Id)
        {
            return Mapper.Map<Cliente_UsuariosViewModel>(_cliente_UsuariosRepository.TrazerPorId(Id));
        }

        public IEnumerable<Cliente_UsuariosViewModel> TrazerTodos()
        {
            return Mapper.Map<IEnumerable<Cliente_UsuariosViewModel>>(_cliente_UsuariosRepository.TrazerTodos());
        }

        public IEnumerable<Cliente_UsuariosViewModel> TrazerTodosAtivos()
        {
            return Mapper.Map<IEnumerable<Cliente_UsuariosViewModel>>(_cliente_UsuariosRepository.TrazerTodosAtivos());
        }

        public IEnumerable<Cliente_UsuariosViewModel> TrazerTodosDeletados()
        {
            return Mapper.Map<IEnumerable<Cliente_UsuariosViewModel>>(_cliente_UsuariosRepository.TrazerTodosDeletados());
        }

        public IEnumerable<Cliente_UsuariosViewModel> TrazerTodosInativos()
        {
            return Mapper.Map<IEnumerable<Cliente_UsuariosViewModel>>(_cliente_UsuariosRepository.TrazerTodosInativos());
        }
    }
}
