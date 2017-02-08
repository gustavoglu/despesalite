using Despesa.Lite.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Despesa.Lite.Domain;
using Despesa.Lite.Infra.Data.Context;
using System.Data.Entity;
using System.Web;

namespace Despesa.Lite.Infra.Data.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : EntityBase, new()
    {
        ContextSQL db;
        DbSet<T> dbSet;

        public Repository()
        {
            db = new ContextSQL();
            dbSet = db.Set<T>();
        }

        public virtual T Ativar(T obj)
        {
            obj.Ativo = true;

            var entry = db.Entry(obj);

            dbSet.Attach(obj);

            entry.State = EntityState.Modified;

            Salvar();

            return obj;

        }
        public virtual T Atualizar(T obj)
        {
            obj.AtualizadoPor = HttpContext.Current.User.Identity.Name;

            var entry = db.Entry(obj);

            dbSet.Attach(obj);

            entry.State = EntityState.Modified;

            Salvar();

            return obj;

        }
        public virtual T Criar(T obj)
        {
            obj.CriadoEm = DateTime.Now.Date;
            obj.Ativo = true;
            obj.CriadoPor = HttpContext.Current.User.Identity.Name;

            dbSet.Add(obj);

            Salvar();

            return obj;
        }
        public virtual T Desativar(T obj)
        {

            obj.Ativo = false;
            obj.DesativadoPor = HttpContext.Current.User.Identity.Name;

            var entry = db.Entry(obj);

            dbSet.Attach(obj);

            entry.State = EntityState.Modified;

            Salvar();

            return obj;
        }
        public virtual void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(this);
        }
        public virtual IEnumerable<T> Pesquisar(Expression<Func<T, bool>> Expressao)
        {
            return dbSet.Where(Expressao);
        }
        public virtual int Remover(T obj)
        {
            obj.Deletado = true;
            obj.DeletadoEm = DateTime.Now.Date;
            obj.DeletadoPor = HttpContext.Current.User.Identity.Name;
            obj.Ativo = false;

            var entry = db.Entry(obj);

            dbSet.Attach(obj);

            entry.State = EntityState.Modified;

            return Salvar();
        }
        public virtual int Salvar()
        {
           return db.SaveChanges();
        }
        public virtual T TrazerPorId(Guid Id)
        {
           return dbSet.SingleOrDefault(e => e.Id == Id);
        }
        public virtual IEnumerable<T> TrazerTodos()
        {
            return dbSet;
        }
        public virtual IEnumerable<T> TrazerTodosAtivos()
        {
            return dbSet.Where(e => e.Ativo == true);
        }
        public virtual IEnumerable<T> TrazerTodosDeletados()
        {
            return dbSet.Where(e => e.Deletado == true);
        }
        public virtual IEnumerable<T> TrazerTodosInativos()
        {
            return dbSet.Where(e => e.Ativo == false);
        }
    }
}
