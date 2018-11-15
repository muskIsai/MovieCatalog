using Ovidio_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Ovidio_mvc.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar() //Sera argumanto vazio pq qdo Usuario silicitar pagina d cadastro ela vai retornar sem dados (vazio)
        {//qdo ele prencher e postar  a gente vai receber dados do Usuario qdo

            return View(new Usuario()); //"new Usuario" eh o nosso Model
        }

        [HttpPost] //Esse metodo vai receber um post
        //Criar Controller p/ receber os dado acima (Dados q o suario vai preenceher)
        public ActionResult Cadastrar(Usuario model)
        {
            if(ModelState.IsValid)//Cadastros dos Usuarios
            {
                //Como n temos BD, entao vamos salvar os dados do usuario cadastrado em uma "Session"
                Session[$"user.{model.Email}"] = model; //Nosso login
                return RedirectToAction("Index", "Catalogo");
            }

            return View();
        }


        //P/ gerar uma pagina d Login. Ja n vamos mais criar outro Controller p/ ele, podemos tbm apenas
        //criar uma rota q vai gerar a tal pagina
        [AllowAnonymous]
        public ActionResult Login()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            return View();
        }


        /*   Metodo q vai receber "ActionResult Login" q p/ autenticar o usuario  */
        [HttpPost]
        [AllowAnonymous] //Vamos permitir q qlqr um possa acessar a pagina d login
        public ActionResult Login(Login model, string url) 
        {//"string url" rediciona pra usuario q xta deslogado em qlqr parte do site
           
            var usuario = Session[$"user.{model.Email}"] as Usuario;
            if(usuario == null && usuario.Senha != model.Senha) //Se usuario for nulo, ele vai retornar ao view
            {
                return View();
            }

            //Isso vai indicar q o Usuario xta autenticado
            FormsAuthentication.SetAuthCookie(model.Email, true);


            if(!string.IsNullOrEmpty(url)) //Se ele n for nulo, manda ele pra ca ou p/ o catalogo
            {
                return RedirectToAction(url);
            }
            else
            {
                return RedirectToAction("Index", "Catalogo");
            }
        }
    }
}