using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VisualTicket.Entities
{
    [Table("departamentos")]
    public class Departamento
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("gerente")]
        public int Gerente { get; set; }

        public Departamento()
        {

        }

        public Departamento(int id, string descricao, int gerente)
        {
            Id = id;
            Descricao = descricao;
            Gerente = gerente;
        }
    }
}