using Infra.Contexts;
using Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisualTicket.Entities;
using VisualTicket.Repositories.Interface;

namespace VisualTicket.Repositories.Repository
{
    public class UsuarioRepository : Repository<Funcionario>, IUsuarioRepository, IDisposable
    {
        public UsuarioRepository(VisualTicketContext db) : base(db)
        {
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}