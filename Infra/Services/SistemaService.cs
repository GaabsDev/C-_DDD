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
    public class SistemaService : ISistemaService
    {
        private readonly ISistemaRepository _repository;

        public SistemaService()
        {
            _repository = new SistemaRepository(new VisualTicketContext());
        }

        public IEnumerable<Sistema> ListarSistemas()
        {
            return _repository.Select();
        }
    }
}