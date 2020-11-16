using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VisualTicket.Entities;

namespace Infra.ViewModel
{
    public class FuncionarioViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Departamento")]
        public Departamento Departamento { get; set; }

        [Display(Name = "Cargo")]
        public Cargo Cargo { get; set; }

        [Display(Name = "Username")]
        public string Username { get; set; }

        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Display(Name = "Perfil Acesso")]
        public string PerfilAcesso { get; set; }

        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        public int DepartamentoId { get; set; }

        public List<Departamento> Departamentos { get; set; }

        public int CargoId { get; set; }

        public List<Cargo> Cargos { get; set; }

        public string Gerente { get; set; }

    }
}