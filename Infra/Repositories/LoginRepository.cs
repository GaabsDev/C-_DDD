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
    public class LoginRepository : Repository<Funcionario>, ILoginRepository, IDisposable
    {
        public LoginRepository(VisualTicketContext db) : base(db)
        {
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public Funcionario AutenticarUsuario(LoginViewModel model)
        {
           var user = _db.Funcionarios.First(x => x.Username == model.Username && x.Senha == model.Senha);
           return user;
        }
    }
}