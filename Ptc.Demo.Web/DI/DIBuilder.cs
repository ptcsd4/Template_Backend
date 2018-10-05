using Autofac;
using Ptc.Data.Condition2.Mssql.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Ptc.Demo.Web.DI
{
    public  static class DIBuilder
    {
        public static Autofac.IContainer container;

        public static T GetObject<T>()
        {
            var builder = new ContainerBuilder();

            Assembly[] assColl = new System.Reflection.Assembly[]
            {
               Assembly.Load("Ptc.Demo.Service"),
               Assembly.Load("Ptc.Demo.Domain"),
               Assembly.Load("Ptc.Demo.Web"),
            };

            builder.RegisterAssemblyTypes(assColl).AsImplementedInterfaces().SingleInstance();

            builder.RegisterModule(new MSSQLModule());

            builder.Register(x => Ptc.Logger.NLogManager.CreateInstance().SystemLog).As<Ptc.Logger.ILogger>().SingleInstance();
    
       
            container = builder.Build();


            return container.Resolve<T>();
        }
    }
}