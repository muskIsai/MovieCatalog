using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ovidio_mvc.Models
{
    public class Login
    {
        [Display(Name = "E-mail")]
        [EmailAddress]
        [Required(ErrorMessage = "Informe seu e-mail", AllowEmptyStrings =false)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Digite a senha")]
        public string Senha { get; set; }
    }
}