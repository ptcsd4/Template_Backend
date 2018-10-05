using Ptc.Demo.Web;
using Ptc.Demo.Web.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(DIConfig), "Register")]

public class DIConfig
{
    public static void Register()
    {
        var container = CompositionRoot.Compose();

        SiteMapConfig.Register(container);

    }
}
