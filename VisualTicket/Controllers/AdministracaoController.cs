using Infra.Services;
using Infra.Services.Interfaces;
using Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VisualTicket.Controllers
{
    public class AdministracaoController : Controller
    {
        private readonly IFuncionarioService _funcionarioService;

        public AdministracaoController()
        {
            _funcionarioService = new FuncionarioService();
        }

        // GET: Administracao
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Perfis()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Usuario()
        {
            var listarFuncionarios = _funcionarioService.ListarFuncionarios();
            var vm = listarFuncionarios.Select(x => new FuncionarioViewModel()
            {
                Cargo = x.Cargo,
                Departamento = x.Departamento,
                Email = x.Email,
                Id = x.Id,
                Nome = x.Nome,
                Username = x.Username,
                PerfilAcesso = x.PerfilAcesso
            }).ToList();
            return View(vm);
        }
    }
}