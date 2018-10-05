using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ptc.Demo.Web.DI
{
    public static class DependencyInjectionContainerExtensions
    {
        public static T GetInstance<T>(this IDependencyInjectionContainer container)
        {
            return (T)container.GetInstance(typeof(T));
        }
    }
}