using Domain.Entities;
using Infra.Contexts;
using Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infra.Repositories
{
    public class ProblemRepository: Repository<Problem>, IProblemRepository, IDisposable
    {
        public ProblemRepository(VisualTicketContext db) : base(db)
        {
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}