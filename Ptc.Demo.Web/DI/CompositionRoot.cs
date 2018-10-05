using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Ptc.Demo.Web.DI
{
    public class CompositionRoot
    {
        public static IDependencyInjectionContainer Compose()
        {

            // Create a container builder
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ServiceModule());
            builder.RegisterModule(new MvcSiteMapProviderModule());
            builder.RegisterModule(new MvcModule());

            var container = builder.Build();

            var resolver = new AutofacDependencyResolver(container);

            DependencyResolver.SetResolver(resolver);

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
       
            return new AutofacDependencyInjectionContainer(container);

        }
    }
}