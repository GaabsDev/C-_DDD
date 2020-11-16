using System;
using System.Collections.Generic;
//using System.Data.Entity;
using MySql.Data.Entity;
using System.Linq;
using System.Web;
using VisualTicket.Entities;
using System.Data.Entity;
using System.Data.Common;
using Domain.Entities;

namespace Infra.Contexts
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class VisualTicketContext : DbContext
    {
        public VisualTicketContext() : base("ellen") { }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Chamado> Chamados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Prioridade> Prioridades { get; set; }
        public DbSet<Severidade> Severidades { get; set; }
        public DbSet<Sistema> Sistemas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Change> Changes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<VisualTicketContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public VisualTicketContext(DbConnection existingConnection, bool contextOwnsConnection)
      : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}