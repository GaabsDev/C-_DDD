using Infra.Contexts;
using Infra.Repositories.Interface;
using Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisualTicket.Entities;

namespace Infra.Repositories
{
    public class ChamadoRepository : Repository<Chamado>, IChamadoRepository, IDisposable
    {
        public ChamadoRepository(VisualTicketContext db) : base(db)
        {
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}