using Infra.Contexts;
using Infra.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisualTicket.Entities;
using VisualTicket.Repositories.Interface;
using VisualTicket.Repositories.Repository;

namespace Infra.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IUsuarioRepository _repository;

        public FuncionarioService()
        {
            _repository = new UsuarioRepository(new VisualTicketContext());
        }

        public IEnumerable<Funcionario> ListarFuncionarios()
        {
            return _repository.Select();
        }
    }
}