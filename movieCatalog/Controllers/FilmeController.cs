using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ovidio_mvc.Controllers
{
    [Authorize] //Vamos dzr q, so pode acessar essa pagina (controller) quem for autorizado
    public class FilmeController : Controller //Esse crontroller vamos usar p/ exibir filmes "Filme"s
    {
        // GET: Filme
        public ActionResult Exibir(string Id) //Id - sera o nome do filme
        {
            ViewBag.Titulo = Id;
            switch(Id)
            {
                case "Mulher Maravilha": //Qdo o titulo for "Mulher Maravilha", vai apontar p/ o link do Youtube
                    ViewBag.Url = "https://www.youtube.com/embed/Eg8qFkwUmOw"; 
                    break;
                case "Senhor dos aneis":
                    ViewBag.Url = "https://www.youtube.com/embed/IUerKBZHnBs";
                    break;
                case "Game of thrones":
                    ViewBag.Url = "https://www.youtube.com/embed/v5gsVRxzzI4";
                    break;
                case "Douctor Estranho":
                    ViewBag.Url = "https://www.youtube.com/embed/ugKSYzTpAJA";
                    break;
                case "Fast furious 8":
                    ViewBag.Url = "https://www.youtube.com/embed/uisBaTkQAEs";
                    break;
                case "O Lobo de Wall Street":
                    ViewBag.Url = "https://www.youtube.com/embed/C0FSv6yMzls";
                    break;
            }

            return View();
        }
    }
}