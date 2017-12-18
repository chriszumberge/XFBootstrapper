using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XFBootstrapper.Business;
using ZESoft.Common;

namespace XFBootstrapper.OpenWebAPI.Controllers
{
    public class FeatureConfigurationController : ApiController
    {
        PluginLoader mPluginLoader = DIServiceProvider.GetInstance().Create<PluginLoader>();

    }
}
