using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Web.DI
{
    public interface IDependencyInjectionContainer
    {
        object GetInstance(Type type);
        object TryGetInstance(Type type);
        IEnumerable<object> GetAllInstances(Type type);
        void Release(object instance);
    }
}
