using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _21_AspNetMvcRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");  //.axd uzantilara erisim yasaklaniyor.(guvenlik icin)

            //Mvc Nedir? Nasil Kullanilir?
            //mvc-nedir-nasil-kullanilir
            //...makale/goster/mvc-nedir-nasil-kullanilir

            routes.MapRoute(
           name: "hakkimizda",
           url: "Hakkimizda",
           defaults: new { controller = "Makele", action = "Goster", makaleadi = UrlParameter.Optional }
       );




            routes.MapRoute(
            name: "hakkimizda",
            url: "Hakkimizda",
            defaults: new { controller = "Home", action = "About", id = 1, url = "abc" }
        );
            routes.MapRoute(
            name: "iletisim",
            url: "Iletisim",
            defaults: new { controller = "Home", action = "Contact", id = 1, url = "abc" }
        );
            routes.MapRoute(
               name: "anasayfa",
               url: "Anasayfa",
               defaults: new { controller = "Home", action = "Index", id=1,url="abc" }
           );


            routes.MapRoute(
            name: "Default2",
            url: "{controller}/Belge/{belgeNo}", //Home/Index(int id)
            defaults: new { controller = "Home", action = "Belge", belgeNo = UrlParameter.Optional }
        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", //Home/Index(int id)
                defaults: new { controller = "Home", action = "Index",id=UrlParameter.Optional}
            );

          
        }
    }
}
