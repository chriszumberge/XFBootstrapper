using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using XFBootstrapper.Business;
using XFBootstrapper.Extensibility;
using XFBootstrapper.OpenWebAPI.ViewModels;
using ZESoft.Common;

namespace XFBootstrapper.OpenWebAPI.Controllers
{
    public class FeaturesController : ApiController
    {
        PluginLoader mPluginLoader = DIServiceProvider.GetInstance().Create<PluginLoader>();

        /// <summary>
        /// Gets all the available features.
        /// </summary>
        /// <returns>A list of FeatureViewModel objects.</returns>
        /// <seealso cref="XFBootstrapper.OpenWebAPI.ViewModels.FeatureViewModel"/>
        [Route("api/Features")]
        [HttpGet]        
        [ResponseType(typeof(List<FeatureViewModel>))]
        [EnableCors(origins: "http://xfbootstrapper.azurewebsites.net", headers: "*", methods: "*")]
        public IHttpActionResult Get()
        {
            var featureViewModels = ExtensionPoint.GetAll().Select(x => new FeatureViewModel(x)).ToList();

            foreach(IPlugin plugin in mPluginLoader.Plugins)
            {
                var featureVM = featureViewModels.FirstOrDefault(x => x.value == plugin.ExtensionPoint.Value);
                if (featureVM != null)
                {
                    featureVM.features.Add(new PluginViewModel(plugin));
                }
            }

            return Ok(featureViewModels);
        }
    }
}
