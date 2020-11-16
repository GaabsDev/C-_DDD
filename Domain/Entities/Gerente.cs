using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VisualTicket.Entities
{
    [Table("gerentes")]
    public class Gerente
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("departamento_id")]
        public int DepartamentoId { get; set; }

        [Column("cargo_id")]
        public int CargoId { get; set; }

        [ForeignKey("DepartamentoId")]
        public virtual Departamento Departamento { get; set; }

        [ForeignKey("CargoId")]
        public virtual Cargo Cargo { get; set; }

        public Gerente()
        {

        }

        public Gerente(int id, string nome, string username, int departamento, int cargo)
        {
            Id = id;
            Nome = nome;
            Username = username;
            DepartamentoId = departamento;
            CargoId = cargo;
        }
    }
}