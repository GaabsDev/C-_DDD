using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using VisualTicket.Entities;

namespace Domain.Entities
{
    [Table("changes")]
    public class Change
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("localMudanca")]
        public string LocalMudanca { get; set; }

        [Column("areasImpactadas")]
        public string AreasImpactadas { get; set; }

        [Column("podeTerRollBack")]
        public bool PodeTerRollback { get; set; }

        [Column("diaInicio")]
        public DateTime DiaInicio { get; set; }

        [Column("diaFim")]
        public DateTime DiaFim { get; set; }

        [Column("prioridade_id")]
        public int PrioridadeId { get; set; }

        [ForeignKey("PrioridadeId")]
        public virtual Prioridade Prioridade { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("funcionario_id")]
        public int FuncionarioId { get; set; }

        [Column("titulo")]
        public string Titulo { get; set; }

        [ForeignKey("FuncionarioId")]
        public virtual Funcionario Funcionario { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("email")]
        public string Email { get; set; }


        public Change()
        {

        }

        public Change(int id, string localMudanca, string areasImpactadas, bool podeTerRollBack, DateTime diaInicio, DateTime diaFim, int prioridadeId, string descricao, string titulo, int funcId, string email, string username)
        {
            Id = id;
            LocalMudanca = localMudanca;
            AreasImpactadas = areasImpactadas;
            PodeTerRollback = podeTerRollBack;
            DiaInicio = diaInicio;
            DiaFim = diaFim;
            PrioridadeId = prioridadeId;
            Descricao = descricao;
            Titulo = titulo;
            FuncionarioId = funcId;
            Username = username;
            Email = email;
        }

    }
}