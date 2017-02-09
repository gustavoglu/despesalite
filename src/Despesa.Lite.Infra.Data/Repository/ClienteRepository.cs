using Despesa.Lite.Domain;
using Despesa.Lite.Domain.Interfaces.Repository;
using Despesa.Lite.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Despesa.Lite.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        ContextSQL db;

        public override Cliente TrazerPorId(Guid Id)
        {
            db = new ContextSQL();

            var usuario = db.Set<Usuario>().SingleOrDefault(u => u.UserName == HttpContext.Current.User.Identity.Name);
            var Companhia = usuario.Companhia;

            if (Companhia)
            {
                return base.TrazerPorId(Id);
            }
            else
            {
                return db.Set<Cliente>().SingleOrDefault(c => c.Id == Id && c.CriadoPor == usuario.UserName);
            }


        }
        public override IEnumerable<Cliente> TrazerTodosAtivos()
        {
            db = new ContextSQL();

            var usuario = db.Set<Usuario>().SingleOrDefault(u => u.UserName == HttpContext.Current.User.Identity.Name);
            var Companhia = usuario.Companhia;

            if (Companhia)
            {
                return base.TrazerTodosAtivos();
            }
            else
            {
                return

                    from cliente in db.Set<Cliente>()
                    join clienteusuario in db.Set<Cliente_Usuarios>() on cliente.Id equals clienteusuario.id_cliente
                    where clienteusuario.id_usuario == usuario.Id && cliente.Ativo == true
                    select cliente;
            }
        }

        public override IEnumerable<Cliente> TrazerTodos()
        {

            db = new ContextSQL();

            var usuario = db.Set<Usuario>().SingleOrDefault(u => u.UserName == HttpContext.Current.User.Identity.Name);
            var Companhia = usuario.Companhia;

            if (Companhia)
            {
                return base.TrazerTodos();
            }
            else
            {
                return

                   from cliente in db.Set<Cliente>()
                   join clienteusuario in db.Set<Cliente_Usuarios>() on cliente.Id equals clienteusuario.id_cliente
                   where clienteusuario.id_usuario == usuario.Id 
                   select cliente;
            }
        }

        public override IEnumerable<Cliente> TrazerTodosDeletados()
        {

            db = new ContextSQL();

            var usuario = db.Set<Usuario>().SingleOrDefault(u => u.UserName == HttpContext.Current.User.Identity.Name);
            var Companhia = usuario.Companhia;

            if (Companhia)
            {
                return base.TrazerTodosDeletados();
            }
            else
            {
                return

                   from cliente in db.Set<Cliente>()
                   join clienteusuario in db.Set<Cliente_Usuarios>() on cliente.Id equals clienteusuario.id_cliente
                   where clienteusuario.id_usuario == usuario.Id && cliente.Deletado == true
                   select cliente;
            }
        }

        public override IEnumerable<Cliente> TrazerTodosInativos()
        {

            db = new ContextSQL();

            var usuario = db.Set<Usuario>().SingleOrDefault(u => u.UserName == HttpContext.Current.User.Identity.Name);
            var Companhia = usuario.Companhia;

            if (Companhia)
            {
                return base.TrazerTodosInativos();
            }
            else
            {
                return

                   from cliente in db.Set<Cliente>()
                   join clienteusuario in db.Set<Cliente_Usuarios>() on cliente.Id equals clienteusuario.id_cliente
                   where clienteusuario.id_usuario == usuario.Id && cliente.Ativo == false
                   select cliente;
            }
        }
    }
}
