using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VisualTicket.Entities
{
    [Table("cargos")]
    public class Cargo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; } 

        public Cargo()
        {

        }

        public Cargo(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}