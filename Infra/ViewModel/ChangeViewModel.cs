using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VisualTicket.Entities;

namespace Infra.ViewModel
{
    public class ChangeViewModel
    {

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Local Mudança")]
        public string LocalMudanca { get; set; }

        [Display(Name = "Áreas Impactadas")]
        public string AreasImpactadas { get; set; }

        [Display(Name = "Pode ter rollback?")]
        public bool PodeTerRollback { get; set; }

        [Display(Name = "Data Inicio")]
        public DateTime DiaInicio { get; set; }

        [Display(Name = "Data Fim")]
        public DateTime DiaFim { get; set; }

        public int PrioridadeId { get; set; }

        [Display(Name = "Prioridade")]
        public Prioridade Prioridade { get; set; }

        public List<Prioridade> Prioridades { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public int FuncionarioId { get; set; }

        [Display(Name = "Funcionário")]
        public Funcionario Funcionario { get; set; }

        [Display(Name = "Email Solicitante")]
        public string Email { get; set; }

        public string Username { get; set; }

        [Display(Name = "Título")]
        public string Titulo { get; set; }
    }
}