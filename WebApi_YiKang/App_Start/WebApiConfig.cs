using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi_YiKang
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            //跨域配置
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "risApi",
                routeTemplate: "ris/api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // 2023-06-15, Bruce
            config.Routes.MapHttpRoute(
                name: "YiKangApi",
                routeTemplate: "devices/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //

            //移除xml返回格式数据
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            //配置返回的时间类型数据格式  
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.Converters.Add(
                new Newtonsoft.Json.Converters.IsoDateTimeConverter()
                {
                    DateTimeFormat = "yyyy-MM-dd HH:mm:ss"
                }
            );

        }

    }

}
