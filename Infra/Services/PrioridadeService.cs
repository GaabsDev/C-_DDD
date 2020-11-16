using Infra.Contexts;
using Infra.Repositories;
using Infra.Repositories.Interface;
using Infra.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisualTicket.Entities;

namespace Infra.Services
{
    public class PrioridadeService : IPrioridadeService
    {
        private readonly IPrioridadeRepository _repository;

        public PrioridadeService()
        {
            _repository = new PrioridadeRepository(new VisualTicketContext());
        }

        public IEnumerable<Prioridade> ListarPrioridades()
        {
            return _repository.Select();
        }
    }
}