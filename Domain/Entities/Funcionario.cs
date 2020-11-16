using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VisualTicket.Entities
{
    [Table("funcionarios")]
    public class Funcionario
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("departamento_id")]
        public int DepartamentoId { get; set; }

        [Column("cargo_id")]
        public int CargoId { get; set; }

        [Column("perfilAcesso")]
        public string PerfilAcesso { get; set; }

        [ForeignKey("DepartamentoId")]
        public virtual Departamento Departamento { get; set; }

        [ForeignKey("CargoId")]
        public virtual Cargo Cargo { get; set; }


        public Funcionario()
        {

        }

        public Funcionario(string nome, string username, string senha, int id, int departamento, int cargo, string perfilAcesso, string email)
        {
            CargoId = cargo;
            DepartamentoId = departamento;
            Id = id;
            Nome = nome;
            Username = username;
            Senha = senha;
            PerfilAcesso = perfilAcesso;
            Email = email;
        }

    }
}