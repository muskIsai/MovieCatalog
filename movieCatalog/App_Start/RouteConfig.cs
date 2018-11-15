using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ovidio_mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Catalogo", action = "Index", id = UrlParameter.Optional }
                //Vai apontar action no nosso Catalogo. Significa q Catalogo sera a pagina d inicio (Home)
                /*ACTIONS: indicam ondem onde seram direcionados a nossa pagina qdo o site for aberto. Noos decidimos isso onde
                queremos q seja apontado */
            );
        }
    }
}
