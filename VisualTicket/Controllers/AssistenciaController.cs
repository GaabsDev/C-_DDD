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
    public class AssistenciaController : Controller
    {
        private readonly IChamadoService _chamadoService;
        private readonly ISistemaService _sistemaService;
        private readonly ISeveridadeService _severidadeService;
        private readonly IPrioridadeService _prioridadeService;
        private readonly IProblemService _problemService;
        private readonly IChangeService _changeService;

        public AssistenciaController()
        {
            _chamadoService = new ChamadoService();
            _sistemaService = new SistemaService();
            _severidadeService = new SeveridadeService();
            _prioridadeService = new PrioridadeService();
            _problemService = new ProblemService();
            _changeService = new ChangeService();
        }

        // GET: Assistencia
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CriarChamado()
        {
            var itemsSistema = _sistemaService.ListarSistemas();
            var itemsSeveridade = _severidadeService.ListarSeveridades();
            var itemsPrioridade = _prioridadeService.ListarPrioridades();
            var vm = new ChamadoViewModel() {
                Sistemas = itemsSistema.ToList(),
                Prioridades = itemsPrioridade.ToList(),
                Severidades = itemsSeveridade.ToList()
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult CriarChamado(ChamadoViewModel model)
        {
            model.FuncionarioId = Convert.ToInt32(Session["UserId"]);
            model.SistemaId = Convert.ToInt32(Request.Form["Sistemas"]);
            model.SeveridadeId = Convert.ToInt32(Request.Form["Severidades"]);
            model.PrioridadeId = Convert.ToInt32(Request.Form["Prioridades"]);
            _chamadoService.CriarChamado(model);
            return RedirectToAction("ListarChamados","Assistencia");
        }

        [HttpGet]
        public ActionResult EditarChamado(int id)
        {
            var itemsSistema = _sistemaService.ListarSistemas();
            var itemsSeveridade = _severidadeService.ListarSeveridades();
            var itemsPrioridade = _prioridadeService.ListarPrioridades();
            var selecionarChamado = _chamadoService.GetChamado(id);
            var vm = new ChamadoViewModel() {
                Descricao = selecionarChamado.Descricao,
                FuncionarioId = selecionarChamado.FuncionarioId,
                PrioridadeId = selecionarChamado.PrioridadeId,
                SeveridadeId = selecionarChamado.SeveridadeId,
                SistemaId = selecionarChamado.SistemaId,
                Titulo = selecionarChamado.Titulo,
                Email = selecionarChamado.Funcionario.Email,
                Username = selecionarChamado.Funcionario.Username,
                Sistemas = itemsSistema.ToList(),
                Prioridades = itemsPrioridade.ToList(),
                Severidades = itemsSeveridade.ToList()
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult EditarChamado(ChamadoViewModel model)
        {
            model.SistemaId = Convert.ToInt32(Request.Form["SistemaId"]);
            model.SeveridadeId = Convert.ToInt32(Request.Form["SeveridadeId"]);
            model.PrioridadeId = Convert.ToInt32(Request.Form["PrioridadeId"]);
            _chamadoService.UpdateChamado(model);
            return RedirectToAction("ListarChamados", "Assistencia");
        }

        [HttpGet]
        public ActionResult ListarChamados()
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

        //////////////////////////////////////////////// PROBLEMS - INICIO ///////////////////////////////////////

        [HttpGet]
        public ActionResult ListarProblems()
        {
            var listarProblems = _problemService.ListarProblems();
            var vm = listarProblems.Select(x => new ProblemViewModel()
            {
                Descricao = x.Descricao,
                Funcionario = x.Funcionario,
                Id = x.Id,
                Titulo = x.Titulo,
                Email = x.Email,
                Causa = x.Causa,
                Impactos = x.Impactos,
                NumChamado1 = x.NumChamado1,
                NumChamado2  = x.NumChamado2,
                Username = x.Username
            }).ToList();
            return View(vm);
        }

        public ActionResult CriarProblem()
        {
            var itemsChamados = _chamadoService.ListarChamados();
            var vm = new ProblemViewModel()
            {
                Chamados = itemsChamados.ToList(),
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult CriarProblem(ProblemViewModel model)
        {
            string[] values = Request.Form.GetValues("Chamados");
            model.NumChamado1 = Convert.ToInt32(values[0]);
            model.NumChamado2 = Convert.ToInt32(values[1]);
            model.FuncionarioId = Convert.ToInt32(Session["UserId"]);
            _problemService.CriarProblem(model);
            return RedirectToAction("ListarProblems", "Assistencia");
        }

        [HttpGet]
        public ActionResult EditarProblem(int id)
        {
            var selecionarChamado = _problemService.GetProblem(id);
            var itemsChamados = _chamadoService.ListarChamados();

            var vm = new ProblemViewModel()
            {
                Descricao = selecionarChamado.Descricao,
                FuncionarioId = selecionarChamado.FuncionarioId,
                Titulo = selecionarChamado.Titulo,
                Email = selecionarChamado.Funcionario.Email,
                Username = selecionarChamado.Funcionario.Username,
                Causa = selecionarChamado.Causa,
                Chamados = itemsChamados.ToList(),
                Id = selecionarChamado.Id,
                Impactos = selecionarChamado.Impactos,
                NumChamado1 = selecionarChamado.NumChamado1,
                NumChamado2 = selecionarChamado.NumChamado2,
                Funcionario = selecionarChamado.Funcionario
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult EditarProblem(ProblemViewModel model)
        {
            _problemService.UpdateProblem(model);
            return RedirectToAction("ListarProblems", "Assistencia");
        }

        //////////////////////////////////////////////// CHANGES - INICIO ///////////////////////////////////////


        [HttpGet]
        public ActionResult ListarChanges()
        {
            var listarChanges = _changeService.ListarChanges();
            var vm = listarChanges.Select(x => new ChangeViewModel()
            {
                Descricao = x.Descricao,
                Funcionario = x.Funcionario,
                Id = x.Id,
                Titulo = x.Titulo,
                Email = x.Email,
                Username = x.Username,
                AreasImpactadas = x.AreasImpactadas,
                DiaFim = x.DiaFim,
                DiaInicio = x.DiaInicio,
                LocalMudanca = x.LocalMudanca,
                PodeTerRollback = x.PodeTerRollback,
                Prioridade = x.Prioridade,
            }).ToList();
            return View(vm);
        }

        public ActionResult CriarChange()
        {
            var itemsPrioridade = _prioridadeService.ListarPrioridades();
            var vm = new ChangeViewModel()
            {
                Prioridades = itemsPrioridade.ToList(),
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult CriarChange(ChangeViewModel model)
        {
            model.FuncionarioId = Convert.ToInt32(Session["UserId"]);
            model.PrioridadeId = Convert.ToInt32(Request.Form["Prioridades"]);
            _changeService.CriarChange(model);
            return RedirectToAction("ListarChanges", "Assistencia");
        }

        [HttpGet]
        public ActionResult EditarChange(int id)
        {
            var selecionarChange = _changeService.GetChange(id);
            var itemsPrioridade = _prioridadeService.ListarPrioridades();

            var vm = new ChangeViewModel()
            {
                Descricao = selecionarChange.Descricao,
                Id = selecionarChange.Id,
                Titulo = selecionarChange.Titulo,
                Email = selecionarChange.Email,
                Username = selecionarChange.Username,
                AreasImpactadas = selecionarChange.AreasImpactadas,
                DiaFim = selecionarChange.DiaFim,
                DiaInicio = selecionarChange.DiaInicio,
                LocalMudanca = selecionarChange.LocalMudanca,
                PodeTerRollback = selecionarChange.PodeTerRollback,
                PrioridadeId = selecionarChange.PrioridadeId,
                FuncionarioId = selecionarChange.FuncionarioId,
                Prioridades = itemsPrioridade.ToList()
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult EditarChange(ChangeViewModel model)
        {
            model.PrioridadeId = Convert.ToInt32(Request.Form["Prioridades"]);
            _changeService.UpdateChange(model);
            return RedirectToAction("ListarChanges", "Assistencia");
        }
    }
}