using Infra.Services.Interfaces;
using Infra.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Infra.ViewModel;

namespace VisualTicket.Controllers
{
    public class HomeController : Controller
    {
        private readonly IChamadoService _chamadoService;

        public HomeController()
        {
            _chamadoService = new ChamadoService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var listarChamados = _chamadoService.ListarChamados();
            var vm = listarChamados.Select(x => new ChamadoViewModel()
            {
                Descricao = x.Descricao,
                Funcionario = x.Funcionario,
                Id = x.Id,
                PrecisaAprovacao = x.PrecisaAprovacao,
                Prioridade = x.Prioridade,
                Severidade = x.Severidade,
                Sistema = x.Sistema,
                Titulo = x.Titulo
            }).ToList();
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Gerenciador de Chamados VisualTicket.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Entre em contato conosco.";

            return View();
        }
    }
}