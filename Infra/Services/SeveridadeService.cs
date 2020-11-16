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
    public class SeveridadeService : ISeveridadeService
    {
        private readonly ISeveridadeRepository _repository;

        public SeveridadeService()
        {
            _repository = new SeveridadeRepository(new VisualTicketContext());
        }

        public IEnumerable<Severidade> ListarSeveridades()
        {
            return _repository.Select();
        }
    }
}