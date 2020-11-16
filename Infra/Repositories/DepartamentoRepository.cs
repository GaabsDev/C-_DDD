using Infra.Contexts;
using Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisualTicket.Entities;

namespace Infra.Repositories
{
    public class DepartamentoRepository : Repository<Departamento>, IDepartamentoRepository, IDisposable
    {
        public DepartamentoRepository(VisualTicketContext db) : base(db)
        {
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}