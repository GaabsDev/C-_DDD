using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using VisualTicket.Entities;

namespace Domain.Entities
{
    [Table("problems")]
    public class Problem
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("causa")]
        public string Causa { get; set; }

        [Column("impactos")]
        public string Impactos { get; set; }

        [Column("numChamado1")]
        public int NumChamado1 { get; set; }

        [Column("numChamado2")]
        public int NumChamado2 { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("funcionario_id")]
        public int FuncionarioId { get; set; }

        [Column("titulo")]
        public string Titulo { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [ForeignKey("FuncionarioId")]
        public virtual Funcionario Funcionario { get; set; }


        public Problem()
        {

        }

        public Problem(int id, string causa, string impactos, int numChamado1, int numChamado2, string descricao, string titulo, int funcId, string username, string email)
        {
            Id = id;
            Causa = causa;
            Impactos = impactos;
            NumChamado1 = numChamado1;
            NumChamado2 = numChamado2;
            Descricao = descricao;
            Titulo = titulo;
            FuncionarioId = funcId;
            Email = email;
            Username = username;
        }

    }
}