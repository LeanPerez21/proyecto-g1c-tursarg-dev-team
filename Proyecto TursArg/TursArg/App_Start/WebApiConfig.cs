﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TursArg
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            //enable cors
            config.EnableCors(new EnableCorsAttribute("https://localhost:4200", headers: "*", methods: "*"));

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}