using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Domain
{
    public class Usuario : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Usuario> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;

           
            
        }

        public bool Companhia { get; set; }

        public bool Ativo { get; set; }

        public bool Deletado { get; set; }

        public string id_companhia { get; set; }

        public Guid id_conta_usuario { get; set; }

        public virtual ICollection<Cliente_Usuarios> Cliente_Usuarios { get; set; }
    }
}
