using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Ptc.Data.Condition2.Mssql.DI;
using Ptc.Demo.Web.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Ptc.Demo.Web.DI
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Assembly[] assColl = new System.Reflection.Assembly[]
            {
               Assembly.Load("Ptc.Demo.Service"),
               Assembly.Load("Ptc.Demo.Domain"),
               Assembly.Load("Ptc.Demo.Web"),
            };

            builder.RegisterAssemblyTypes(assColl).AsImplementedInterfaces().SingleInstance();
    
            builder.RegisterControllers(System.Reflection.Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(System.Reflection.Assembly.GetExecutingAssembly());

            builder.RegisterModule(new AutofacWebTypesModule());

            builder.RegisterModule(new MSSQLModule());
            
      
            builder.Register(x => Ptc.Logger.NLogManager.CreateInstance().SystemLog).As<Ptc.Logger.ILogger>().SingleInstance();

            builder.RegisterType<AuthenticationFilter>().PropertiesAutowired();

            builder.RegisterWebApiFilterProvider(System.Web.Http.GlobalConfiguration.Configuration);

            builder.RegisterFilterProvider();
        }


    }
}