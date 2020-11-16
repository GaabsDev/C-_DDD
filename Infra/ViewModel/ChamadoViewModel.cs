using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VisualTicket.Entities;

namespace Infra.ViewModel
{
    public class ChamadoViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        public string Username { get; set; }

        public int PrioridadeId { get; set; }

        [Display(Name = "Prioridade")]
        public Prioridade Prioridade { get; set; }

        public List<Prioridade> Prioridades { get; set; }

        public int SeveridadeId { get; set; }

        [Display(Name = "Severidade")]
        public Severidade Severidade { get; set; }

        public List<Severidade> Severidades { get; set; }

        public int FuncionarioId { get; set; }

        [Display(Name="Funcionário")]
        public Funcionario Funcionario { get; set; }

        public int SistemaId { get; set; }

        [Display(Name = "Sistema")]
        public Sistema Sistema { get; set; }

        [Display(Name = "Sistema")]
        public List<Sistema> Sistemas { get; set; }

        [Display(Name = "Precisa Aprovação?")]
        public bool PrecisaAprovacao { get; set; }

        [Display(Name = "Título Chamado")]
        public string Titulo { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Email Solicitante")]
        public string Email { get; set; }
        

    }
}