using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VisualTicket.Entities
{
    [Table("chamados")]
    public class Chamado
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("funcionario_id")]
        public int FuncionarioId { get; set; }

        [Column("prioridade_id")]
        public int PrioridadeId { get; set; }

        [Column("severidade_id")]
        public int SeveridadeId { get; set; }

        [Column("sistema_id")]
        public int SistemaId { get; set; }

        [Column("titulo")]
        public string Titulo { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("precisa_aprovacao")]
        public bool PrecisaAprovacao { get; set; }

        [ForeignKey("PrioridadeId")]
        public virtual Prioridade Prioridade { get; set; }

        [ForeignKey("SeveridadeId")]
        public virtual Severidade Severidade { get; set; }

        [ForeignKey("SistemaId")]
        public virtual Sistema Sistema { get; set; }

        [ForeignKey("FuncionarioId")]
        public virtual Funcionario Funcionario { get; set; }

        public string ConcatDescricao
        {
            get
            {
                return string.Format("{0} - {1}", Id, Titulo);
            }
        }

        public Chamado(){

        }

        public Chamado(int id, int prioridade, int severidade, int usuario, int sistema, string titulo, string descricao, bool precisaAprovacao)
        {
            Id = id;
            PrioridadeId = prioridade;
            SeveridadeId = severidade;
            FuncionarioId = usuario;
            SistemaId = sistema;
            Titulo = titulo;
            Descricao = descricao;
            PrecisaAprovacao = precisaAprovacao;
        }
    }
}