using Domain.Entities;
using Infra.Contexts;
using Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infra.Repositories
{
    public class ChangeRepository : Repository<Change>, IChangeRepository, IDisposable
    {
        public ChangeRepository(VisualTicketContext db) : base(db)
        {
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}