using Infra.Services;
using Infra.Services.Interfaces;
using Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace VisualTicket.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController()
        {
            _loginService = new LoginService();
        }

        // GET: Login
        public ActionResult Index()
        {
            var model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            var user = _loginService.AutenticarUsuario(model);
            //var user = _loginService.AutenticarUsuario(model);

            if (user == null)
                ModelState.AddModelError("", "Usuário não encontado!!");

            if (ModelState.IsValid)
            {
                Session["UserId"] = user.Id;
                Session["UserName"] = user.Username;
                Session["Perfil"] = user.PerfilAcesso;
                Session["NomeUsuario"] = user.Nome;
                Session["EmailUsuario"] = user.Email;
                
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }


        public ActionResult EsqueciSenha()
        {
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}