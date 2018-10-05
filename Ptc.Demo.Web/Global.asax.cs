using MultipartDataMediaFormatter;
using MultipartDataMediaFormatter.Infrastructure;
using Ptc.Data.Condition2;
using Ptc.Demo.Domain;
using Ptc.Demo.Domain.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Ptc.Demo.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            DataAccessConfiguration.Configure(DataSettingTable.Setups);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            SiteMenu.Init(MenuRootsData.Default());
        
            GlobalConfiguration.Configuration.Formatters.Add(new FormMultipartEncodedMediaTypeFormatter(new MultipartFormatterSettings()));
        }


    }
}
