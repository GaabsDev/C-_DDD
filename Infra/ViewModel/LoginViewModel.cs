using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Infra.ViewModel
{
    public class LoginViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Infome um username válido", AllowEmptyStrings = false)]
        public string Username { get; set; }

        [Display(Name = "Senha")]
        [StringLength(8)]
        [Required(ErrorMessage = "Informe uma senha válida")]
        public string Senha { get; set; }
    }
}