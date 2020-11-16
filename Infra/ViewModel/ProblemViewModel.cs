using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VisualTicket.Entities;

namespace Infra.ViewModel
{
    public class ProblemViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Causa")]
        public string Causa { get; set; }

        [Display(Name = "Impactos")]
        public string Impactos { get; set; }

        [Display(Name = "Número Chamado 1")]
        public int NumChamado1 { get; set; }

        [Display(Name = "Número Chamado 2")]
        public int NumChamado2 { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public int FuncionarioId { get; set; }

        [Display(Name = "Funcionário")]
        public Funcionario Funcionario { get; set; }

        [Display(Name = "Título Problema")]
        public string Titulo { get; set; }

        [Display(Name = "Email Solicitante")]
        public string Email { get; set; }

        public string Username { get; set; }

        public List<Chamado> Chamados{ get; set; }

    }
}