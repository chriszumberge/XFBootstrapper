using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XFBootstrapper.Business;
using ZESoft.Common;

namespace XFBootstrapper.OpenWebAPI
{
    public static class XFBStartup
    {
        public static void Init()
        {
            RegisterCreators();
            RegisterRepositories();
        }

        private static void RegisterCreators()
        {
            DIServiceProvider.GetInstance().RegisterServiceAsGlobalInstance<PluginLoader>();
        }

        private static void RegisterRepositories()
        {

        }
    }
}