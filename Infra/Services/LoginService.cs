using Infra.Contexts;
using Infra.Repositories;
using Infra.Repositories.Interface;
using Infra.Services.Interfaces;
using Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisualTicket.Entities;

namespace Infra.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _repository;

        public LoginService()
        {
            _repository = new LoginRepository(new VisualTicketContext());
        }
        public Funcionario AutenticarUsuario(LoginViewModel model)
        {
            var user = _repository.AutenticarUsuario(model);
            return user;
        }
    }
}