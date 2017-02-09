using Despesa.Lite.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa.Lite.Application.ViewModels
{
   public class Cliente_UsuariosViewModel
    {
        [Key]
        public Guid Id  { get; set; }

        [Required(ErrorMessage ="")]
        public Usuario Usuario{ get; set; }

        [Required(ErrorMessage = "")]
        public Cliente Cliente { get; set; }
    }
}
