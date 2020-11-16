using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VisualTicket.Entities
{
    [Table("sistemas")]
    public class Sistema
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("versao")]
        public string Versao { get; set; }

        [Column("ultima_licenca")]
        public DateTime UltimaVersao { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        public Sistema()
        {

        }

        public Sistema(int id, string versao, DateTime ultimaVersao, string nome, string descricao)
        {
            Id = id;
            Versao = versao;
            UltimaVersao = ultimaVersao;
            Nome = nome;
            Descricao = descricao;
        }
    }
}