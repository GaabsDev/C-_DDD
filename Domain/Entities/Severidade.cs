using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VisualTicket.Entities
{
    [Table("severidades")]
    public class Severidade
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }


        public Severidade()
        {

        }

        public Severidade(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

    }
}