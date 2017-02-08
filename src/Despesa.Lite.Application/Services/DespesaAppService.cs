using Despesa.Lite.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Despesa.Lite.Application.ViewModels;
using AutoMapper;
using Despesa.Lite.Domain.Interfaces.Repository;
using Despesa.Lite.Infra.Data.Repository;

namespace Despesa.Lite.Application.Services
{
    public class DespesaAppService : IDespesaAppService
    {
        protected readonly IDespesaRepository _despesarepository;

        public DespesaAppService()
        {
            _despesarepository = new DespesaRepository();
        }
        public DespesaViewModel Ativar(DespesaViewModel despesaViewModel)
        {
            return Mapper.Map<DespesaViewModel>(_despesarepository.Ativar(Mapper.Map<Despesa.Lite.Domain.Despesa>(despesaViewModel)));
        }

        public DespesaViewModel Atualizar(DespesaViewModel despesaViewModel)
        {
            return Mapper.Map<DespesaViewModel>(_despesarepository.Atualizar(Mapper.Map<Despesa.Lite.Domain.Despesa>(despesaViewModel)));
        }

        public DespesaViewModel Criar(DespesaViewModel despesaViewModel)
        {
            return Mapper.Map<DespesaViewModel>(_despesarepository.Criar(Mapper.Map<Despesa.Lite.Domain.Despesa>(despesaViewModel)));
        }

        public DespesaViewModel Desativar(DespesaViewModel despesaViewModel)
        {
            return Mapper.Map<DespesaViewModel>(_despesarepository.Desativar(Mapper.Map<Despesa.Lite.Domain.Despesa>(despesaViewModel)));
        }

        public void Dispose()
        {
            _despesarepository.Dispose();
        }

        public int Remover(DespesaViewModel despesaViewModel)
        {
            return _despesarepository.Remover(Mapper.Map<Despesa.Lite.Domain.Despesa>(despesaViewModel));
        }

        public DespesaViewModel TrazerPorId(Guid Id)
        {
            return Mapper.Map<DespesaViewModel>(_despesarepository.TrazerPorId(Id));
        }

        public IEnumerable<DespesaViewModel> TrazerTodos()
        {
            return Mapper.Map<IEnumerable<DespesaViewModel>>(_despesarepository.TrazerTodos());
        }

        public IEnumerable<DespesaViewModel> TrazerTodosAtivos()
        {
            return Mapper.Map<IEnumerable<DespesaViewModel>>(_despesarepository.TrazerTodosAtivos());
        }

        public IEnumerable<DespesaViewModel> TrazerTodosDeletados()
        {
            return Mapper.Map<IEnumerable<DespesaViewModel>>(_despesarepository.TrazerTodosDeletados());
        }

        public IEnumerable<DespesaViewModel> TrazerTodosInativos()
        {
            return Mapper.Map<IEnumerable<DespesaViewModel>>(_despesarepository.TrazerTodosInativos());
        }
    }
}
