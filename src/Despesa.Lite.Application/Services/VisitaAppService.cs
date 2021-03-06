﻿using Despesa.Lite.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Despesa.Lite.Application.ViewModels;
using System.Linq.Expressions;
using AutoMapper;
using Despesa.Lite.Domain;
using Despesa.Lite.Domain.Interfaces.Repository;
using Despesa.Lite.Infra.Data.Repository;

namespace Despesa.Lite.Application.Services
{
    public class VisitaAppService : IVisitaAppService
    {
        protected readonly IVisitaRepository _visitarepository;
        protected readonly IDespesaRepository _despesarepository;

        public VisitaAppService()
        {
            _visitarepository = new VisitaRepository();
            _despesarepository = new DespesaRepository();
        }

        public VisitaDespesaClienteViewModel Ativar(VisitaDespesaClienteViewModel visitaDespesaClienteViewModel)
        {
            var visita = Mapper.Map<Visita>(visitaDespesaClienteViewModel.Visita);
            var despesa = Mapper.Map<IEnumerable<Despesa.Lite.Domain.Despesa>>(visitaDespesaClienteViewModel.Despesas);
            var cliente = Mapper.Map<Cliente>(visitaDespesaClienteViewModel.Cliente);

            _visitarepository.Ativar(visita);
            foreach (var item in despesa)
            {
                _despesarepository.Ativar(item);
            }

            return visitaDespesaClienteViewModel;
        }

        public VisitaDespesaClienteViewModel Atualizar(VisitaDespesaClienteViewModel visitaDespesaClienteViewModel)
        {
            var visita = Mapper.Map<Visita>(visitaDespesaClienteViewModel.Visita);
            var despesa = Mapper.Map<IEnumerable<Despesa.Lite.Domain.Despesa>>(visitaDespesaClienteViewModel.Despesas);
            var cliente = Mapper.Map<Cliente>(visitaDespesaClienteViewModel.Cliente);

            visita.Despesas = despesa.ToList();
            visita.Cliente = cliente;

            _visitarepository.Atualizar(visita);

            return visitaDespesaClienteViewModel;
        }

        public VisitaDespesaClienteViewModel Criar(VisitaDespesaClienteViewModel visitaDespesaClienteViewModel)
        {
            var visita = Mapper.Map<Visita>(visitaDespesaClienteViewModel.Visita);
            var despesa = Mapper.Map<IEnumerable<Despesa.Lite.Domain.Despesa>>(visitaDespesaClienteViewModel.Despesas);
            var cliente = Mapper.Map<Cliente>(visitaDespesaClienteViewModel.Cliente);

            visita.Despesas = despesa.ToList();
            visita.Cliente = cliente;

            _visitarepository.Criar(visita);

            return visitaDespesaClienteViewModel;
        }

        public VisitaDespesaClienteViewModel Desativar(VisitaDespesaClienteViewModel visitaDespesaClienteViewModel)
        {
            var visita = Mapper.Map<Visita>(visitaDespesaClienteViewModel.Visita);
            var despesa = Mapper.Map<IEnumerable<Despesa.Lite.Domain.Despesa>>(visitaDespesaClienteViewModel.Despesas);
            var cliente = Mapper.Map<Cliente>(visitaDespesaClienteViewModel.Cliente);

            _visitarepository.Desativar(visita);
            foreach (var item in despesa)
            {
                _despesarepository.Desativar(item);
            }

            return visitaDespesaClienteViewModel;
        }

        public void Dispose()
        {
            _visitarepository.Dispose();
            _despesarepository.Dispose();
        }

        public int Remover(VisitaDespesaClienteViewModel visitaDespesaClienteViewModel)
        {
            var visita = Mapper.Map<Visita>(visitaDespesaClienteViewModel.Visita);
            var despesa = Mapper.Map<IEnumerable<Despesa.Lite.Domain.Despesa>>(visitaDespesaClienteViewModel.Despesas);
            var cliente = Mapper.Map<Cliente>(visitaDespesaClienteViewModel.Cliente);

            visita.Despesas = despesa.ToList();
            visita.Cliente = cliente;

            foreach (var item in despesa)
            {
                _despesarepository.Remover(item);
            }

            return _visitarepository.Remover(visita);


        }

        public VisitaViewModel TrazerPorId(Guid Id)
        {
            return Mapper.Map<VisitaViewModel>(_visitarepository.TrazerPorId(Id));
        }

        public IEnumerable<VisitaViewModel> TrazerTodos()
        {
            return Mapper.Map<IEnumerable<VisitaViewModel>>(_visitarepository.TrazerTodos());
        }

        public IEnumerable<VisitaViewModel> TrazerTodosAtivos()
        {
            return Mapper.Map<IEnumerable<VisitaViewModel>>(_visitarepository.TrazerTodosAtivos());
        }

        public IEnumerable<VisitaViewModel> TrazerTodosDeletados()
        {
            return Mapper.Map<IEnumerable<VisitaViewModel>>(_visitarepository.TrazerTodosDeletados());
        }

        public IEnumerable<VisitaViewModel> TrazerTodosInativos()
        {
            return Mapper.Map<IEnumerable<VisitaViewModel>>(_visitarepository.TrazerTodosInativos());
        }
    }
}
